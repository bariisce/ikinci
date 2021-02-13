using System;
using System.Collections.Generic;
using System.Text;

namespace metotlar
{
    class SepetManager
    {
        public void Ekle(Product product)
        {
            Console.WriteLine("Sepete Eklendi : " + product.Adi);
        }

        public void Ekle2(string productName, string aciklama, double fiyat,int stokAdedi)
        {
            Console.WriteLine("Sepete Eklendi : " + productName);
        }
    }
}
