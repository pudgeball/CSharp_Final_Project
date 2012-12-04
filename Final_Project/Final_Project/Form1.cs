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
		public Form1()
		{
			InitializeComponent();
		}

		private void bindingSource1_CurrentChanged(object sender, EventArgs e)
		{

		}

		private void Form1_Load(object sender, EventArgs e)
		{
			DatabaseHelper dbHelper = new DatabaseHelper();
			List<List> allLists = dbHelper.getLists();

			listBox1.DataSource = allLists;

			Task task = new Task("Do homework", "Need to finish this C#", new DateTime(2012, 5, 3));
			task.ListID = 0;
		}
	}
}
