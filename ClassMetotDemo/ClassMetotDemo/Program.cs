using System;

namespace Odev
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.ID = 44;
            musteri1.MusteriIsım = "Hakan";
            musteri1.MusteriTelefon = 1234;
            musteri1.Musteriyas = 44;

            Musteri musteri2 = new Musteri();
            musteri2.MusteriIsım = "Ahmet";
            musteri2.Musteriyas = 48;
            musteri1.ID = 44;

            Musteri musteri3 = new Musteri();
            musteri2.MusteriIsım = "Samet";
            musteri2.Musteriyas = 12;
            musteri1.ID = 12;

            Musteri musteri4 = new Musteri();
            musteri2.MusteriIsım = "Eylül";
            musteri2.Musteriyas = 31;
            musteri1.ID = 31;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3, musteri4 };

            Console.WriteLine("Müşteri Listesi Burada");

            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine("Müşteri İsim : " + Kontrol.MusteriIsım);

                Console.WriteLine("--------------------------");

                MusteriManager islemler = new MusteriManager();

                islemler.Ekle(musteri1);
                islemler.Ekle(musteri2);

                islemler.Kontrol(musteri1);
                islemler.Kontrol(musteri2);

                islemler.Sil(musteri1);
                islemler.Sil(musteri2); ;


            }
        }
    }
}


