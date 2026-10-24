using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BlazorPokeApi.Models
{
    public class GenerationIx
    {
        public Champions champions { get; set; }

        [JsonProperty("legends-za")]
        public LegendsZa legendsza { get; set; }

        [JsonProperty("scarlet-violet")]
        public ScarletViolet scarletviolet { get; set; }
    }
}