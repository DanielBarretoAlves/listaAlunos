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

        public string getNomeAluno(string turma, string materia)
        {
            string selectedAluno = "";
            int escolha;
            var json = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @turma);
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

        public double getMediaMateria(string turma, string materia)
        {
            double mediaM = 0.0;
            double soma = 0.0;
            Alunos all = new Alunos();
            var json = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @turma);
            DataSet dataSet = JsonConvert.DeserializeObject<DataSet>(json);

            DataTable dataTable = dataSet.Tables[materia];
            for(int i =0; i < dataTable.Rows.Count; i++)
            {
                var row = dataTable.Rows[i];
                soma = soma + all.mediaAluno(turma, materia, (string)row["Nome"]);
                

            }
            mediaM = soma / dataTable.Rows.Count;

            return mediaM;

        }

        public string getMateria()
        {
            string materia = "";
            int escolha;
            Console.WriteLine("1 - ARTES");
            Console.WriteLine("2 - CIENCIAS");
            Console.WriteLine("3 - EDUCACAO FISICA");
            Console.WriteLine("4 - ESPANHOL");
            Console.WriteLine("5 - FILOSOFIA");
            Console.WriteLine("6 - GEOGRAFIA");
            Console.WriteLine("7 - HISTORIA");
            Console.WriteLine("8 - INGLES");
            Console.WriteLine("9 - PORTUGUES");
            Console.WriteLine("10 - MATEMATICA");
            escolha = int.Parse(Console.ReadLine());
            switch (escolha)
            {
                case 1:
                    materia = "CIENCIAS";
                    break;
                case 2:
                    materia = "CIENCIAS";
                    break;
                case 3:
                    materia = "EDUCACAO FISICA";
                    break;
                case 4:
                    materia = "ESPANHOL";
                    break;
                case 5:
                    materia = "FILOSOFIA";
                    break;
                case 6:
                    materia = "GEOGRAFIA";
                    break;
                case 7:
                    materia = "HISTORIA";
                    break;
                case 8:
                    materia = "INGLES";
                    break;
                case 9:
                    materia = "PORTUGUES";
                    break;
                case 10:
                    materia = "MATEMATICA";
                    break;
            }

            return materia;

        }




    }
}

