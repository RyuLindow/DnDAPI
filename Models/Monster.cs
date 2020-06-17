using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace QuickAPI.Models
{
    public class Monster
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Challenge_rating { get; set; }
        public string Alignment { get; set; }

        public int TypeId { get; set; }
        [JsonIgnore]
        public virtual Types Type { get; set; }
        public virtual Stats Stats { get; set; }
    }
}
