using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vjezba_Logika.Logika
{
    class Pjesma
    {
        private int rbr;
        private string naziv;
        private int duzina;
        private Izvodac izvodac;

        public Pjesma(int rbr, string naziv, int duzina, Izvodac izvodjac)
        {
           this.rbr = rbr;
           this.naziv = naziv;
           this.duzina = duzina;
           this.izvodac = izvodjac;
        }

        public override string ToString()
        {
            return rbr.ToString() + ". " + naziv + ", " + izvodac.ToString() + " (" + duzina.ToString() + "s)";
        }

        public void PromijeniNaziv(string naziv)
        {
           this.naziv = naziv;
        }

        public int VratiTrajanje()
        {
            return duzina;
        }

        public int VratiRbr()
        {
            return rbr;
        }
    }
}

