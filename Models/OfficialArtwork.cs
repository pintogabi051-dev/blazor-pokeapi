using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorPokeApi.Models
{
    public class OfficialArtwork
    {
        public Versions versions { get; set; }
        public string front_shiny { get; set; }
        public string front_default { get; set; }
    }
}