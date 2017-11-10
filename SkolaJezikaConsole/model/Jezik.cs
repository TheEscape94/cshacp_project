using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkolaJezikaConsole
{
    public class Jezik
    {
        public string Naziv { get; set; }
        public string Oznaka { get; set; }

        public Jezik(string Naziv, string Oznaka) 
        {
            this.Naziv = Naziv;
            this.Oznaka = Oznaka;
        }
    }
}
