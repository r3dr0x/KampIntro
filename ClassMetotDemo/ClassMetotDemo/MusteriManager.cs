using System;
using System.Collections.Generic;
using System.Text;

namespace Odev
{
    class MusteriManager
    {
        public void Ekle(Musteri musterim)
        {
            Console.WriteLine("ID: " + musterim.ID + " Adı: " + musterim.Musteriyas + " Soyad : " + musterim.MusteriTelefon + ": " + " Müşteri Başarıyla Eklendi");
        }

        public void Kontrol(Musteri musterim)
        {
            Console.WriteLine("ID: " + musterim.ID + " Adı: " + musterim.MusteriIsım + " Soyad : " + musterim.MusteriTelefon + ": " + " Müşteri Başarıyla Kontrol Edildi");
        }

        public void Sil(Musteri musterim)
        {
            Console.WriteLine("ID: " + musterim.ID + " Ad : " + musterim.MusteriIsım + " Soyad : " + musterim.MusteriTelefon + " : " + " Müşteri Başarıyla Silindi");
        }



    }
}
