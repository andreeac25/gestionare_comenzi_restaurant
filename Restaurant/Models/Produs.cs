using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Models
{
    public class Produs
    {
        public int Id { get; set; }
        public string Nume { get; set; }
        public double Pret { get; set; }
        public int CategorieId { get; set; }
        public string DisplayText => $"{Nume} - {Pret} RON";
    }
}
