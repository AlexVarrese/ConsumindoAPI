using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace ConsumindoAPI.Model
{
    public class Usuario
    {
        [JsonProperty("retorno")]
        public string Retorno { get; set; }

        [JsonProperty("person")]
        public List<Pessoa> Pessoas { get; set; }
    }
}
