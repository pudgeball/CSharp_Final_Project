using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Final_Project.Utilities;
using Final_Project.Model;

namespace Final_Project
{
    public partial class AddListItemForm : Form
    {
        string projectName = "temp";

        public AddListItemForm()
        {
            InitializeComponent();
        }

        private void AddListItemForm_Load(object sender, EventArgs e)
        {
            
        }

        private void cmdOK_Click(object sender, EventArgs e)
        {
            DatabaseHelper dbhelper = new DatabaseHelper();
            projectName = txtProjectName.Text;

            //validate here?

            List newProject = new List(projectName);
            dbhelper.CreateList(newProject);
            this.Close();
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
