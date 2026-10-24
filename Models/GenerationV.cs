using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BlazorPokeApi.Models
{
    public class GenerationV
    {
        public Icons icons { get; set; }

        [JsonProperty("black-white")]
        public BlackWhite blackwhite { get; set; }
    }
}