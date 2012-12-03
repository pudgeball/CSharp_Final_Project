using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
			private set { }
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
		}

		public List(string Name)
		{
			this.Name = Name;
		}

		public double GetListCompletion()
		{

		}
	}
}
