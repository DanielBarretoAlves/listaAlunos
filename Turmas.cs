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

    public void rendimento(string nome, string materia)
    {
        string arquivo = "listaAlunos.json";
        var json = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @arquivo);
        DataSet dataSet = JsonConvert.DeserializeObject<DataSet>(json);


        DataTable dataTable = dataSet.Tables[nome];

        Console.WriteLine(dataTable.Rows.Count);

        for (int i = 0; i < dataTable.Rows.Count; i++)
        {

            var row = dataTable.Rows[i];
            Console.WriteLine(row["Nome"]);
            double x = (double)row["p1"];
            double y = (double)row["p2"];
            double media = (x + y) / 2;
            double percentual = (media*100)/10;
            if ((x + y) / 2 > 60)
            {
                Console.WriteLine(percentual+"%");
            }

        }

    }

}



