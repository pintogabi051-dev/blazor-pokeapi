using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorPokeApi.Models
{
    public class Ability
    {
        public bool is_hidden { get; set; }
        public int slot { get; set; }
        public Ability2 ability { get; set; }
    }
}