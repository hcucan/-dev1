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
