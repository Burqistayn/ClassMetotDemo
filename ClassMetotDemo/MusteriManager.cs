using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("--------------------");
            Console.WriteLine(musteri.Isim + " eklendi");
            Console.WriteLine("--------------------");
        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine("--------------------");
            Console.WriteLine(musteri.Isim + " silindi");
            Console.WriteLine("--------------------");
        }
        public void Listele(Musteri[] Musteriler)
        {
            Console.WriteLine("--------------------");
            foreach (var musteri in Musteriler)
            {
                Console.WriteLine(musteri.Isim);
            }
            Console.WriteLine("--------------------");
        }
    }
}
