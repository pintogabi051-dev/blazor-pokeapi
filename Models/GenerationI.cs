using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BlazorPokeApi.Models
{
    public class GenerationI
    {
        [JsonProperty("red-and-blue")]
        public RedAndBlue redandblue { get; set; }

        [JsonProperty("red-and-green")]
        public RedAndGreen redandgreen { get; set; }
        public Yellow yellow { get; set; }

        [JsonProperty("red-blue")]
        public RedBlue redblue { get; set; }

        [JsonProperty("red-green-japan")]
        public RedGreenJapan redgreenjapan { get; set; }
    }
}