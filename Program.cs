using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klase_i_objekti
{
    class KlasaC
    { 
        public int Zbroj (int[] niz)
        {
            int zbroj = 0;
            for ( int brojac = 0; brojac < niz.Length; brojac++ )
            {
                zbroj += niz[brojac];
            }
            return zbroj;

        }

        public double Prosjek(int[] niz)
        {
        double zbroj = Zbroj(niz);
            double prosjek = zbroj / niz.Length;
            return prosjek;
        }

    }

     class Program
    {
        static void Main(string[] args)
        {
            int zbroj;
            double prosjek;
            int[] niz = new int[5];
            Console.WriteLine("Vježba 2 Klase i objekti");
            Console.WriteLine("Upiši 5 brojeva");

            for(int brojac = 0; brojac < niz.Length; ++brojac)
            {
                int redniBroj = 1;
                Console.WriteLine(redniBroj + ". broj: ");
                niz[brojac] = Convert.ToInt32(Console.ReadLine());
                redniBroj++;
            }
            KlasaC objekt = new KlasaC();
            zbroj = objekt.Zbroj(niz);
            Console.WriteLine("Zbroj je: " + zbroj);

            prosjek = objekt.Prosjek(niz);
            Console.WriteLine("Prosjek je: "+ prosjek);



        }
    }
}
