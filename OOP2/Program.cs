using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "123456";
            musteri1.Adi = "engin";
            musteri1.SoyAdi = "demiroğ";
            musteri1.TcNo = "12345678";




            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "45678";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "1234567890";


            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();


            MusteriMenager musteriMenager = new MusteriMenager();
            musteriMenager.Ekle(musteri1);
            musteriMenager.Ekle(musteri2);

        }
    }
}
