using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using Final_Project.Model;

namespace Final_Project.Utilities
{
	class DatabaseHelper
	{
		private SqlConnection _conn;
		private SqlCommand _cmd;

		public DatabaseHelper()
		{
			string connStr = "";
			_conn = new SqlConnection(connStr);
			_cmd = new SqlCommand();
			_cmd.Connection = _conn;
		}

		public List<Task> getTasksForList(int ListID)
		{
			List<Task> tasks = new List<Task>();



			return tasks;
		}

		//INCEPTION FUN!
		public List<List> getLists()
		{
			List<List> lists = new List<List>();

			return lists;
		}
	}
}
