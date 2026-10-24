using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BlazorPokeApi.Models
{
    public class Other
    {
        public Home home { get; set; }
        public Showdown showdown { get; set; }
        public DreamWorld dream_world { get; set; }

        [JsonProperty("official-artwork")]
        public OfficialArtwork officialartwork { get; set; }
    }
}