using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using Mono.Data.Sqlite;
using System.Data;

namespace Assets.Scripts
{
    class DBEditor: MonoBehaviour
    {
        public List<string> dataFromDB = new List<string>();
        void Start()
        {
            //Filler();
            dataFromDB = Getter();
        }

        void Update()
        {
            if(dataFromDB.Count == 0)
            {
                dataFromDB = Getter();
            } 
        }
        public void Filler()
        {
            string conn = "URI=file:" + Application.dataPath + "/dblevels.db"; //Path to database
            IDbConnection dbconn;
            List<string> str = new List<string>();
            dbconn = (IDbConnection)new SqliteConnection(conn);
            dbconn.Open(); //Open connection to the database
            Debug.Log("I TRY I TRY");
            int n = 3;

            for (int i = 1; i < 8; i++)
            {
                IDbCommand dbcmd = dbconn.CreateCommand();
                string sqlQuery2 = "INSERT INTO Levels(Id, Matrix) " + "VALUES(" + i + ", '" + New_Generator.StringMatrixGenerator(n) + "')";
                dbcmd.CommandText = sqlQuery2;
                dbcmd.ExecuteReader();
                n++;
                dbcmd.Dispose();
                dbcmd = null;
            }


            dbconn.Close();
            dbconn = null;
        }

        public List<string> Getter()
        {
            string conn = "URI=file:" + Application.dataPath + "/dblevels.db";
            IDbConnection dbconn;
            List<string> str = new List<string>();
            dbconn = (IDbConnection)new SqliteConnection(conn);
            dbconn.Open();
            IDbCommand dbcmd = dbconn.CreateCommand();
            string sqlQuery1 = "SELECT Matrix " + "FROM Levels";

            dbcmd.CommandText = sqlQuery1;
            IDataReader reader = dbcmd.ExecuteReader();
            while (reader.Read())
            {
                string Matrix = reader.GetString(0);

                str.Add(Matrix);
            }
            reader.Close();
            reader = null;
            dbcmd.Dispose();
            dbcmd = null;
            dbconn.Close();
            dbconn = null;
            return str;
        }
    }
}
