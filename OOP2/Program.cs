using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "barış";
            musteri1.SoyAdi = "ceylan";
            musteri1.TcNo = "222222222222";
            musteri1.Id = 3;

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 5;
            musteri2.MusteriNo = "543321";
            musteri2.SirketAdi = "Kodlama.Io";
            musteri2.VergiNo = "111111";


            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(musteri1);
            customerManager.Add(musteri2);

        }
    }
}
