using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Schema;
using static System.Console;
using System.Data;

public class Turmas
{

    string nomeAluno;
    string nomeMateria;
    double n1;
    double n2;


    public void metodo(string materia)
    {
        string arquivo = "listaAlunos.json";
        var json = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @arquivo);
        DataSet dataSet = JsonConvert.DeserializeObject<DataSet>(json);


        DataTable dataTable = dataSet.Tables[materia];

        Console.WriteLine(dataTable.Rows.Count);

        for (int i = 0; i < dataTable.Rows.Count; i++)
        {

            var row = dataTable.Rows[i];
            Console.WriteLine(row["Nome"]);
            double x = (double)row["p1"];
            double y = (double)row["p2"];
            if ((x + y) / 2 > 6.0)
            {
                Console.WriteLine("Passou");
            }

        }

    }

    public void fakeMain(string materia, string nome)
    {
        string testezao = "listaAlunos.json";
        var json = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @testezao);
        DataSet dataSet = JsonConvert.DeserializeObject<DataSet>(json);

        DataTable dataTable = dataSet.Tables[materia];

        //Console.WriteLine(dataTable.Rows.Count);
        
        for (int i = 0; i < dataTable.Rows.Count; i++)
        {
            var row = dataTable.Rows[i];
            string checkName = (string)row["Nome"];
            if(checkName == nome)
            {

                
                Console.WriteLine(row["Nome"]);
                double p1 = (double)row["p1"];
                double p2 = (double)row["p2"];
                double media = (p1 + p2)/ 2;
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



