using System;
namespace Metotlar
{
    class SepetManager
    {
        //naming convention

        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi : " + urun.Adi);


        }

        public void Ekle2(string urunAdi, string Aciklama, double fiyat, int stokAdedi)
        {
            Console.WriteLine("Tebrikler.Sepete eklendi: " + urunAdi);
        }

    }
}
