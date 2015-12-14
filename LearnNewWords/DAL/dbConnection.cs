using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.Data;
using DTO;

namespace DAL
{

   public class dbConnection
    {
        string connection_string = "Data source = Tword.sqlite ";
        private SQLiteConnection sqlite_con;
        private SQLiteCommand sqlite_cmd;
       
        private DataTable dt = new DataTable();
        public dbConnection()
        {
            sqlite_con = new SQLiteConnection(connection_string);
        }
        /// <summary>
        /// Execute query
        /// </summary>
        /// <param name="query"></param>
        public void ExecuteQuery(string query)
        {
            try
            {
                sqlite_con.Open();
                sqlite_cmd = sqlite_con.CreateCommand();
                sqlite_cmd.CommandText = query;
                sqlite_cmd.ExecuteNonQuery();
                

            }
            catch (SQLiteException ex)
            {
                return;
               
            }
            sqlite_con.Close();
        }

       

     


    }
}
