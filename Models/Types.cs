using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuickAPI.Models
{
    public class Types
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public virtual List<Monster> Monsters { get; set; }
    }
}
