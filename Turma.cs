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
    public class Turma
    {
        public Turma()
        {
        }
        public string GetAluno(string turma, string materia)
        {
            string aluno = string.Empty;
            int escolha = int.MinValue;
            var json = File.ReadAllText(path: AppDomain.CurrentDomain.BaseDirectory + @turma);
            DataSet dataset = JsonConvert.DeserializeObject<DataSet>(json);
            DataTable table = dataset.Tables[materia];
            for (int i = 0; i < table.Rows.Count; i++)
            {
                var row = table.Rows[i];
                Console.WriteLine(i + 1 + " - " + row["Nome"]);
            }
            escolha = int.Parse(Console.ReadLine());
            var findName = table.Rows[escolha - 1];
            aluno = (string)findName["Nome"];
            return aluno;
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
