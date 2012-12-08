using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Final_Project.Model;

namespace Final_Project
{
    public partial class TaskForm : Form
    {
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
        }

        private void TaskForm_Load(object sender, EventArgs e)
        {

        }

        private void cmdUpdate_Click(object sender, EventArgs e)
        {
            if(typeOfAction.Equals("create"))
            {
                //insert into the database here
            }
            else if(typeOfAction.Equals("update"))
            {
                //update the database here
            }
            
            this.Close();
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
