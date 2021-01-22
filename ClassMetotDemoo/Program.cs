using System;

namespace ClassMetotDemoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hoş Geldiniz!");

            Musteri musteri1 = new Musteri();
            musteri1.Id = 1000;
            musteri1.Adi = "Sinem";
            musteri1.Soyadi = "Babuccu";
            musteri1.Adres = "Çankırı";
            musteri1.Cinsiyeti = true;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 1001;
            musteri2.Adi = "Gizem";
            musteri2.Soyadi = "Aslan";
            musteri2.Adres = "Karabük";
            musteri2.Cinsiyeti = true;

            Musteri musteri3 = new Musteri();
            musteri3.Id = 1002;
            musteri3.Adi = "Ahmet";
            musteri3.Soyadi = "Cevher";
            musteri3.Adres = "Ankara";
            musteri3.Cinsiyeti = false;

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            Console.WriteLine("----------------------------------");
            musteriManager.Listele(musteri2);
            Console.WriteLine("----------------------------------");
        }
    }
}
