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
    public partial class TaskForm : Form
    {
		DatabaseHelper dbHelper;
        Task task;
        List list;
        string typeOfAction;

        //constructor called when creating new task
        public TaskForm(List list)
        {
            InitializeComponent();
            this.list = list;
            lblTaskName.Text = "Create new Task for Project " + list.Name;
            cmdUpdate.Text = "Create";
			
            typeOfAction = "create";
			
        }

        //constructor called when modifying task coming in
        public TaskForm(Task task)
        {
            InitializeComponent();
            this.task = task;
            lblTaskName.Text += task.Name;

			typeOfAction = "update"; 
			txtName.Text = task.Name;
			txtDescription.Text = task.Description;
			monthCalendar1.SelectionStart = task.DueDate;

        }

        private void TaskForm_Load(object sender, EventArgs e)
        {

        }

        private void cmdUpdate_Click(object sender, EventArgs e)
        {
			dbHelper = new DatabaseHelper();
			if (DataGood())
			{
				if (typeOfAction.Equals("create"))
				{
					Task t = new Task(list.ID, txtName.Text, txtDescription.Text, monthCalendar1.SelectionStart, DateTime.MinValue);
					dbHelper.CreateTask(t);
				}
				else if (typeOfAction.Equals("update"))
				{
					//task = new Task(txtName.Text, txtDescription.Text, monthCalendar1.SelectionStart);
					task.Name = txtName.Text;
					task.Description = txtDescription.Text;
					task.DueDate = monthCalendar1.SelectionStart;
					dbHelper.UpdateTask(task);
				}
			}
            
            this.Close();
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

		public bool DataGood()
		{
			if (txtName.Text.Length < 1)
			{
				MessageBox.Show("Enter a task name.", "Task name error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				txtName.Focus();
				return false;
			}
			return true;
		}



    }
}
