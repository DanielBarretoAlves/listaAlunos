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
            Alunos All = new Alunos();
            Materia mat = new Materia();
            string materia = "ARTES";
            //string nome;
            string testezao = "listaAlunos.json";
            string json2 = "EmptyJSONFile.json";
            bool key = false;
            int escolha;

            while(key!= true)
            {
                Console.WriteLine("0 - Sair");
                Console.WriteLine("1 - Media de Uma Materia");
                Console.WriteLine("2 - Media de Um Aluno");
                Console.WriteLine("3 - Rendimento");
                escolha = int.Parse(Console.ReadLine());
                if (escolha == 0)
                {
                    key = true;
                }
                else if (escolha == 1)
                {

                    Console.WriteLine("Media da Sala:" + mat.getMediaMateria(json2, mat.getMateria()));
                }else if(escolha == 2)
                {
                    Console.WriteLine("Media do Aluno: " + All.mediaAluno(json2, mat.getMateria(), mat.getNomeAluno(json2, mat.getMateria())));
                }else if (escolha == 3)
                {
                    Console.WriteLine("Rendimento: " + All.getRendimento(testezao, mat.getMateria(), mat.getNomeAluno(testezao, mat.getMateria())));
                }


            }

            
            //Console.WriteLine("Media : " + All.mediaAluno(testezao, materia, mat.getNomeAluno(testezao, materia)));
            
            
        }
    }
}




