﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Final_Project.Model;
using Final_Project.Utilities;

namespace Final_Project
{
	public partial class MainForm : Form
	{
        DatabaseHelper dbHelper;
        int listSelectedIndex = 0;
        int taskSelectedIndex = -1;
        List<Task> tasks;
        List<List> allLists;

		public MainForm()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
            //set up event handlers
            listBox1.SelectedIndexChanged += new EventHandler(listBox1_SelectedIndexChanged);

            GetData();
		}

        private void GetData()
        {
            dbHelper = new DatabaseHelper();
            allLists = dbHelper.GetLists();

            int previousIndex = listSelectedIndex;
            listBox1.DataSource = allLists;

			if ((previousIndex + 1) > allLists.Count)
			{
                if (allLists.Count == 0)
                {
                    listBox1.ClearSelected();
                    ResetInterface();
                }
                else
                {
                    listBox1.SelectedIndex = previousIndex - 1;
                }
			}
			else
			{
				listBox1.SelectedIndex = previousIndex;
			}
        }

        void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmdViewTaskDetails.Enabled = false;
            cmdDeleteTask.Enabled = false;
            cmdCompleteTask.Enabled = false;

            listSelectedIndex = listBox1.SelectedIndex;

            if (listSelectedIndex != -1)
            {
                List selectedList = ((List)(listBox1.Items[listSelectedIndex]));

                //clear taskBox
                taskBox.Items.Clear();

                //set label
                lblProjectName.Text = selectedList.Name;

                //populate taskBox
                tasks = dbHelper.GetTasksForList(selectedList.ID);
                foreach (Task t in tasks)
                {
                    if (t.IsCompleted())
                    {
                        taskBox.Items.Add("[COMPLETED] " + t.Name);
                    }
                    else
                    {
                        taskBox.Items.Add("[INCOMPLETE] " + t.Name);
                    }
                }

                drawProgressBar();
            }
        }

        private void taskBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            taskSelectedIndex = taskBox.SelectedIndex;

            if (taskSelectedIndex >= 0)
            {
                cmdViewTaskDetails.Enabled = true;
                cmdDeleteTask.Enabled = true;

                Task task = tasks[taskSelectedIndex];
                if (!task.IsCompleted())
                {
                    cmdCompleteTask.Enabled = true;
                }
                else
                {
                    cmdCompleteTask.Enabled = false;
                }
            }
        }

        private void drawProgressBar()
        {
            listSelectedIndex = listBox1.SelectedIndex;
            int numberOfTasks;
            int numberOfCompletedTasks = 0;
            double percentageOfTasksCompleted = 0;
            List selectedList = ((List)(listBox1.Items[listSelectedIndex]));

            if (listSelectedIndex >= 0)
            {
                tasks = dbHelper.GetTasksForList(selectedList.ID);
                numberOfTasks = tasks.Count;

                foreach (Task t in tasks)
                {
                    if (t.IsCompleted()) 
                    { 
                        numberOfCompletedTasks++; 
                    }
                }
                
                try
                {
                    percentageOfTasksCompleted = ((float)numberOfCompletedTasks / (float)numberOfTasks) * 100.0;
                }
                catch (DivideByZeroException)
                {
                    percentageOfTasksCompleted = 100;
                }

                completionBar.BackColor = Color.Green;
                completionBar.Width = (int)(500 * (percentageOfTasksCompleted / 100));
            }
        }

        private void cmdViewTaskDetails_Click(object sender, EventArgs e)
        {
            taskSelectedIndex = taskBox.SelectedIndex;
            
            if (taskSelectedIndex >= 0)
            {
                Task task = tasks[taskSelectedIndex];

                TaskForm taskForm = new TaskForm(task);
                taskForm.StartPosition = FormStartPosition.CenterParent;
                if (taskForm.ShowDialog() == DialogResult.OK)
                {
                    GetData();
                }
            }
        }

        private void cmdDeleteTask_Click(object sender, EventArgs e)
        {
            taskSelectedIndex = taskBox.SelectedIndex;
            
            if (taskSelectedIndex >= 0)
            {
                Task task = tasks[taskSelectedIndex];
                
                if((MessageBox.Show("Are you sure you want to delete this task?", "Delete Task", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes))
                {
                    //delete the selected task here
                    dbHelper.DeleteTask(task);
                    GetData();
                }
            }
        }

        private void cmdAddTask_Click(object sender, EventArgs e)
        {
            listSelectedIndex = listBox1.SelectedIndex;

            if (listSelectedIndex >= 0)
            {
                List list = allLists[listSelectedIndex];

                TaskForm taskForm = new TaskForm(list);

                ShowTaskForm(taskForm);

                GetData();
            }
        }

        private void cmdAddListItem_Click(object sender, EventArgs e)
        {
            AddListItemForm addListItemForm = new AddListItemForm();

            ShowAddListForm(addListItemForm);

            GetData();
        }

        private void cmdCompleteTask_Click(object sender, EventArgs e)
        {
            taskSelectedIndex = taskBox.SelectedIndex;

            Task task = tasks[taskSelectedIndex];

            if (!task.IsCompleted())
            {
                task.SetCompleted(true);
                dbHelper.UpdateTask(task);
                GetData();
            }
        }

        private void newProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddListItemForm addListItemForm = new AddListItemForm();
            ShowAddListForm(addListItemForm);
            GetData();
        }

		private void cmdDeleteListItem_Click(object sender, EventArgs e)
		{
			List selectedList = ((List)(listBox1.Items[listSelectedIndex]));
			if ((MessageBox.Show("Are you sure you want to delete this list?", "Delete List", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes))
			{
				dbHelper.DeleteList(selectedList);
				GetData();
			}
		}

        private void ResetInterface()
        {
            lblProjectName.Text = "";
            taskBox.Items.Clear();
            completionBar.Width = 0;
        }

        private void ShowAddListForm(AddListItemForm addListForm)
        {
            addListForm.StartPosition = FormStartPosition.CenterParent;

            System.Windows.Forms.DialogResult resultant = addListForm.ShowDialog();
            while (resultant == System.Windows.Forms.DialogResult.Retry)
            {
                resultant = addListForm.ShowDialog();
            }
        }

        private void ShowTaskForm(TaskForm taskForm)
        {
            taskForm.StartPosition = FormStartPosition.CenterParent;
            System.Windows.Forms.DialogResult resultant = taskForm.ShowDialog();
            while (resultant == System.Windows.Forms.DialogResult.Retry)
            {
                resultant = taskForm.ShowDialog();
            }
        }
	}
}
