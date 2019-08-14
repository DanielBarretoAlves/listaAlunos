using System;
using System.Collections.Generic;

using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
public class Aluno
{
    [JsonProperty("nome")]
    public string Nome { get; set; }

    [JsonProperty("nota1")]
    public double Nota1 { get; set; }

    [JsonProperty("nota2")]
    public double Nota2 { get; set; }
}
