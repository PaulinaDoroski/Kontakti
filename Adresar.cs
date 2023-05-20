using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z2_Kontakti
{
    internal class Adresar
    {
        Dictionary<string, Kontakt> kontakti = new Dictionary<string, Kontakt>();

        //Dodaj(Kontakt k)
        public bool Dodaj(Kontakt k)
        {
            if (!kontakti.ContainsKey(k.GlavniBroj))
                return true;
                kontakti.Add(k.GlavniBroj, k);
           
                return false;
        }
        //Dodaj(string ime, string prezime, string glavniBroj)
        public bool Dodaj(string ime, string prezime, string glavniBroj)
        {
            if (!kontakti.ContainsKey(glavniBroj)) 
                return true;
                Kontakt k = new Kontakt(ime, prezime, glavniBroj);
                Dodaj(k);
                
                return false;

        }
        //Blokiraj(string broj) - briše kontakt sa zadatim glavnim brojem
        public bool Blokiraj(string broj)
        {
            if (!kontakti.ContainsKey(broj))
                return false;

                kontakti.Remove(broj);
                return true;
        }
        //Share(string file, string glavniBroj) - kreira fajl sa informacijama o kontaktu sa zadatim brojem
        public void Share(string file, string glavniBroj)
        {
            StreamWriter sw = null;
            try
            {
                sw = new StreamWriter("kontaktshare.txt");
                sw.WriteLine(kontakti[glavniBroj]);
            }
            catch (Exception)
            {
                Console.WriteLine("greska");
            }
            finally
            {
                if (sw != null)
                    sw.Close();
            }
        }
        //Receive(string file) - čita informacije iz binarnog fajla koji sadrži informacije o jednom
        //kontaktu i dodaje novi kontakt u kolekciju ukoliko kontakt sa tim glavnim brojem već ne postoji.    
        public void Receive(string file)
        {
            StreamReader sr = null;
            try
            {
                sr = new StreamReader("kontaktshare.txt");
                string str = sr.ReadLine();

            }
            catch (Exception )
            {
                Console.WriteLine("greska");
            }
            finally
            {
                if (sr != null)
                    sr.Close();
            }
        }
        //Backup(string file) - čuva sve informacije o kontaktima u zadatom tekstualnom fajlu
        public void Backup(string file)
        {
            StreamWriter sw = null;
            try
            {
                sw = new StreamWriter(file);
                foreach (var item in kontakti)
                {
                    sw.WriteLine(item);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("greska");              
            }
            finally
            {
                if (sw != null)
                    sw.Close();
            }
            
            
        }
    }
}
