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
    class Program
    {
        public static void Main(string[] args)
        {
            Turmas trm = new Turmas();
            string materia = null;
            string nome = null;

            Console.WriteLine("Digite uma materia");
            materia = Console.ReadLine();


            trm.metodo(materia);

            Console.WriteLine("Nome:");
            materia = null;
            nome = Console.ReadLine();
            Console.WriteLine("Materia");
            materia = Console.ReadLine();

            trm.rendimento(nome, materia);
        }
    }
}




