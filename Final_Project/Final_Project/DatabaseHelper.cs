using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Final_Project.Model;

namespace Final_Project.Utilities
{
	class DatabaseHelper
	{
		private static readonly string _path = Application.StartupPath;
		private static readonly string _connStr = "Data Source=.\\SQLEXPRESS;AttachDbFilename='" + _path + "\\Database.mdf';Integrated Security=True;User Instance=True";
		private SqlConnection _conn;
		private SqlCommand _cmd;

		public DatabaseHelper()
		{
			_conn = new SqlConnection(_connStr);
		}

		private void createCommand()
		{
			_cmd = new SqlCommand();
			_cmd.Connection = _conn;
		}

		public int GetListCount()
		{
			int listCount = -1;

			string listSQL = "SELECT COUNT(*) as ListCount FROM [List]";
			_cmd.CommandText = listSQL;
			_conn.Open();
			SqlDataReader dr = _cmd.ExecuteReader();
			if (dr.HasRows)
			{
				dr.Read();
				listCount = Convert.ToInt32(dr["ListCount"]);
			}
			dr.Close();
			_conn.Close();

			return listCount;
		}

		public int GetTaskCount()
		{
			int taskCount = -1;
			string sql = "SELECT COUNT(*) as TaskCount FROM [Task]";
			_cmd.CommandText = sql;
			_conn.Open();
			SqlDataReader dr = _cmd.ExecuteReader();

			if (dr.HasRows)
			{
				dr.Read();
				taskCount = Convert.ToInt32(dr["TaskCount"]);
			}
			dr.Close();
			_conn.Close();

			return taskCount;
		}

		public List GetList(int ListID)
		{
			createCommand();
			List list = new List();

			string sql = "SELECT * FROM [List] WHERE [List].[id] = @listID";
			_cmd.CommandText = sql;
			_cmd.Parameters.Add("@listID", System.Data.SqlDbType.Int).Value = ListID;

			_conn.Open();
			SqlDataReader dr = _cmd.ExecuteReader();
			if (dr.HasRows)
			{
				dr.Read();
				int id = Convert.ToInt32(dr["id"]);
				string name = dr["name"].ToString();
				list = new List(id, name);
			}
			dr.Close();
			_conn.Close();

			return list;
		}

		public List<Task> GetTasksForList(int ListID)
		{
			createCommand();

			List<Task> tasks = new List<Task>();
			string sql = "SELECT * FROM [Task] INNER JOIN [List] ON [Task].[listID] = [List].[id] WHERE [List].[id] = @listID";
			_cmd.CommandText = sql;
			_cmd.Parameters.Add("@listID", System.Data.SqlDbType.Int).Value = ListID;

			_conn.Open();
			SqlDataReader dr = _cmd.ExecuteReader();
			if (dr.HasRows)
			{
				while(dr.Read())
				{
					int ID = Convert.ToInt32(dr["id"]);
					int listID = Convert.ToInt32(dr["listID"]);
					string name = dr["name"].ToString();
					string description = dr["description"].ToString();
					DateTime due = Convert.ToDateTime(dr["due"]);
					DateTime completed = DateTime.MinValue;
					//Yes this sucks, but it wants an ordinal :(
					if (!dr.IsDBNull(5))
					{
						 completed = Convert.ToDateTime(dr["completed"]);
					}
					
					Task task = new Task(listID, name, description, due, completed);
					task.ID = ID;
					tasks.Add(task);
				}
			}
			dr.Close();
			_conn.Close();

			return tasks;
		}

		//INCEPTION FUN!
		public List<List> GetLists()
		{
			createCommand();

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
			createCommand();

			if (task.ID == -1)
			{
				task.ID = GetTaskCount();
			}

			try
			{
				string sql = "INSERT INTO [Task] ([id], [listID], [name], [description], [due], [completed]) VALUES(@id, @listID, @name, @description, @due, @completed)";
				_cmd.CommandText = sql;
				_cmd.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = task.ID;
				_cmd.Parameters.Add("@listID", System.Data.SqlDbType.Int).Value = task.ListID;
				_cmd.Parameters.Add("@name", System.Data.SqlDbType.VarChar).Value = task.Name;
				_cmd.Parameters.Add("@description", System.Data.SqlDbType.VarChar).Value = task.Description;
				_cmd.Parameters.Add("@due", System.Data.SqlDbType.DateTime).Value = task.DueDate;
				_cmd.Parameters.Add("@completed", System.Data.SqlDbType.DateTime);

				if (task.IsCompleted())
				{
					_cmd.Parameters["@completed"].Value = task.Completed;
				}
				else
				{
					_cmd.Parameters["@completed"].Value = DBNull.Value;
				}

				_conn.Open();
				_cmd.ExecuteNonQuery();
				_conn.Close();
			}
			catch (SqlException ex)
			{
				Console.WriteLine(ex.Message);
			}
		}

		public void UpdateTask(Task task)
		{
			createCommand();

			string sql = "UPDATE Task SET [name] = @name, [description] = @description, [due] = @due, [completed] = @completed, [listID] = @listID WHERE [id] = @id";

			_cmd.CommandText = sql;
			_cmd.Parameters.Add("@name", System.Data.SqlDbType.Int).Value = task.ID;
			_cmd.Parameters.Add("@description", System.Data.SqlDbType.VarChar).Value = task.Description;
			_cmd.Parameters.Add("@due", System.Data.SqlDbType.DateTime).Value = task.DueDate;
			_cmd.Parameters.Add("@completed", System.Data.SqlDbType.DateTime);
			_cmd.Parameters.Add("@listID", System.Data.SqlDbType.Int).Value = task.ListID;
			_cmd.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = task.ID;

			_conn.Open();
			_cmd.ExecuteNonQuery();
			_conn.Close();
		}

		public void DeleteTask(Task task)
		{
			createCommand();

			string sql = "DELETE FROM [Task] WHERE [id] = @id";
			_cmd.CommandText = sql;
			_cmd.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = task.ID;

			_conn.Open();
			_cmd.ExecuteNonQuery();
			_conn.Close();

		}

		public void CreateList(List list)
		{
			createCommand();

			string sql = "INSERT INTO [List] ([id], [name]) VALUES(@listID, @listName)";

			if (list.ID == -1)
			{
				list.ID = GetListCount();
			}

			_cmd.CommandText = sql;
			_cmd.Parameters.Add("@listID", System.Data.SqlDbType.Int).Value = list.ID;
			_cmd.Parameters.Add("@listName", System.Data.SqlDbType.VarChar).Value = list.Name;

			_conn.Open();
			_cmd.ExecuteNonQuery();
			_conn.Close();
		}
	}
}
