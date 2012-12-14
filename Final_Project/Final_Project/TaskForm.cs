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
            lblTaskName.Text = "Update Task";
			typeOfAction = "update"; 
			txtName.Text = task.Name;
			txtDescription.Text = task.Description;
			monthCalendar1.SelectionStart = task.DueDate;


        }

        private void TaskForm_Load(object sender, EventArgs e)
        {
			
			txtName.LostFocus += new EventHandler(txtName_LostFocus);
			txtDescription.LostFocus +=new EventHandler(txtDescription_LostFocus);
            
			txtName.KeyPress += new KeyPressEventHandler(txtName_KeyPress);
			txtDescription.KeyPress += new KeyPressEventHandler(txtDescription_KeyPress);

			this.Shown += new EventHandler(TaskForm_Shown);
			
        }

		void TaskForm_Shown(object sender, EventArgs e)
		{
			txtName.Focus();
		}

		void txtDescription_KeyPress(object sender, KeyPressEventArgs e)
		{
			int c = e.KeyChar;
			int len = ((TextBox)sender).Text.Length;
			((TextBox)sender).SelectionStart = len;
			if (c != 8)
			{
				if (len == 0 && c == 32)
				{
					e.Handled = true;
				}
				else if (len == 0 && (c > 96 && c < 123))
				{
					e.KeyChar = (char)(c - 32);
				}
				
			}
		}

	
		void txtName_KeyPress(object sender, KeyPressEventArgs e)
		{
			int c = e.KeyChar;
			int len = ((TextBox)sender).Text.Length;
			((TextBox)sender).SelectionStart = len;
			if (c != 8)
			{
				if (len == 0 && c == 32)
				{
					e.Handled = true;
				}
				else if(len == 0 && (c > 96 && c < 123))
				{
					e.KeyChar = (char)(c - 32);
				}
				else if (len > 0 && c != 32)
				{
					if ((c < 97 || c > 122) && (c < 65 || c > 90) && (c < 48 || c > 57))
					{
						e.Handled = true;
					}
					
				}
			}
		}

		void txtDescription_LostFocus(object sender, EventArgs e)
		{
			if (txtDescription.Text.Length == 0)
			{
				
				lblDescription.BackColor = Color.Red;
				
			}

		}

		void txtName_LostFocus(object sender, EventArgs e)
		{
			if (txtName.Text.Length == 0)
			{
				
				lblTask.BackColor = Color.Red;
			}
			
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
					this.DialogResult = System.Windows.Forms.DialogResult.OK;
				}
				else if (typeOfAction.Equals("update"))
				{
					//task = new Task(txtName.Text, txtDescription.Text, monthCalendar1.SelectionStart);
					task.Name = txtName.Text;
					task.Description = txtDescription.Text;
					task.DueDate = monthCalendar1.SelectionStart;
					dbHelper.UpdateTask(task);
				}

				this.Close();
			}
			else
			{
				this.DialogResult = System.Windows.Forms.DialogResult.Retry;
			}
            
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.Close();
        }

		public bool DataGood()
		{
			if (txtName.Text.Length < 1)
			{
				lblError.Text = "Enter a task name!";
				txtName.Focus();
				return false;
			}
			if (txtDescription.Text.Length < 1)
			{
				lblError.Text = "Enter a description!";
				txtDescription.Focus();
				return false;
			}
			lblError.Text = "";
			return true;
			
		}



    }
}
