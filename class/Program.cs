using System;

namespace class
{
    class Program
{
    static void Main(string[] args)
    {
        string adi = "barış";
        int yas = 18;
        Console.WriteLine("Hello World ! !");

        Kurs kurs1 = new Kurs();
        kurs1.KursAdi = "c#";
        kurs1.Egitmen = "engin demiroğ";
        kurs1.IzlenmeOrani = 68;

        Kurs kurs2 = new Kurs();
        kurs2.KursAdi = "java";
        kurs2.Egitmen = "hüsamettin";
        kurs2.IzlenmeOrani = 50;

        Kurs kurs3 = new Kurs();
        kurs3.KursAdi = "python";
        kurs3.Egitmen = "kerim";
        kurs3.IzlenmeOrani = 72;

        Console.WriteLine(kurs1.KursAdi + " " + kurs1.Egitmen + );
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int İzlenmeOrani { get; set; }
    }


}
}
