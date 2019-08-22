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
    public class Aluno
    {

        string nome, turma, materia;
        double p1, p2;
        double media;


        public Aluno()
        {
        }
        public string GetNome(string nome, string turma, string materia)
        {
            //string turmaJson = "listaAlunos.json";
            var json = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @turma);
            DataSet dataSet = JsonConvert.DeserializeObject<DataSet>(json);
            DataTable materiaTable = dataSet.Tables[materia];


            //DataTable dataTable = dataSet.Tables[nome];
            for (int i = 0; i < materiaTable.Rows.Count; i++)
            {

                var findMateria = materiaTable.Rows[i];
                //string getMateria = ()
                //se der errado eu crio o find materia
                if((string)findMateria["Nome"] == nome)
                {
                    nome = (string)findMateria["Nome"];

                }
                else
                {
                    Console.WriteLine("Nome invalido");
                    nome = null;
                }


            }
            return nome;
        }

        


    }
}
