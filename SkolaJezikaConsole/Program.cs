using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkolaJezikaConsole
{
    public class Program
    {
      //Korisnik[] Korisnici = new Korisnik[10];
      
      static bool ulogovan = false;

        static void Main(string[] args)
        {
            Console.WriteLine("Pozdrav!");
            mainMenu();

        }

        public static void mainMenu()
        {
            Console.WriteLine("Izaberite opciju:");

            string unos = "";
            while (unos != "0")
            {
                Console.WriteLine("1. Korisnik");
                Console.WriteLine("2. Nastavnik");

                Console.WriteLine("0. Kraj");
                unos = Console.ReadLine();

                switch (unos)
                {
                    case "1": korisnikView(); break;
                    case "2": logIn(); break;
                    default:
                        break;
                }
            }
        }

        public static void logIn()
        {
            try
            {
                KorisnikMenadzer.UcitajKorisnike();
            }
            catch (TokenException te) //hvata odredjen tip greske koji smo naveli
            {
                Console.WriteLine(te.Message + "\n\n" + te.StackTrace);
            }
            catch (Exception) //hvata ostale greske
            {
                throw;
            }


            while (!ulogovan)
            {
                Console.WriteLine("Unesite korisnicko ime:");
                Console.WriteLine("----------------------");
                string kime = Console.ReadLine();
                Console.WriteLine("Unesite lozinku:");
                Console.WriteLine("---------------");
                string loz = Console.ReadLine();
                for (int i = 0; i < KorisnikMenadzer.korisnici.Count; i++)
                {
                    if (KorisnikMenadzer.korisnici[i].logIn(kime, loz))
                    {
                        Console.WriteLine("Ulogovan");
                        ulogovan = true;
                        Meni();

                    }
                }
                if (!ulogovan) Console.WriteLine("Pogresno ste uneti podaci, pokusajte ponovo");
            }

            KorisnikMenadzer.SacuvajKorisnike();

            Console.ReadKey();
        }

        public static void korisnikView()
        {
            string unos = "";
            Console.WriteLine("Dobro dosli");
            Console.WriteLine("-----------");

            while (unos != "0")
            {
                Console.WriteLine("Meni:");
                Console.WriteLine("-----");
                Console.WriteLine("1. Aktuelni kursevi");
                Console.WriteLine("2. Cenovnik");
                Console.WriteLine("3. Spisak profesora");
                Console.WriteLine("0. Povratak u prethodni meni");
                unos = Console.ReadLine();

                switch (unos)
                {
                    //case "1": aktuelnikursegvi; break;
                    //case "2": cenovnik; break;
                    //case "3": spisakprofesora; break;
                    case "0": mainMenu(); break;
                    default:
                        break;
                }
            }

        }

        public static void Meni()
        {

            string unos = "";

            while (unos != "0")
            {
            Console.WriteLine("1. Prikaz korisnika");
            Console.WriteLine("2. Dodavanje korisnika");
            Console.WriteLine("3. Izmena korisnika");
            Console.WriteLine("4. Brisanje  korisnika");
            Console.WriteLine("5. Sortiranje korisnika");
            Console.WriteLine("6. Pretraga korisnika po imenu");
            Console.WriteLine("7. Pretraga korisnika po JMBG");
            Console.WriteLine("0. Kraj");
            unos = Console.ReadLine();

                switch (unos)
                {
                    case "1":  KorisnikMenadzer.PrikaziKorisnike(); break;
                    case "2":  KorisnikMenadzer.DodajKorisnika(); break;
                    case "3":  KorisnikMenadzer.IzmeniKorisnika(); break;
                    case "4":  KorisnikMenadzer.ObrisiKorisnika(); break;
                    case "5":  break;
                    case "6":  KorisnikMenadzer.PretragaKorisnika("ime"); break;
                    case "7":  KorisnikMenadzer.PretragaPoJMBG("jmbg"); break;
                    default:
                        break;
                }
            }
        }
            


        }
    }

