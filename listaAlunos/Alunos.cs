using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Schema;
using static System.Console;
using System.Data;

public class Alunos

{
    public void fakeMain(string materia, string nome)
    {
        string testezao = "@9BM.json";
        var json = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + testezao);
        DataSet dataSet = JsonConvert.DeserializeObject<DataSet>(json);

        DataTable dataTable = dataSet.Tables[materia];

        //Console.WriteLine(dataTable.Rows.Count);

        for (int i = 0; i < dataTable.Rows.Count; i++)
        {
            var row = dataTable.Rows[i];
            string checkName = (string)row["Nome"];
            if (checkName == nome)
            {


                Console.WriteLine(row["Nome"]);
                double p1 = (double)row["p1"];
                double p2 = (double)row["p2"];
                double media = (p1 + p2) / 2;
                Console.WriteLine("A media do(a) aluno(a) " + row["Nome"] + ": " + media);
                if (media >= 6.0)
                {
                    Console.WriteLine("Aprovado(a)");
                }
                else
                {
                    Console.WriteLine("Reprovou");
                }

            }

        }
    }
        }



