using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_rpg.Dtos.Character
{
    public class AddCharacterDto
    {
        public String Name { get; set; } = "Frodo";
        public int HitPoints { get; set; } = 100;
        public int Strength { get; set; } = 10;
        public int Defence { get; set; } = 10;
        public int Intellegence { get; set; } = 10;
        public RpgClass Class { get; set; } = RpgClass.Knight;
    }
}