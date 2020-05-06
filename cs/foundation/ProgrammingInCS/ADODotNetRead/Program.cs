using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ADODotNetRead
{
    class Program
    {
        static void Main(string[] args)
        {
            // http://msdn.microsoft.com/en-us/library/system.data.sqlclient.sqlconnection.open.aspx 
            // http://msdn.microsoft.com/en-us/library/system.data.sqlclient.sqldatareader.read.aspx   
        }

        private static IEnumerable<Animal> GetAnimals(string sqlConStr)
        {
            var animals = new List<Animal>();

            SqlConnection sqlCon = new SqlConnection(sqlConStr);

            sqlCon.Open();

            using (sqlCon)
            {
                SqlCommand sqlCmd = new SqlCommand("SELECT Name, Color FROM Animals", sqlCon);

                using (SqlDataReader sqlreader = sqlCmd.ExecuteReader())
                {
                    while (sqlreader.Read())
                    {
                        var animal = new Animal();

                        animal.Name = (string)sqlreader["Name"];
                        animal.Color = (string)sqlreader["Color"];

                        animals.Add(animal);
                    }
                }
            }

            return animals;
        }
    }
}
