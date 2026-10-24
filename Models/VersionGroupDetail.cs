using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorPokeApi.Models
{
    public class VersionGroupDetail
    {
        public int level_learned_at { get; set; }
        public VersionGroup version_group { get; set; }
        public MoveLearnMethod move_learn_method { get; set; }
        public object order { get; set; }
    }
}