using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Schema;
using static System.Console;
using System.Data;

namespace listaAlunos
{
    public class Materia
    {



     

//--------------------------------------------------------------------------------


        public string getNomeAluno(string turma, string materia)
        {
            string selectedAluno = "";
            int escolha;
            var json = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + turma);
            DataSet dataSet = JsonConvert.DeserializeObject<DataSet>(json);

            DataTable dataTable = dataSet.Tables[materia];

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                var row = dataTable.Rows[i];
                Console.WriteLine(i + ": " + row["Nome"]);
            }
            Console.WriteLine("Selecione um Aluno");
            escolha = int.Parse(Console.ReadLine());
            var findName = dataTable.Rows[escolha];
            selectedAluno = (string)findName["Nome"];
            
            return selectedAluno;
        }
    }
}
