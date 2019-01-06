using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vjezba_Logika.Logika
{
    class Album
    {
        private string naziv;
        private Izvodac izvodac;
        private Zanr_enumeracija zanr;
        private int godina;
        private List<Pjesma> pjesme;

        public Album(string naziv, Izvodac izvodac, Zanr_enumeracija zanr, int godina)
        {
           this.naziv = naziv;
           this.izvodac = izvodac;
           this.zanr = zanr;
           this.godina = godina;
            pjesme = new List<Pjesma>();
        }

        public string VratiNaziv()
        {
            return naziv;
        }

        public Zanr_enumeracija VratiZanr()
        {
            return zanr;
        }

        public Izvodac VratiIzvodaca()
        {
            return izvodac;
        }

        public int VratiGodinu()
        {
            return godina;
        }

        public List<Pjesma> VratiPjesme()
        {
            return pjesme;
        }

        public void DodajPjesmu(Pjesma _pjesma)
        {
            pjesme.Add(_pjesma);
        }

        public void DodajPjesmu(int rbr, string naziv, int trajanje)
        {
            pjesme.Add(new Pjesma(rbr, naziv, trajanje, izvodac));
        }

        public void ObrisiPjesmu(int _rbr)
        {
            for (int i = pjesme.Count - 1; i >= 0; i--)
                if (pjesme[i].VratiRbr() == _rbr)
                    pjesme.RemoveAt(i);
        }

        public int VratiBrojPjesama()
        {
            return pjesme.Count;
        }

        public int VratiTrajanje()
        {
            int t = 0;
            foreach (Pjesma p in pjesme)
                t += p.VratiTrajanje();
            return t;
        }
    }
}
