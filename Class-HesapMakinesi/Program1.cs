using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_mirasAlma_kurs
{
    class SmartPro
    {
        public string ad;
        public string soyad;
    }
    class YonetimDairesi : SmartPro
    {

    }
    class EgitimDairesi :SmartPro
    {
        public int sinif;
    }
    class Kat :EgitimDairesi
    {
        
    }
    class Siniflar : Kat
    {
        public int metreKaresi;
        public int masaSayisi;
        public int bilgisayarSayisi;

    }
    class Kursiyer :Siniflar
    {
        public int ogrenciSayisi;
        public float boy;
        public int kilo;
        public string sacRengi;
        public string gozRengi;
        public string cinsiyet;
        public int not1;
        public int not2;

        public void kursiyerBilgi()
        {
            Console.WriteLine(ad);
            Console.WriteLine(soyad);
            Console.WriteLine(boy);
            Console.WriteLine(kilo);
            Console.WriteLine(sacRengi);
            Console.WriteLine(gozRengi);
            Console.WriteLine(cinsiyet);
            Console.WriteLine(sinif);
            Console.WriteLine(not1);
            Console.WriteLine(not2);
        }
        public void NotHesaplama()
        {
            Console.WriteLine("Ortalama: {0}", not1+not2);
            Console.WriteLine(not2);
        }
        public void vucutKutleEndeksi()
        {
            float VucutKE = kilo / ((boy / 100) * (boy / 100));
            if (VucutKE < 18)
            {
                Console.WriteLine("Çdüşük kilolu");
            }
            else if (VucutKE >= 18.5F && VucutKE <= 25)
            {
                Console.WriteLine("Normal kilolu");
            }
            else if (VucutKE > 25)
            {
                Console.WriteLine("Çok Kilolu ");
            }
        }
    }


    class Program
    {
        //static void Main(string[] args)
        //{
        //    Kursiyer kursiyer = new Kursiyer();

        //    Console.WriteLine("\n Kursiyer Bilgileri");
        //    Console.Write(" Kursiyer Adı: ");
        //    kursiyer.ad = Console.ReadLine();
        //    Console.Write("\n Kursiyer Soyadı: ");
        //    kursiyer.soyad = Console.ReadLine();
        //    Console.Write("\n Kursiyer Boyu: ");
        //    kursiyer.boy = float.Parse(Console.ReadLine());
        //    Console.Write("\n Kursiyer Kilosu: ");
        //    kursiyer.kilo = int.Parse(Console.ReadLine());
        //    Console.Write("\n Kursiyer Saç Rengi: ");
        //    kursiyer.sacRengi = Console.ReadLine();
        //    Console.Write("\n Kursiyer Goz Rengi: ");
        //    kursiyer.gozRengi = Console.ReadLine();
        //    Console.Write("\n Kursiyer Cinsiyet: ");
        //    kursiyer.cinsiyet = Console.ReadLine();
        //    Console.Write("\n Kursiyer Sınıfı: ");
        //    kursiyer.sinif = int.Parse(Console.ReadLine());
        //    Console.Write("\n Kursiyer 1. Notu: ");
        //    kursiyer.not1 = int.Parse(Console.ReadLine());
        //    Console.Write("\n Kursiyer 2. Notu: ");
        //    kursiyer.not2 = int.Parse(Console.ReadLine());


        //    Console.WriteLine("\n Çekilen veriler");
        //    kursiyer.kursiyerBilgi();

        //    kursiyer.NotHesaplama();

        //    Console.ReadKey();
        //}
    }
}
