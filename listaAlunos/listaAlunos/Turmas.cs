using System;
using System.Collections.Generic;

using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace listaAlunos
{
    public class Turmas
    {
        [JsonProperty("turma")]
        public string Turma { get; set; }

        [JsonProperty("materia")]
        public string Materia { get; set; }

        [JsonProperty("alunos")]
        public List<Aluno> Aluno { get; set; }


    }
}
