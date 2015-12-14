using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using System.Data;
namespace BUS
{

    public class Bus
    {
        dbConnection db = new dbConnection();

        public void TestConnection()
        {
            string query = "INSERT INTO WORD_GROUP values(1,'animal')";
            db.ExecuteQuery(query);
        }
    }
}
