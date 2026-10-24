using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorPokeApi.Models
{
    public class PastAbility
    {
        public Generation generation { get; set; }
        public List<Ability> abilities { get; set; }
    }
}