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
            DataTable table = dataset.Tables[0];
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
    }
}
