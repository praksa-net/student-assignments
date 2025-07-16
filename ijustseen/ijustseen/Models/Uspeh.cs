using System;
using System.Text.Json.Serialization;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum Uspeh
{
    Odlican,
    VrloDobar,
    Dobar,
    Dovoljan,
    Nedovoljan,
    NemaOcena
}