using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MusteriManager musteriManager = new MusteriManager();

            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Isim = "Burak";
            musteri1.SoyIsim = "Çelik";
            musteri1.Yas = 35;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Isim = "Yusuf";
            musteri2.SoyIsim = "Yılmaz";
            musteri2.Yas = 28;

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Isim = "Ayşe";
            musteri3.SoyIsim = "Yıldız";
            musteri3.Yas = 28;

            Musteri[] Musteriler = new Musteri[] { musteri1, musteri2, musteri3 };
            musteriManager.Ekle(musteri1);
            musteriManager.Sil(musteri2);
            musteriManager.Listele(Musteriler);
        }
    }
}
