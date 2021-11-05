using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Razor_mvc
{
    public class Expenditure
    {
        public string nom { get; set; }

        public DateTime date { get; set; }

        public double prix { get; set; }

        public Expenditure(string nom, string Date, double prix)
        {
            this.nom = nom;
            this.date = DateTime.Parse(Date);
            this.prix = prix;
        }

    }
}
