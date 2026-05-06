using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Models
{
    public class BonItem
    {
        public int ProdusId { get; set; }
        public string Nume { get; set; }
        public int Cantitate { get; set; }
        public double Pret { get; set; }
        public double Total => Cantitate * Pret;
        public bool Trimis { get; set; } = false;
    }


}
