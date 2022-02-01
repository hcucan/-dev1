using System;

namespace ödev1
{
    class Program
    {
        static void Main(string[] args)
        {
            string cümle = "Türkcell gelecegi yazanlar";
            string[] kelimeler = cümle.Split(' ');
            Console.WriteLine("harf giriniz");
            string harf =Console.ReadLine();
            kelimeVarmi(cümle,harf,kelimeler);
            basHarfBulama(cümle, harf);
            harfVarmi(cümle, harf);
            bastanBoslukBirakma(cümle);
            cümledenSonraBoslukbirakma(cümle);
        }

        private static void cümledenSonraBoslukbirakma(string cümle)
        {
            Console.Write(cümle.PadRight(35));
            Console.WriteLine("hamza");
        }

        private static void bastanBoslukBirakma(string cümle)
        {
            string cümle2 = cümle.PadLeft(35);
            Console.WriteLine(cümle2);
        }

        private static void harfVarmi(string cümle, string harf)
        {
            Console.WriteLine(cümle.EndsWith(harf));
        }

        private static void basHarfBulama(string cümle,string harf)
        {
            Console.WriteLine(cümle.StartsWith(harf));
        }

        public static void kelimeVarmi(string cümle,string harf,string[] kelimeler)
        {
             foreach (var kelime in kelimeler)
            {
                if (kelime.Contains(harf))
                {
                    Console.WriteLine("var");
                }
                else
                {
                    Console.WriteLine("yok");
                }
            }
            foreach (var kelime in kelimeler)
            {
                Console.WriteLine(kelime);
            }
        }
    }
}
