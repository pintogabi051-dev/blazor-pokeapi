using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorPokeApi.Models
{
    public class ScarletViolet
    {
        public Icons icons { get; set; }
        public string back_shiny { get; set; }
        public object back_female { get; set; }
        public string front_shiny { get; set; }
        public string back_default { get; set; }
        public object front_female { get; set; }
        public string front_default { get; set; }
        public object back_shiny_female { get; set; }
        public object front_shiny_female { get; set; }
    }
}