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


    }
}
