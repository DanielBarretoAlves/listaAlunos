using System;
using System.Collections.Generic;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.IO;
using System.Runtime.Serialization;

namespace listaAlunos
{
    class main
    {
        static void Main(string[] args)
        {
            var json = File.ReadAllText(@"C:\Users\Rodrigo\source\repos\listaAlunos\listaAlunos\Serialization\9BM.json");

            var trm = JsonConvert.DeserializeObject<List<Turmas>>(json);


            Console.WriteLine(trm);


       
            Console.ReadKey();
        }
    }
}
