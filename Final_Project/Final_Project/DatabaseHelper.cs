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
		private readonly string _connStr = "Data Source=.\\SQLEXPRESS;AttachDbFilename='C:\\Users\\Nick McGuire\\Documents\\GitHub\\CSharp_Final_Project\\Final_Project\\Final_Project\\Database.mdf';Integrated Security=True;User Instance=True";
		private SqlConnection _conn;
		private SqlCommand _cmd;

		public DatabaseHelper()
		{
			_conn = new SqlConnection(_connStr);
			_cmd = new SqlCommand();
			_cmd.Connection = _conn;
		}

		public List<Task> getTasksForList(int ListID)
		{
			List<Task> tasks = new List<Task>();
			string sql = "SELECT * FROM [Task] INNER JOIN [List] ON [Task].[listID] = [List].[id] WHERE [List].[id] = @listID";
			_cmd.CommandText = sql;
			_cmd.Parameters.Add("@listID", System.Data.SqlDbType.Int).Value = ListID;

			SqlDataReader dr = _cmd.ExecuteReader();

			if (dr.HasRows)
			{
				while(dr.Read())
				{
					string name = dr["name"].ToString();
					string description = dr["description"].ToString();
					DateTime due = Convert.ToDateTime(dr["due"]);
					DateTime completed = Convert.ToDateTime(dr["completed"]);
					int listID = Convert.ToInt32(dr["listID"]);
					Task task = new Task(name, description, due, completed);
					task.ListID = listID;
					tasks.Add(task);
				}
			}


			return tasks;
		}

		//INCEPTION FUN!
		public List<List> getLists()
		{
			List<List> lists = new List<List>();

			string sql = "SELECT * FROM [List]";
			_cmd.CommandText = sql;

			_conn.Open();
			SqlDataReader dr = _cmd.ExecuteReader();

			if (dr.HasRows)
			{
				while (dr.Read())
				{
					int id = Convert.ToInt32(dr["id"]);
					string name = dr["name"].ToString();
					lists.Add(new List(id, name));
				}
			}
			dr.Close();
			_conn.Close();

			return lists;
		}

		public void CreateTask(Task task)
		{
			string sql = "INSERT INTO [Task] ([name], [description], [due], [completed], [listID]) VALUES(@name, @description, @due, @completed, @listID)";
			_cmd.CommandText = sql;
			_cmd.Parameters.Add("@name", System.Data.SqlDbType.VarChar).Value = task.Name;
			_cmd.Parameters.Add("@description", System.Data.SqlDbType.VarChar).Value = task.Description;
			_cmd.Parameters.Add("@due", System.Data.SqlDbType.DateTime).Value = task.DueDate;
			_cmd.Parameters.Add("@completed", System.Data.SqlDbType.DateTime);
			_cmd.Parameters.Add("@listID", System.Data.SqlDbType.Int).Value = task.ListID;
			if (task.Completed)
			{
				_cmd.Parameters["@completed"].Value = task.Completed;
			}
		}
	}
}
