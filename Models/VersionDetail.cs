using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorPokeApi.Models
{
    public class VersionDetail
    {
        public int rarity { get; set; }
        public Version version { get; set; }
    }
}