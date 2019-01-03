using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_HesapMakinesi
{
    
    class programokan
    {
        static void Main(string[] args)
        {
            VerileriAlma veri = new VerileriAlma();
            Yazdırma yaz = new Yazdırma();
            veri.VeriAl();
            yaz.metod();
        }
    }

    public class Islem
    {
        public static double sayi1;
        public static double sayi2;
        public ConsoleKeyInfo cki;
        public static double sonuc;
        public double Hesapla(double a)
        {
            switch (cki.Key)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    sonuc = Math.Sin(a);
                    break;
                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    sonuc = Math.Cos(a);
                    break;
                case ConsoleKey.D3:
                case ConsoleKey.NumPad3:
                    sonuc = Math.Tan(a);
                    break;
                case ConsoleKey.D4:
                case ConsoleKey.NumPad4:
                    sonuc = Math.Sqrt(a);
                    break;
                case ConsoleKey.D5:
                case ConsoleKey.NumPad5:
                    sonuc = Math.Log(a);
                    break;
                case ConsoleKey.D6:
                case ConsoleKey.NumPad6:
                    for (int i = 0; i < a; i++)
                    {
                        sonuc *= 10;
                    }
                    break;
                case ConsoleKey.D7:
                case ConsoleKey.NumPad7:
                    sonuc = Math.Pow(a, 2);
                    break;
                default:
                    break;
            }
            return 0;
        }
        public double Hesapla(double a, double b)
        {
            switch (cki.Key)
            {
                case ConsoleKey.D8:
                case ConsoleKey.NumPad8:
                    sonuc = Math.Pow(a, b);
                    break;
                case ConsoleKey.D9:
                case ConsoleKey.NumPad9:
                    sonuc = a % b;
                    break;
                case ConsoleKey.Add:
                    sonuc = a + b;
                    break;
                case ConsoleKey.Divide:
                    sonuc = a / b;
                    break;
                case ConsoleKey.Subtract:
                    sonuc = a - b;
                    break;
                case ConsoleKey.Multiply:
                    sonuc = a * b;
                    break;
                default:
                    break;
            }
            return 0;
        }
    }
    public class BilimselIslemler:Islem
    {
        public void TekSayiGir()
        {
            Console.WriteLine("Sayıyı Giriniz");
            sayi1 = int.Parse(Console.ReadLine());
        }
    }
    public class MatematikselIslemler:BilimselIslemler
    {
        public void IkiSayiGir()
        {
            Console.WriteLine("1.Sayıyı Giriniz");
            sayi1 = int.Parse(Console.ReadLine());
            Console.WriteLine("2.Sayıyı Giriniz");
            sayi2 = int.Parse(Console.ReadLine());
        }
    }
    public class VerileriAlma:MatematikselIslemler
    {
        public void VeriAl()
        {
            Console.WriteLine("Aşağıdaki işlemlerden birisini seçiniz");
            Console.WriteLine("(1) - sin\n(2) - cos\n(3) - tan\n(4) - karekök\n(5) - Log\n(6) - 10 üsleri\n(7) - Karesini Hesapla\n(8) - Üssünü al\n(9) - Modunu al\n(+) - Topla\n(-) - Çıkar\n(*) - Çarp\n(/) - Böl");
            cki = Console.ReadKey();
            switch (cki.Key)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                case ConsoleKey.D3:
                case ConsoleKey.NumPad3:
                case ConsoleKey.D4:
                case ConsoleKey.NumPad4:
                case ConsoleKey.D5:
                case ConsoleKey.NumPad5:
                case ConsoleKey.D6:
                case ConsoleKey.NumPad6:
                case ConsoleKey.D7:
                case ConsoleKey.NumPad7:
                    TekSayiGir();
                    Hesapla(sayi1);
                    break;
                case ConsoleKey.D8:
                case ConsoleKey.NumPad8:
                case ConsoleKey.D9:
                case ConsoleKey.NumPad9:
                case ConsoleKey.Add:
                case ConsoleKey.Divide:
                case ConsoleKey.Subtract:
                case ConsoleKey.Multiply:
                    IkiSayiGir();
                    Hesapla(sayi1, sayi2);
                    break;
                default:
                    break;
            }
        }
    }
    public class Yazdırma:Islem
    {
        public void metod()
        {
            Console.WriteLine("Sonuc: {0}",sonuc);
        }
    }
}
