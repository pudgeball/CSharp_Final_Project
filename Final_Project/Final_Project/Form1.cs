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
	public partial class Form1 : Form
	{
        DatabaseHelper dbHelper;

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
            //set up event handlers
            listBox1.SelectedIndexChanged += new EventHandler(listBox1_SelectedIndexChanged);
            
			dbHelper = new DatabaseHelper();
			List<List> allLists = dbHelper.GetLists();

			listBox1.DataSource = allLists;

			Task task = new Task("Do homework", "Need to finish this C#", new DateTime(2012, 5, 3));
			task.ListID = 0;

			Console.WriteLine(task.IsCompleted());
			Console.WriteLine(task.Name);
			Console.WriteLine(task.Description);
			Console.WriteLine(task.DueDate);
			Console.WriteLine(task.Completed);
			Console.WriteLine(task.ListID);

			dbHelper.CreateTask(task);
		}

        void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = listBox1.SelectedIndex;
            int numberOfTasks;
            int numberOfCompletedTasks = 0;
            double percentageOfTasksCompleted = 0;
            List selectedList = ((List)(listBox1.Items[selectedIndex]));

            //clear taskBox
            taskBox.Items.Clear();

            //set label
            lblProjectName.Text = selectedList.Name;

            //populate taskBox
            List<Task> tasks = dbHelper.GetTasksForList(selectedList.ID);
            foreach (Task t in tasks)
            {
                if (t.IsCompleted())
                {
                    numberOfCompletedTasks++;
                }

                taskBox.Items.Add(t.Name);
                Console.WriteLine(t.Name);
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
	}
}
