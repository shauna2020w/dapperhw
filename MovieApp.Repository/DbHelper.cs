using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace MovieApp.Repository
{
    class DbHelper
    {
        public const string connectionstring = @"Data Source=.;Initial Catalog=MovieShop;Integrated Security=True";

        //public int ExecuteDML(string statement, Dictionary<string, object> parameters, CommandType cmdType = CommandType.Text)
        //{
        //    SqlConnection connection = new SqlConnection(connectionstring);
        //    connection.Open();

        //    SqlCommand cmd = new SqlCommand();
        //    cmd.CommandText = statement;
        //    cmd.CommandType = cmdType;  // text/sp

        //    if (parameters != null)
        //    {
        //        foreach (var item in parameters)
        //        {
        //            cmd.Parameters.AddWithValue(item.Key, item.Value);
        //        }
        //    }

        //    cmd.Connection = connection;

        //    int result = cmd.ExecuteNonQuery();
        //    connection.Close();
        //    return result;
        //}
    }
}
