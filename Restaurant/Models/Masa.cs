using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Models
{
    public class Masa
    {
        public int Id { get; set; }
        public bool Ocupata { get; set; }

        public List<BonItem> Bon { get; set; } = new List<BonItem>();
    }
}
