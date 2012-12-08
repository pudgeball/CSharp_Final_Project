using System;
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

			/*Task task = new Task("Do homework", "Need to finish this C#", new DateTime(2012, 5, 3));
			task.ListID = 0;

			Console.WriteLine(task.IsCompleted());
			Console.WriteLine(task.Name);
			Console.WriteLine(task.Description);
			Console.WriteLine(task.DueDate);
			Console.WriteLine(task.Completed);
			Console.WriteLine(task.ListID);

			dbHelper.CreateTask(task);*/
		}

        private void GetData()
        {
            dbHelper = new DatabaseHelper();
            allLists = dbHelper.GetLists();

            int previousIndex = listSelectedIndex;
            listBox1.DataSource = allLists;
            listBox1.SelectedIndex = previousIndex;
        }

        void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listSelectedIndex = listBox1.SelectedIndex;
            int numberOfTasks;
            int numberOfCompletedTasks = 0;
            double percentageOfTasksCompleted = 0;
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
                    numberOfCompletedTasks++;
                }
                else
                {
                    taskBox.Items.Add("[INCOMPLETE] " + t.Name);
                }
                
                //Console.WriteLine(t.Name);
            }

            //calculate percentage of tasks completed
            numberOfTasks = taskBox.Items.Count;
            try
            {
                percentageOfTasksCompleted = (numberOfCompletedTasks / numberOfTasks) * 100.0;
            }
            catch (DivideByZeroException)
            {
                percentageOfTasksCompleted = 100;
            }

            //set completion bar width
            completionBar.BackColor = Color.Green;
            completionBar.Width = (int)(500 * (percentageOfTasksCompleted / 100));
        }

        private void cmdViewTaskDetails_Click(object sender, EventArgs e)
        {
            taskSelectedIndex = taskBox.SelectedIndex;
            
            if (taskSelectedIndex >= 0)
            {
                Task task = tasks[taskSelectedIndex];

                TaskForm taskForm = new TaskForm(task);
                if (taskForm.ShowDialog() == DialogResult.OK)
                {
                    GetData();
                    MessageBox.Show("updated");
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
                if (taskForm.ShowDialog() == DialogResult.OK)
                {
                    GetData();
                    MessageBox.Show("created");
                }
            }
        }

        private void cmdAddListItem_Click(object sender, EventArgs e)
        {
            AddListItemForm addListItemForm = new AddListItemForm();
            addListItemForm.ShowDialog();
            GetData();
        }
	}
}
