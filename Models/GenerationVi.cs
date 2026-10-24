using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BlazorPokeApi.Models
{
    public class GenerationVi
    {
        [JsonProperty("x-y")]
        public XY xy { get; set; }
        public Icons icons { get; set; }

        [JsonProperty("omega-ruby-alpha-sapphire")]
        public OmegaRubyAlphaSapphire omegarubyalphasapphire { get; set; }
    }
}