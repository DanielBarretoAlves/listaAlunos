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




   

    public double getP1(string turma, string materia, string nome)
    {
        var json = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + turma);
        double p1 = 0.0;
        DataSet dataSet = JsonConvert.DeserializeObject<DataSet>(json);

        DataTable dataTable = dataSet.Tables[materia];
        for (int i = 0; i < dataTable.Rows.Count; i++)
        {
            var row = dataTable.Rows[i];
            string checkName = (string)row["Nome"];
            if (checkName == nome)
            {




                p1 = (double)row["p1"];

            }
        }
        return p1;
    }

    public double getP2(string turma, string materia, string nome)
    {
        var json = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + turma);
        double p2 = 0.0;
        DataSet dataSet = JsonConvert.DeserializeObject<DataSet>(json);

        DataTable dataTable = dataSet.Tables[materia];
        for (int i = 0; i < dataTable.Rows.Count; i++)
        {
            var row = dataTable.Rows[i];
            string checkName = (string)row["Nome"];
            if (checkName == nome)
            {




                p2 = (double)row["p2"];

            }
        }
        return p2;
    }

    public bool validadeteName(string turma, string materia, string nome)
    {
        bool isVallid = false;

        
        var json = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + turma);
        DataSet dataSet = JsonConvert.DeserializeObject<DataSet>(json);

        DataTable dataTable = dataSet.Tables[materia];

        

        for (int i = 0; i < dataTable.Rows.Count; i++)
        {
            var row = dataTable.Rows[i];
            string checkName = (string)row["Nome"];
            if (checkName == nome)
            {
                isVallid = true;

            }
            
         


        }



        //----------------------------------------

        return isVallid;
    }

}



