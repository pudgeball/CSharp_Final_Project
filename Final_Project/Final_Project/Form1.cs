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

		private void Form1_Load(object sender, EventArgs e)
		{
			DatabaseHelper dbHelper = new DatabaseHelper();
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

			List<Task> tasks = dbHelper.GetTasksForList(0);
			foreach (Task t in tasks)
			{
				Console.WriteLine(t.Name);
			}
		}
	}
}
