using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vjezba_Logika.Logika
{
    class Izvodac
    {

        private string naziv;
        private int godina;
        private string mjesto;

        public Izvodac(string naziv, int godina, string mjesto)
        {
           this.naziv = naziv;
           this.godina = godina;
           this.mjesto = mjesto;
        }

        public override string ToString()
        {
            return naziv + ", " + mjesto + " (" + godina.ToString() + ")";
        }
    }
}