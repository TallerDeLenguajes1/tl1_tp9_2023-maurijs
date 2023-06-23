// Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
using System.Text.Json.Serialization;

namespace claseJson
{
    public class Bpi
    {
        [JsonPropertyName("USD")] //maquetador, no es necesario eliminarlo
        public USD USD { get; set; }

        [JsonPropertyName("GBP")]
        public GBP GBP { get; set; }

        [JsonPropertyName("EUR")]
        public EUR EUR { get; set; }
    }

    public class EUR
    {
        [JsonPropertyName("code")]
        public string code { get; set; }

        [JsonPropertyName("symbol")]
        public string symbol { get; set; }

        [JsonPropertyName("rate")]
        public string rate { get; set; }

        [JsonPropertyName("description")]
        public string description { get; set; }

        [JsonPropertyName("rate_float")]
        public double rate_float { get; set; }
    }

    public class GBP
    {
        [JsonPropertyName("code")]
        public string code { get; set; }

        [JsonPropertyName("symbol")]
        public string symbol { get; set; }

        [JsonPropertyName("rate")]
        public string rate { get; set; }

        [JsonPropertyName("description")]
        public string description { get; set; }

        [JsonPropertyName("rate_float")]
        public double rate_float { get; set; }
    }

    //clase root es la clase principal, le cambio el nombre a lo que corresponda
    public class CambioBTC
    {
        [JsonPropertyName("time")]
        public Time time { get; set; }

        [JsonPropertyName("disclaimer")]
        public string disclaimer { get; set; }

        [JsonPropertyName("chartName")]
        public string chartName { get; set; }

        [JsonPropertyName("bpi")]
        public Bpi bpi { get; set; }
    }

    public class Time
    {
        [JsonPropertyName("updated")]
        public string updated { get; set; }

        [JsonPropertyName("updatedISO")]
        public DateTime updatedISO { get; set; }

        [JsonPropertyName("updateduk")]
        public string updateduk { get; set; }
    }

    public class USD
    {
        [JsonPropertyName("code")]
        public string code { get; set; }

        [JsonPropertyName("symbol")]
        public string symbol { get; set; }

        [JsonPropertyName("rate")]
        public string rate { get; set; }

        [JsonPropertyName("description")]
        public string description { get; set; }

        [JsonPropertyName("rate_float")]
        public double rate_float { get; set; }
    }

}
