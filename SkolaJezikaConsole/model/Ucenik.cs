using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkolaJezikaConsole
{
    public class Ucenik : osoba
    {
        public double Ocene { get; set; }

        public Ucenik() : base() 
        {
        }
        public Ucenik(string ime, string prezime, string jmbg, double ocene) : base(ime, prezime, jmbg) 
        {
            this.Ocene = Ocene;
        }
        public override string ToString()
        {
            return base.ToString() + "\nOcene: "+ this.Ocene;
        }
    }
}
