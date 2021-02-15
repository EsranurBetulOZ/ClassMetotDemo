using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.ID = 123;
            musteri1.Adi = "Ahmet";
            musteri1.Soyadi = "Güney";
            Musteri musteri2 = new Musteri();
            musteri2.ID = 1234;
            musteri2.Adi = "Ayşe";
            musteri2.Soyadi = "Yılmaz";
            Musteri musteri3 = new Musteri();
            musteri3.ID = 1266;
            musteri3.Adi = "Sevim";
            musteri3.Soyadi = "Gürsoy";


            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Add(musteri1);
            musteriManager.Add(musteri2);
            musteriManager.Add(musteri3);
            musteriManager.Delete(musteri3);
            Console.WriteLine("\n Müşteri listesi \n ");
            musteriManager.MusteriListe(musteri1);
            musteriManager.MusteriListe(musteri2);
            musteriManager.MusteriListe(musteri3);

        }
    }
}
