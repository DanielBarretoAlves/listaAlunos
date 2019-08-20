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
            //float notaTotal;
            Console.WriteLine(dataTable.Rows.Count);
            // 2
            float n1, n2;
            //foreach (DataRow row in dataTable.Rows)
            //{
            //    //Console.WriteLine(row["Nome"] + " - " + row["p1"]);
            //    var x = row["Nome"];
            //    Console.WriteLine(x);
            //    //if (x == "Daniel Barreto Alves")
            //    //{
            //    //    Console.WriteLine("Funfou");
            //    //}
                

            //}
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                // your index is in i
                var row = dataTable.Rows[i];
                Console.WriteLine(row["Nome"]);
               
            }

            //dataTable.Columns[0]() =;

            // 0 - item 0
            // 1 - item 1







            //Account account = JsonConvert.DeserializeObject<Account>(json);






            //Account account = JsonConvert.DeserializeObject<Account>(json);

            ////Console.WriteLine("Nome: " + account.Nome);
            ////Console.WriteLine("Nota1: " + account.Nota1);
            ////Console.WriteLine("Nota2: " + account.Nota2);
            ////if(account.Nota1 + account.Nota2 > 6)
            ////{
            //foreach (object o in account.A1)
            //{
            //    Console.WriteLine(o);
            //}
            //List<string> names = new List<string>();
            //}
            // james@example.com
        }
    }
}

       

