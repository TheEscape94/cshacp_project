using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkolaJezikaConsole
{
    public class Korisnik : osoba
    {
        public string KorisnickoIme { get; set; }
        public string Lozinka { get; set; }

        public Korisnik() : base()
        {

        }
        public Korisnik(string ime, string prezime, string jmbg, string kime, string loz) : base (ime, prezime, jmbg)
            
        {
            this.KorisnickoIme = kime;
            this.Lozinka = loz;
        }

        public bool logIn(string kime, string loz)
        {
            if (kime == this.KorisnickoIme && loz == this.Lozinka)
            {
                return true;
            }
            return false;
        }
    }
}
