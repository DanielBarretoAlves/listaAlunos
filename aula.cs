using System;
using System.Collections.Generic;

using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

public partial class Aula
{
    [JsonProperty("materia")]
    public string Materia { get; set; }

    [JsonProperty("alunos")]
    public Aluno[] Alunos { get; set; }

}