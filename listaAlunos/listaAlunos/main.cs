using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;

namespace listaAlunos
{
    class Program
    {
        public static void Main(string[] args)
        {
            //var json = File.ReadAllText(AppDomain.BaseDirectory + "@\listaAlunos.json");
            /*var js = new DataContractJsonSerialization(Encoding.UTF8.GetBytes(json));
            var pessoa = (List<Aluno>)js.ReadObject(ms);*/
            //var Alunos = JsonConvert.DeserializeObject < List<listaAlunos>(alunos);
            //var json = File.ReadAllText(@"C:\Users\Rodrigo\source\repos\listaAlunos\listaAlunos\Serialization\9BM.json");
            //var json = File.ReadAllText(path: @"/Users/MonteiroMaker/Documents/Breads/Repo/listaAlunos/listaAlunos/9BM.json");
            //int status = deserialized[0].status;
            var json = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"listaAlunos.json");
            //var trm = JsonConvert.DeserializeObject<List<Turma>>(json);
            //var Turma = (List<Turma>)json.ReadObject(ms);*/
            var turma = JsonConvert.DeserializeObject<List<Turma>>(json);

    
            //Console.WriteLine(json);

            Console.WriteLine(turma[0].Alunos[1].Nome);

            //Console.WriteLine(json.Length);

            //turma[1].Nome = "Daniel";
        

            //Console.WriteLine("Nome: " + turma[1].Nome);
            //Console.WriteLine("Capacity: " + turma.Capacity);
            //Console.WriteLine("Count: " + turma.Count);
            //Console.WriteLine("A turma é: " + turma[0].Nome);

            
            //foreach (item in turma)
            //{
            //    Console.WriteLine(item);
            //}
            //_ = (string)Turma[1].Aulas;

            //Console.WriteLine("Nome: " + Turma[1].Nome);
            //Console.WriteLine(Turma[1].Aulas);


        }
    }
}
