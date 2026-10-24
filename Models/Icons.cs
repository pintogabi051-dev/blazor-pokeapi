using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorPokeApi.Models
{
    public class Icons
    {
        public Animated animated { get; set; }
        public string front_default { get; set; }
        public object front_female { get; set; }
        public object front_shiny { get; set; }
        public object front_shiny_female { get; set; }
    }
}