using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace listaAlunos
{
    public class Turma
    {
        public object Aulas { get; internal set; }
        [JsonProperty ("Nome")]
        public string Nome { get; set; }

        public object Nota1 { get; set; }
        public object Nota2 { get; set; }
        public string Materia { get; set; }
        //    public List<Aluno> Alunos { get; set; }

        //public class Aluno
        //{
        //    public string Nome { get; set; }
        //    public object Nota1 { get; set; }
        //    public object Nota2 { get; set; }
        //}

        //public class Aula
        //{
        //    public string Materia { get; set; }
        //    public List<Aluno> Alunos { get; set; }
        //}

        //public class RootObject
        //{
        //    public string Turma { get; set; }
        //    public List<Aula> Aulas { get; set; }
        //    public string Materia { get; set; }
        //    public List<Aluno> Alunos { get; set; }
        //    public string Nome { get; set; }
        //    public object Nota1 { get; set; }
        //    public object Nota2 { get; set; }
        //}
    }
}
