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
        public string GetTurma()
        {
            string turma = string.Empty;
            int escolha = int.MinValue;
            string[] listaTurma = new string[8];
            listaTurma[0] = "6AM.json";
            listaTurma[1] = "6BM.json";
            listaTurma[2] = "7AM.json";
            listaTurma[3] = "7BM.json";
            listaTurma[4] = "8AM.json";
            listaTurma[5] = "8BM.json";
            listaTurma[6] = "9AM.json";
            listaTurma[7] = "9BM.json";

            for (int i = 0; i < listaTurma.Length; i++)
            {
                Console.WriteLine(i + " - " + listaTurma[i]);
            }
            escolha = int.Parse(Console.ReadLine());
            turma = listaTurma[escolha];
            return turma;
        }
        
       
    }
}
