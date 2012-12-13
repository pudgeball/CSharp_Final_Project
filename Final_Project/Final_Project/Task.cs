using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Final_Project.Model
{
	public class Task
	{
		private int _id;
		private int _listID;
		private string _name;
		private string _description;
		private DateTime _dueDate;
		private DateTime _completed;

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

		public int ListID
		{
			get
			{
				return _listID;
			}

			set
			{
				_listID = value;
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

		public string Description
		{
			get
			{
				return _description;
			}
			set
			{
				_description = value;
			}
		}

		public DateTime DueDate
		{
			get
			{
				return _dueDate;
			}
			set
			{
				_dueDate = value;
			}
		}

		public DateTime Completed
		{
			get
			{
				return _completed;
			}

			private set { }
		}

		public Task(string Name, string Description, DateTime DueDate)
		{
			this.ID = -1;
			this.Name = Name;
			this.Description = Description;
			this.DueDate = DueDate;
		}

		public Task(int ListID, string Name, string Description, DateTime DueDate, DateTime Completed)
		{
			this.ID = -1;
			this.ListID = ListID;
			this.Name = Name;
			this.Description = Description;
			this.DueDate = DueDate;
			this._completed = Completed;
		}

        public bool IsCompleted()
        {
            if (_completed != null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
		
		public void SetCompleted(bool isComplete)
		{
			if (isComplete)
			{
				_completed = DateTime.Now;
			}
			else
			{
				_completed = DateTime.MinValue;
			}
		}
	}
}
