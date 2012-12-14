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
        string projectName = "";

        public AddListItemForm()
        {
            InitializeComponent();
        }

        private void AddListItemForm_Load(object sender, EventArgs e)
        {
			txtProjectName.KeyPress += new KeyPressEventHandler(txtProjectName_KeyPress);
        }

		void txtProjectName_KeyPress(object sender, KeyPressEventArgs e)
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
				else if (len > 0 && c != 32)
				{
					if ((c < 97 || c > 122) && (c < 65 || c > 90) && (c < 48 || c > 57))
					{
						e.Handled = true;
					}

				}
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
