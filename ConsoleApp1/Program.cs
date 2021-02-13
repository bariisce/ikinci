using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kurslar = new string[] { "YAZILIM GELİŞTİRİCİ YETİŞTİRME KAMPI", "PROGRAMLAMAYA BAŞLANGIÇ", "JAVA" };

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs); 
            }



            Console.WriteLine("sayfa sonu - footer");
        }
    }
}
