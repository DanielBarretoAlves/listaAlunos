using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Schema;
using static System.Console;
using System.Data;

namespace listaAlunos
{
    class Program
    {
        public static void Main(string[] args)
        {
            string testezao = "listaAlunos.json";
            var json = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @testezao);
            DataSet dataSet = JsonConvert.DeserializeObject<DataSet>(json);

            DataTable dataTable = dataSet.Tables["Purtuguex"];
          
            Console.WriteLine(dataTable.Rows.Count);

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {

                var row = dataTable.Rows[i];
                Console.WriteLine(row["Nome"]);
                double x = (double)row["p1"];
                double y = (double)row["p2"];
                if((x + y) >6.0)
                {
                    Console.WriteLine("Passou");
                }
               
            }


        }
    }
}

       

