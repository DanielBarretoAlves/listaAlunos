using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace listaAlunos
{
    class Program
    {
        public static void Main(string[] args)
        {
            

            var json = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"listaAlunos.json");
            var trm = JsonConvert.DeserializeObject<List<Turma>>(json);
            List<Turma> Turma = JsonConvert.DeserializeObject<List<Turma>>(json);
            Console.WriteLine(Turma[0].Materia);



           
            
        }
    }
}
