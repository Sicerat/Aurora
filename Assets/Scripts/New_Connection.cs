using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts
{
    class New_Connection
    {
        //static private MySqlConnection connection = new MySqlConnection("SERVER = db4free.net; PORT = 3306; DATABASE = dbmatrix; UID = alex97; PWD = 111;");

        static public void InsertLevel(int number, string matrix)
        {
            try
            {
                //if (connection.State == ConnectionState.Closed)
                    //connection.Open();

                //MySqlCommand cInsert = new MySqlCommand("INSERT INTO levels(number, matrix) VALUES(@number, @matrix)", connection);
                //cInsert.Parameters.AddWithValue("@level", number);
                //cInsert.Parameters.AddWithValue("@matrix", matrix);
                //cInsert.ExecuteNonQuery();
                //cInsert.Parameters.Clear();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                //connection.Close();
            }
        }

        static public void GetLevel()
        {
            try
            {
                //if (connection.State == ConnectionState.Closed)
                //    connection.Open();

                //DataSet ds = new DataSet();

                //MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM levels", connection);
                //da.Fill(ds);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
