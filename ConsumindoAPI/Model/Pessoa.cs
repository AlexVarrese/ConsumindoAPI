using System;
using Newtonsoft.Json;

namespace ConsumindoAPI.Model
{
    public class Pessoa
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Nome { get; set; }

        [JsonProperty("mail")]
        public string Email { get; set; }

        [JsonProperty("role")]
        public string Regra { get; set; }

        [JsonProperty("__v")]
        public long Versao { get; set; }
    }
}
