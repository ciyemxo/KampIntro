﻿using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {

            string urunAdi1 = "Elma";
            double fiyati1 = 15;
            string aciklama = "amasya elması";

            string[] meyveler = new string[] { };



            Urun urun1 = new Urun();
            urun1.Adi = "elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "amasya elması";


            Urun urun2 = new Urun();
            urun2.Adi = "karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "diyarbakır karpuzu";


            Urun[] urunler = new Urun[] {urun1, urun2 };


            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("-----------------------");

            }


            Console.WriteLine("-------------------------Metotlar--------------------------------");



            // instance - örnek
            //encapsulation

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);



            sepetManager.Ekle2("armut", "yeşil elma", 12, 10);
            sepetManager.Ekle2("Elma", "yeşil armut", 12, 9);
            sepetManager.Ekle2("Karpuz", "diyarbakır karpuz", 12, 8);



        }
    }
}
