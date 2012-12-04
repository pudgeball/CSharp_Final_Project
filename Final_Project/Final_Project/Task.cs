using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Final_Project.Model
{
	class Task
	{
		private string _name;
		private string _description;
		private DateTime _dueDate;
		private DateTime _completed;
		private int _listID;

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

		public Task(string Name, string Description, DateTime DueDate)
		{
			this.Name = Name;
			this.Description = Description;
			this.DueDate = DueDate;
		}

		public Task(string Name, string Description, DateTime DueDate, DateTime Completed)
		{
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
