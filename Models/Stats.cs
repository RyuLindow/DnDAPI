using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuickAPI.Models
{
    public class Stats
    {
        public int Id { get; set; }
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Constitution { get; set; }
        public int Intelligence { get; set; }
        public int Wisdom { get; set; }
        public int Charisma { get; set; }

        public virtual List<Monster> Monsters { get; set; }

    }
}
