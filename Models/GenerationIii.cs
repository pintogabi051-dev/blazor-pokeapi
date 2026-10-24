using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BlazorPokeApi.Models
{
    public class GenerationIii
    {
        public Icons icons { get; set; }
        public Emerald emerald { get; set; }

        [JsonProperty("ruby-sapphire")]
        public RubySapphire rubysapphire { get; set; }

        [JsonProperty("firered-leafgreen")]
        public FireredLeafgreen fireredleafgreen { get; set; }
    }
}