using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;

namespace listaAlunos
{
    public class Turma
    {
        
        public string Turmas { get; set; }

        public List<Aula> Aulas { get; set; }

        public List<Aluno> Alunos { get; set; }
    }
}
