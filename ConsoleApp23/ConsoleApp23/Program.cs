using System;

namespace ConsoleApp23
{
    class Program
    {
   
        static void Main(string[] args)
        {
            PolePowierzchniObjectoscKuli();
            string tekst = "supersuper super ";
            var ilosc =FunkcjaPrzyjmijTekst(tekst);
            Console.WriteLine("Ile razy Super : {0} ",ilosc);
           


        }

        private static int FunkcjaPrzyjmijTekst(string tekst)
        {
            var ilosc = 0;
            if (System.Text.RegularExpressions.Regex.IsMatch(tekst,"super"))
            {
                ilosc++;
            }

            return ilosc;
        }


        static void PolePowierzchniObjectoscKuli()
        {
            var r = Console.ReadLine();
            bool udalosie = int.TryParse(r, out int rP);
            if (udalosie)
            {
                Console.WriteLine("Udalo sie sparsowac");
            }
            else
            {
                Console.WriteLine("Nie dualo sie sparsowac");
                
            }
            double P = 4*Math.PI * rP * rP;
            double O = 4 / 3.0 * Math.PI * rP * rP;
            Console.WriteLine("Pole powierzchni: {0} Objętość kuli: {1}",P,O);

        }
    }
}