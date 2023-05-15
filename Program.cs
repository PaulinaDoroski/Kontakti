using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z2_Kontakti
{
    class Program
    {
        static void Main(string[] args)
        {
            Kontakt k1 = new Kontakt("Natasa", "Drinisc", "9999999");
            k1.DodajBroj("021089445");
            k1.DodajBroj("063698799");
            k1.ToString();

            k1.IzbrisiBroj("063698799");
            Console.WriteLine(k1);
            k1.IzbrisiBroj("222222");
            Console.WriteLine(k1);

            Kontakt k2 = new Kontakt("Sara", "Pavuljak", "6666666");
            k2.DodajBroj("021547935");
            Console.WriteLine(k2);

            Adresar a1 = new Adresar();
            a1.Dodaj(k1);
            a1.Dodaj(k2);
            Console.WriteLine(a1);

            k1.ToString();
        }
    }
}
