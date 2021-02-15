using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Add(Musteri musteri)
        {
            Console.WriteLine("Eklenen müşteri  ID'si :" + musteri.ID);
        }
        public void Delete(Musteri musteri)
        {
            Console.WriteLine(musteri.ID + " ID'li Müşteri silindi");
        }
        public void MusteriListe(Musteri musteri)
        {
             Console.WriteLine(musteri.ID + " : " + musteri.Adi + " " + musteri.Soyadi);
             Console.WriteLine("------------------------");
            
        }
    }
}