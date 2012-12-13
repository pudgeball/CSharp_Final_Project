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
            txtProjectName.KeyDown += new KeyEventHandler(txtProjectName_KeyDown);
        }

        void txtProjectName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CreateNewList();
            }
        }

        private void cmdOK_Click(object sender, EventArgs e)
        {
            CreateNewList();
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void CreateNewList()
        {
            DatabaseHelper dbhelper = new DatabaseHelper();
            projectName = txtProjectName.Text;

            if (DataGood())
            {
                List newProject = new List(projectName);
                dbhelper.CreateList(newProject);
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Enter a List Item Name", "List Item Add Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = System.Windows.Forms.DialogResult.Retry;
            }

            this.Close();
        }

        private bool DataGood()
        {
            if (txtProjectName.Text.Length == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
