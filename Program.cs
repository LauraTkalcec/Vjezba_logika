using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vjezba_Logika.Logika;

namespace Vjezba_Logika
{
    class Program
    {
        static void Main(string[] args)
        {
            Izvodac Novi = new Izvodac("Novi", 1960, "Zagreb");
            Album Proba = new Album("Proba", Novi, Zanr_enumeracija.Rock, 1969);
            Proba.DodajPjesmu(new Pjesma(1, "Drugacije", 257,Novi));
            Proba.DodajPjesmu(new Pjesma(2, "Nota", 482, Novi));
            Proba.DodajPjesmu(new Pjesma(3, "Popi", 524, Novi));
            Proba.DodajPjesmu(new Pjesma(4, "Classy", 600, Novi));
            Proba.DodajPjesmu(new Pjesma(5, "Nepoznato", 183, Novi));
            Proba.ObrisiPjesmu(2);
            // ispis
            Console.WriteLine("{0} \t {1} \t {2}\t ", Proba.VratiNaziv(), Proba.VratiIzvodaca(), Proba.VratiZanr());
            Console.WriteLine("Trajanje {0} min", Proba.VratiTrajanje() / 60);
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine("Popis pjesama sa albuma: ");
            foreach (Pjesma p in Proba.VratiPjesme())
                Console.WriteLine(p);
            Console.ReadLine();

        }
    }
    }
