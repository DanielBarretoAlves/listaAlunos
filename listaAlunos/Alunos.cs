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

    internal double mediaAluno(string turma, string materia, object v)
    {
        throw new NotImplementedException();
    }

    public double mediaAluno(string turma, string materia, string nome)
    {
        double media = 0.0;
        var json = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + turma);
        
        DataSet dataSet = JsonConvert.DeserializeObject<DataSet>(json);

        DataTable dataTable = dataSet.Tables[materia];
        for(int i = 0; i < dataTable.Rows.Count; i++)
        {
            var row = dataTable.Rows[i];
            string findStudent = (string)row["Nome"];
            if(findStudent == nome)
            {
                
                media = (getP1(turma, materia, nome) + getP2(turma, materia, nome)) / 2;

            }

        }
        return media;
    }

    public double compare(string turma, string materia, string nome)
    {
        //Compara a Diferença da Primeira Nota Com a Da Segunda
        double diference = 0.0;
        if(getP1(turma, materia, nome) > getP2(turma, materia, nome))
        {
            diference = getP1(turma, materia, nome) - getP2(turma, materia, nome);

        }
        else
        {
            diference = getP2(turma, materia, nome) - getP1(turma, materia, nome);
        }
        return diference;
    }

}



