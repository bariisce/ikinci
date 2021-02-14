using System;

namespace Dictionaryy
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string> oyuncular = new MyDictionary<string>();
            oyuncular.Add("Mesut Özil");
            Console.ReadLine();
        }
    }
}
