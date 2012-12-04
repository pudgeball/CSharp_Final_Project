using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Final_Project.Utilities;

namespace Final_Project.Model
{
	class List
	{
		private int _id;
		private string _name;
		private List<Task> _tasks;

		public int ID
		{
			get
			{
				return _id;
			}
			set
			{
				_id = value;
			}
		}

		public string Name
		{
			get
			{
				return _name;
			}
			set
			{
				_name = value;
			}
		}

		public List<Task> Tasks
		{
			get
			{
				return _tasks;
			}

			set
			{
				_tasks = value;
			}
		}

		public List()
		{
			this.ID = -1;
			this.Name = "Error";
		}

		public List(string Name)
		{
			this.ID = -1;
			this.Name = Name;
		}

		public List(int ID, string Name)
		{
			this.ID = ID;
			this.Name = Name;
		}

		public override string ToString()
		{
			return Name;
		}

		public double GetListCompletion()
		{
			double completedTasks = 0D;
			double incompleteTasks = 0D;

			foreach (Task task in Tasks)
			{
				if (task.IsCompleted())
				{
					completedTasks++;
				}
				else
				{
					incompleteTasks++;
				}
			}

			return (completedTasks / incompleteTasks);
		}
	}
}
