using System;
using System.Collections.Generic;

using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

public class turma
{
    [JsonProperty("turma")]
    public string Turma { get; set; }

    [JsonProperty("aulas")]
    public Aula[] Aulas { get; set; }
}