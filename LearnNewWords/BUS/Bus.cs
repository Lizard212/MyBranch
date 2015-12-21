using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using DTO;
using System.Data;
namespace BUS
{

    public class Bus
    {
        dbConnection db = new dbConnection();

        /// <summary>
        /// Get list word gourp
        /// </summary>
        /// <returns></returns>
        public List<WORD_GROUP> GetListGroup()
        {
           
            string query = "SELECT * FROM WORD_GROUP";
            DataTable dt = db.GetData(query);
            var word_group_list = new List<WORD_GROUP>(dt.Rows.Count);

            foreach (DataRow row in dt.Rows)
            {
                var values = row.ItemArray;
                var word_group = new WORD_GROUP()
                {
                    word_group_id = Convert.ToInt32(values[0]),
                    name_word_group = values[1].ToString()
                };
                word_group_list.Add(word_group);
            }
            return word_group_list;
        }




        #region WORD
        
        public List<WORD> GetListWord(int word_gourp_id)
        {

           
            string query = "SELECT *FROM WORD WHERE word_group_id = " + word_gourp_id ;
            DataTable table = db.GetData(query);

            var word_list = new List<WORD>(table.Rows.Count);

            foreach (DataRow row in table.Rows)
            {

                var values = row.ItemArray;
                var word = new WORD()
                {
                    Word_id = int.Parse(values[0].ToString()),
                    Word = values[1].ToString(),
                    Category = values[2].ToString(),
                    Phonetic = values[3].ToString(),
                    Mean = values[4].ToString(),
                    Sentence = values[5].ToString(),
                    Word_group_id = int.Parse(values[6].ToString())

                };
                word_list.Add(word);

            }
            return word_list;
        }
        // Insert , update ,delete word
        public void InsertWord(WORD word)
        {

        }
        public void UpdateWord(WORD word)
        {
            string query = "UPDATE WORD SET word =" + word.Word + "category = " + word.Category
                                            + "phonetic =" + word.Phonetic + "mean = " + word.Mean
                                            + "sentence = " + word.Sentence + "word_group_id =" + word.Word_group_id.ToString()
                                            + "WHERE word_id = " + word.Word_id.ToString();
            db._ExecuteNonQuery(query);
        }
        public void DeleteWord(WORD word)
        {
            string query = "DELETE WORD WHERE word_id = " + word.Word_id.ToString();
            db._ExecuteNonQuery(query);
        }
        public int SelectIdWordGroup(string name_word_group)
        {
            string query = "SELECT word_group_id FROM WORD_GROUP WHERE name_group = '" + name_word_group + "'";
            int temp_id = Convert.ToInt32(db._ExecuteScalarQuery(query));
            return temp_id;
        }

        // Search
        public List<WORD> SearchListWord(int word_group_id,string keywords)
        {
            List<WORD> list_word = new List<WORD>();
            string query = "SELECT *FROM WORD WHERE word_group_id = " + word_group_id.ToString() + "AND LIKE %" + keywords + "%";

            DataTable table = db.GetData(query);

            var word_list = new List<WORD>(table.Rows.Count);

            foreach (DataRow row in table.Rows)
            {

                var values = row.ItemArray;
                var word = new WORD()
                {
                    Word_id = Convert.ToInt32(values[0]),
                    Word = values[1].ToString(),
                    Category = values[2].ToString(),
                    Phonetic = values[3].ToString(),
                    Mean = values[4].ToString(),
                    Sentence = values[5].ToString(),
                    Word_group_id = Convert.ToInt32(values[6])

                };
                word_list.Add(word);

            }
            return list_word;
        }

        #endregion
        #region WORD_GROUP
        // Insert , update ,delete List word
        public void InsertWordGroup(WORD_GROUP word_group)
        {
            try
            {
                string query = "INSERT INTO WORD_GROUP(name_group) values ('" + word_group.name_word_group + "')";
                db._ExecuteNonQuery(query);
                
            }
            catch(Exception ex)
            {
                return;
            }

        }

        public void UpdateWordGroup(WORD_GROUP word_group)
        {
            string query = "UPDATE WORD_GROUP SET name_group = " + word_group.name_word_group + "WHERE word_group_id = "
                           + word_group.word_group_id.ToString();
            db._ExecuteNonQuery(query);


        }

        public void DeleteWordGroup(WORD_GROUP word_group)
        {
            string query = "DELETE WORD_GROUP WHERE word_group_id =" + word_group.word_group_id.ToString();
            db._ExecuteNonQuery(query);
        }

        // Search
        public List<WORD_GROUP> SearchListWordGroup(string keywords)
        {
            List<WORD_GROUP> list_group = new List<WORD_GROUP>();
            string query = "SELECT * FROM WORD_GROUP WHERE name_group like %"+ keywords +"%";
            DataTable dt = db.GetData(query);
            var word_group_list = new List<WORD_GROUP>(dt.Rows.Count);

            foreach (DataRow row in dt.Rows)
            {
                var values = row.ItemArray;
                var word_group = new WORD_GROUP()
                {
                    word_group_id = Convert.ToInt32(values[0]),
                    name_word_group = values[1].ToString()
                };
                word_group_list.Add(word_group);
            }
            return word_group_list;
        }

        // Check name word group exists
        public bool CheckExistsWordGroup(string name_word_group)
        {
            string query = "SELECT * FROM WORD_GROUP WHERE name_group   ='" + name_word_group +"'";

            var temp = db._ExecuteScalarQuery(query);
            if (temp == null)
            {
                return false;
            }

            return true;
                  
        }

        #endregion

    }
}

