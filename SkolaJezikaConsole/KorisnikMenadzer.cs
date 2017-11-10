using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SkolaJezikaConsole
{
    public class KorisnikMenadzer
    {
        public static List<Korisnik> korisnici = new List<Korisnik>();
        public static string path = @"..\..\korisnici.txt";

        public static void UcitajKorisnike()
        {
            /*
            Korisnik k = new Korisnik("Marko", "Markovic", "123", "m", "m");
            korisnici.Add(k);
            korisnici.Add(new Korisnik("Janko", "Jankovic", "321", "j", "j"));
            korisnici.Add(new Korisnik("Milan", "Jankovic", "567", "mm", "mm"));
             */

            string path = @"..\..\korisnici.txt";
            if (File.Exists(path))
            {
                //postoji datoteka i radimo dalje 
                StreamReader sr = new StreamReader(path);
                string line = "";
                while ((line = sr.ReadLine()) != null)
                {

                    //Console.Writeline(">> " + line);

                    string[] tokeni = line.Split('|');

                    //izuzetak 
                    if (tokeni.Length != 5)
                    {
                        throw new TokenException("Greska: Nedovoljan broj tokena!");
                        continue;
                    }
                    else
                    {
                        korisnici.Add(new Korisnik(tokeni[0], tokeni[1], tokeni[2], tokeni[3], tokeni[4]));
                    }
                }
                sr.Close();
            }
            else
            {
                //ne postoji datoteka, pravimo novu
                Console.WriteLine("Datoteka " + path + " ne postoji ");
                File.Create(path);
            }

        }

        public static void SacuvajKorisnike()
        {
            //string path = @"..\..\korisnici.txt";
            if (!File.Exists(path))
            {
                File.Create(path).Close();
            }
            
            using (StreamWriter sw = new StreamWriter(path))
            {
                foreach (Korisnik k in korisnici)
                {
                    sw.WriteLine(k.Ime + "|" + k.Prezime + "|" + k.JMBG + "|" + k.KorisnickoIme + "|" + k.Lozinka);
                }
            }
            
        }

        public static void PrikaziKorisnike()
        {
            foreach (Korisnik k in korisnici)
            {
                Console.WriteLine("+----------------------------------------+");
                Console.WriteLine("| " + k + " |");
                Console.WriteLine("+----------------------------------------+");

            }
        }

        public static void DodajKorisnika()
        {
            Console.WriteLine("Ime:");
            string ime = Console.ReadLine();
            Console.WriteLine("Prezime:");
            string prezime = Console.ReadLine();
            Console.WriteLine("JMBG");
            string jmbg = Console.ReadLine();
            Console.WriteLine("KorisnickoIme:");
            string kime = Console.ReadLine();
            Console.WriteLine("Lozinka:");
            string loz = Console.ReadLine();
            korisnici.Add(new Korisnik(ime, prezime, jmbg, kime, loz));
        }
        public static void IzmeniKorisnika()
        {
            Console.WriteLine("Unesite JMBG korisnika:");
            string jmbg = Console.ReadLine();

            for (int i = 0; i < korisnici.Count; i++)
            {

                if (korisnici[i].JMBG == jmbg)
                {
                    Console.WriteLine("Ime:");
                    korisnici[i].Ime = Console.ReadLine();
                    Console.WriteLine("Prezime:");
                    korisnici[i].Prezime = Console.ReadLine();
                    Console.WriteLine("JMBG");
                    korisnici[i].JMBG = Console.ReadLine();
                    Console.WriteLine("KorisnickoIme:");
                    korisnici[i].KorisnickoIme = Console.ReadLine();
                    Console.WriteLine("Lozinka:");
                    korisnici[i].Lozinka = Console.ReadLine();
                }
            }
        }
        public static void ObrisiKorisnika()
        {
            Console.WriteLine("Unesite JMBG korisnika:");

            string jmbg = Console.ReadLine();

            for (int i = 0; i < korisnici.Count; i++)
            {

                if (korisnici[i].JMBG == jmbg)
                    korisnici.Remove(korisnici[i]);
                break;
            }
        }


        public static void PretragaKorisnika(string param)
        {
            Console.WriteLine("Unesite ime za pretragu:");
            string ime = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Rezultitati pretrage: ");

            switch (param)
            {
                case "ime":

                    foreach (Korisnik k in korisnici)
                    {
                        if (k.Ime.ToLower().Contains(ime.ToLower()))
                        {
                            sb.AppendLine(k.Ime);
                        }
                    }
                    break;
                default:
                    break;
            }
            Console.WriteLine(sb.ToString());
        }

        public static void PretragaPoJMBG(string param)
        {
            Console.WriteLine("Unesite jmbg za pretragu:");
            string jmbg = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Rezultitati pretrage: ");

            switch (param)
            {
                case "jmbg":

                    foreach (Korisnik k in korisnici)
                    {
                        if (k.JMBG == jmbg)
                        {
                            sb.AppendLine(k.JMBG);
                        }
                    }
                    break;
                default:
                    break;
            }
            Console.WriteLine(sb.ToString());
        }
    }
}         
