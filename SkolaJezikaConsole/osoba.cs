using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkolaJezikaConsole
{
   public class osoba
    {
       public string Ime { get; set; }
       
       private string prezime;

       public string Prezime
       {
           get { return prezime; }
           set { prezime = value; }
       }

       public string JMBG { get; set; }

       public osoba()
       {

       }

       public osoba(string ime, string prezime, string jmbg)
       {
           this.Ime = ime;
           this.prezime = prezime;
           this.JMBG = jmbg;

       }
       public void pozdrav()
       {
           Console.WriteLine("Pozdrav iz osobe");
       }
       public override string ToString()
       {
           return "Ime: " + this.Ime + "\nPrezime: " + this.prezime + "\nJMBG: " + this.JMBG;
       }
    }
}
