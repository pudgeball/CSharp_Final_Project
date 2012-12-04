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

		public List(int ID, string Name)
		{
			this.ID = ID;
			this.Name = Name;
		}

		public override string ToString()
		{
			return Name;
		}

		//public float GetListCompletion()
		//{
		//    return 0.0f;
		//}
	}
}
