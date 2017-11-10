using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkolaJezikaConsole
{
    public class Kurs
    {
        public Jezik JezikKursa { get; set; }
        public TipKursa tip { get; set; }
        public double Cena { get; set; }
        public Nastavnik predavac { get; set; }
        List<Ucenik> ucenici = new List<Ucenik>();

    }
}
