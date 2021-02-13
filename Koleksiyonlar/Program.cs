using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] { "Engin", "Murat", "Halil", "Berk" };
            //Console.WriteLine(isimler[0]);

            List<string> isimler2 = new List<string> { "barış", "arslan", "tekin", "murat" } ;
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("Akın");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);


            Console.ReadLine();
        }
    }
}
