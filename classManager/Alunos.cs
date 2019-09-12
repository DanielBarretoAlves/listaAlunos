using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Schema;
using System.Data;
namespace classManager
{
    public class Alunos
    {


        public double getP1(string turma, int materia, string nome)
        {
            double p1 = double.MinValue;

            var json = File.ReadAllText(path: AppDomain.CurrentDomain.BaseDirectory + @turma);
            DataSet dataset = JsonConvert.DeserializeObject<DataSet>(json);
            DataTable table = dataset.Tables[materia];
            for (int i = 0; i < table.Rows.Count; i++)
            {
                var info = table.Rows[i];
                if (nome == (string)info["Nome"])
                {
                    p1 = (double)info["p1"];
                }
            }


            return p1;
        }

        public double getP2(string turma, int materia, string nome)
        {
            double p2 = double.MinValue;

            var json = File.ReadAllText(path: AppDomain.CurrentDomain.BaseDirectory + @turma);
            DataSet dataset = JsonConvert.DeserializeObject<DataSet>(json);
            DataTable table = dataset.Tables[materia];
            for (int i = 0; i < table.Rows.Count; i++)
            {
                var info = table.Rows[i];
                if (nome == (string)info["Nome"])
                {
                    p2 = (double)info["p2"];
                }
            }


            return p2;
        }

        public bool melhorouNota(string turma, int materia, string nome)
        {
            bool melhorou = false;


            double n1 = getP1(turma, materia, nome);
            double n2 = getP2(turma, materia, nome);
            if (n1 < n2)
            {
                melhorou = true;

            }
            

            return melhorou;

        }

        public double getMedia(string turma, int materia, string nome)
        {
            double media = (getP1(turma, materia, nome) + getP2(turma, materia, nome))/ 2 ;

            return media;

        }

        public double getRendimento(string turma, int materia,string nome)
        {
            double rendimento = double.MinValue;
            rendimento = ((getMedia(turma,materia, nome) / 10) *100);
            return rendimento;
        }
        public string controller()
        {
            (new string[3])[0] = "prova1";
            (new string[3])[1] = "prova2";
            (new string[3])[2] = "rendimento";
            for (int i = 0; i < (new string[3]).Length; i++)
            {
                Console.WriteLine(i + " - " + (new string[3])[i]);
            }
            int escolha = int.Parse(Console.ReadLine());
            return (new string[3])[escolha];
        }


    }
}
