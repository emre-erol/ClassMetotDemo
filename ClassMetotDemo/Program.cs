using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.musteriIsim = "Emre";
            musteri1.musteriSoyisim = "Erol";
            musteri1.hesapId = 1234567;


            Musteri musteri2 = new Musteri();
            musteri2.musteriIsim = "Mert";
            musteri2.musteriSoyisim = "Erol";
            musteri2.hesapId = 1234555;


            Musteri musteri3 = new Musteri();
            musteri3.musteriIsim = "İrem";
            musteri3.musteriSoyisim = "Erol";
            musteri3.hesapId = 1234568;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            MusteriManager musteriManager = new MusteriManager();

            musteriManager.MusteriEkle(musteri1);
            musteriManager.MusteriEkle(musteri2);
            musteriManager.MusteriEkle(musteri3);

            Console.WriteLine("--------------------");

            musteriManager.MusteriSil(musteri1);
            musteriManager.MusteriSil(musteri2);
            musteriManager.MusteriSil(musteri3);

            Console.WriteLine("---------------------");

            musteriManager.MusteriListele(musteri1);
            musteriManager.MusteriListele(musteri2);
            musteriManager.MusteriListele(musteri3);
        }
    }
}
