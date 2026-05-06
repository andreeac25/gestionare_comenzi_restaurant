using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Models
{
    public class ComandaItem
    {
        public int Id { get; set; }
        public int MasaId { get; set; }
        public int ProdusId { get; set; }
        public int Cantitate { get; set; }
        public bool EsteTrimis { get; set; }
        public bool EsteSters { get; set; }
    }
}
