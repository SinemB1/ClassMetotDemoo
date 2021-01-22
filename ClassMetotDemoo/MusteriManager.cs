using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemoo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Sayın " + musteri.Adi + " " + musteri.Soyadi + ";\nKaydınız Eklendi.");
        }
        public void Listele(Musteri musteri)
        {
            Console.WriteLine("Sayın " + musteri.Adi + " " + musteri.Soyadi +
                ";\nBilgileriniz Şu Şekildedir : " +
                "\nAdınız Soyadınız : " + musteri.Adi + " " + musteri.Soyadi +
                "\nAdresiniz : " + musteri.Adres +
                "\nCinsiyetiniz : " + musteri.Cinsiyeti );
        }

        
    }
}
