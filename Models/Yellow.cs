using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BlazorPokeApi.Models
{
    public class Yellow
    {
        [JsonProperty("back_gbc")]
        public string back_gbc { get; set; }
        [JsonProperty("back_gray")]
        public string back_gray { get; set; }
        [JsonProperty("front_gbc")]
        public string front_gbc { get; set; }
        [JsonProperty("front_gray")]
        public string front_gray { get; set; }
        [JsonProperty("back_default")]
        public string back_default { get; set; }
        [JsonProperty("front_default")]
        public string front_default { get; set; }
        [JsonProperty("back_transparent")]
        public string back_transparent { get; set; }
        [JsonProperty("front_transparent")]
        public string front_transparent { get; set; }
        [JsonProperty("back_transparent_gray")]
        public string back_transparent_gray { get; set; }
        [JsonProperty("front_transparent_gray")]
        public string front_transparent_gray { get; set; }
    }
}