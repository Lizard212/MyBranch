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
       
       
        public dbConnection()
        {
            Connection();

        }
        private void Connection()
        {
            try
            {
                sqlite_con = new SQLiteConnection(connection_string);
                sqlite_con.Open();
                if(sqlite_con.State == ConnectionState.Open) // If connection is open , close
                {
                    sqlite_con.Close();
                }
            }
            catch (Exception)
            {

                throw;
            }
            
        }
        /// <summary>
        /// Execute query
        /// </summary>
        /// <param name="query"></param>
        public void _ExecuteNonQuery(string query)
        {
            int result = 0;
            try
            {
                if(sqlite_con.State == ConnectionState.Closed)
                sqlite_con.Open();
                sqlite_cmd = sqlite_con.CreateCommand();
                sqlite_cmd.CommandText = query;
                result = sqlite_cmd.ExecuteNonQuery();
                

            }
            catch (SQLiteException ex)
            {
                return;
               
            }
            sqlite_con.Close();
          //  return result;
        }
        public object _ExecuteScalarQuery(string query)
        {
            object result = 0;
            try
            {
                if (sqlite_con.State == ConnectionState.Closed)
                    sqlite_con.Open();
                sqlite_cmd = sqlite_con.CreateCommand();
                sqlite_cmd.CommandText = query;
                result = sqlite_cmd.ExecuteScalar();


            }
            catch (SQLiteException ex)
            {
                return 0;

            }
            sqlite_con.Close();
            return result;
        }
        public DataTable GetData(string query)
        {
            DataTable table = new DataTable();
            SQLiteDataAdapter da = new SQLiteDataAdapter(query, sqlite_con);
    
            da.Fill(table);
            return table;

        }

        

        
 




       

       

     


    }
}
