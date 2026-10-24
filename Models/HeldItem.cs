using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorPokeApi.Models
{
    public class HeldItem
    {
        public Item item { get; set; }
        public List<VersionDetail> version_details { get; set; }
    }
}