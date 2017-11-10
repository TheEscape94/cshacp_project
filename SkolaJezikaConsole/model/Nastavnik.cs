using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkolaJezikaConsole
{
    public class Nastavnik : osoba
    {
        public int Plata { get; set; }

        public Nastavnik() : base() 
        {
        }

        public Nastavnik(string ime, string prezime, string jmbg, int plata) : base(ime, prezime, jmbg) 
        {
            this.Plata = plata;
        }
        public override string ToString()
        {
            return base.ToString() + " Plata "+ this.Plata;
        }
    }
}
