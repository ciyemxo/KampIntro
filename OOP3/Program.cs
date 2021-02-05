using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {

            IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();


            TasitKrediManager tasitkrediManager = new TasitKrediManager();

            IKrediManager konutKrediManager = new KonutKrediManager();

            BasvuruManager basvuruManager = new BasvuruManager();
            //basvuruManager.BasvuruYap(ihtiyacKrediManager);



            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager , tasitkrediManager };

            basvuruManager.KrediOnBilgilendirmesiYap(krediler);

        }
    }
}
