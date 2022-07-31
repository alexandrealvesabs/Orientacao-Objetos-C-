using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace c_1.src.Entities
{
    public class Knight : Hero
    {
        public Knight(string Name,int level, string HeroType){
            this.Name = Name;
            this.level = level;
            this.HeroType = HeroType;
        }
    }
}