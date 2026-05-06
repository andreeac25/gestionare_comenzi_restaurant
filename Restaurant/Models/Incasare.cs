using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Models
{
    public class Incasare
    {
        public int MasaId { get; set; }
        public string MetodaPlata { get; set; } // Cash / Card
        public decimal Total { get; set; }
        public DateTime Data { get; set; }
    }
}
