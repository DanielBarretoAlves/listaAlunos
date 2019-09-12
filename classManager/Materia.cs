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
    public class Materia
    {
        public Materia()
        {
        }
        public string GetAluno(string turma, int materia)
        {
            string aluno = string.Empty;
            int escolha = int.MinValue;
            var json = File.ReadAllText(path: AppDomain.CurrentDomain.BaseDirectory + @turma);
            DataSet dataset = JsonConvert.DeserializeObject<DataSet>(json);
            DataTable table = dataset.Tables[materia];
            for (int i = 0; i < table.Rows.Count; i++)
            {
                var row = table.Rows[i];
                Console.WriteLine(i+1 + " - " + row["Nome"]);
            }
            escolha = int.Parse(Console.ReadLine());
            Console.WriteLine("Escolha um Aluno Pelo Numero");
            var findName = table.Rows[escolha -1];
            aluno = (string)findName["Nome"];
            return aluno;
        }

        public void showNotaVermelha(string turma, int materia)
        {
            var json = File.ReadAllText(path: AppDomain.CurrentDomain.BaseDirectory + @turma);
            DataSet data = JsonConvert.DeserializeObject<DataSet>(json);
            DataTable table = data.Tables[materia];
            for (int i = 0; i < table.Rows.Count; i++)
            {
                var info = table.Rows[i];
                Alunos all = new Alunos();
                double alunoM = all.getMedia(turma, materia, (string)info["Nome"]);
                if (alunoM < 6.0)
                {
                    Console.WriteLine("Nome: " + (string)info["Nome"]);
                }

            }
        }

        public double getMediaSala(string turma, int materia)
        {
            double media = 0;
            var json = File.ReadAllText(path: AppDomain.CurrentDomain.BaseDirectory + @turma);
            DataSet dataSet = JsonConvert.DeserializeObject<DataSet>(json);
            DataTable table = dataSet.Tables[materia];
            for (int i = 0; i < table.Rows.Count; i++)
            {
                var info = table.Rows[i];
                string nome = (string)info["Nome"];
                Alunos all = new Alunos();
                media = media + all.getMedia(turma, materia, nome);
            }
            media = media / table.Rows.Count;
            return media;
        }

        public int selectMateria(string turma)
        {
            int materia = int.MinValue;
            var json = File.ReadAllText(path: AppDomain.CurrentDomain.BaseDirectory + @turma);
            DataSet dataset = JsonConvert.DeserializeObject<DataSet>(json);

            for (int i = 0; i < dataset.Tables.Count; i++)
            {
                Console.WriteLine(i + " - " + dataset.Tables[i]);

            }
            Console.WriteLine("Escolha Uma Materia Pelo Numero Da Materia");
            materia = int.Parse(Console.ReadLine());
            return materia;
        }

    }

}
