using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z2_Kontakti
{
    class Kontakt
    {
        //props za polja ime i prezime i glavniBroj
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string GlavniBroj { get; set; }
        private List<string> OstaliBrojevi = new List<string>();

        //konstruktor sa parametrima za: ime, prezime i glavniBroj
        public Kontakt(string Ime, string Prezime, string GlavniBroj)
        {
            this.Ime = Ime;
            this.Prezime = Prezime;
            this.GlavniBroj = GlavniBroj;
        }
        //metod DodajBroj(string dodatniBroj) - dodaje u listu ostalih brojeva dodatni
        //broj telefona ukoliko je zadati broj različit od glavnog i već se ne nalazi u listi ostalih brojeva
        public bool DodajBroj(string dodatniBroj)
        {
            if (dodatniBroj != GlavniBroj && !OstaliBrojevi.Contains(dodatniBroj))
                return true;
                OstaliBrojevi.Add(dodatniBroj);

                return false;            
        }
        //metod IzbrisiBroj(string dodatniBroj) - izbacuje iz liste ostalih brojeva zadati broj ukoliko on postoji
        public bool IzbrisiBroj(string dodatniBroj)
        {
               return OstaliBrojevi.Remove(dodatniBroj);       
        }
        //ToString – vraća string sa svim informacijama
        public override string ToString()
        {
            return $"{Ime}, {Prezime}, {GlavniBroj}{IspisiOstaleBrojeve()}";
        }
        public string IspisiOstaleBrojeve()
        {
            int i = 0;
            string listaBrojeva = ", [";
            foreach (var item in OstaliBrojevi)
            {
                if (i == 0)
                    listaBrojeva += $"{item}";
                else
                    listaBrojeva += $", {item}";

                i++;
            }
            listaBrojeva += "]";
            return listaBrojeva;
        }
    }
}
