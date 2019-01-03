using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_HesapMakinesi
{
    class Program
    {
        
    }
    public class Deger
    {
        public int sayi1;
        public string menu;
        public ConsoleKeyInfo cki;
        public string tekcift;
    }
    public class TekDegerAl:Deger
    {
        public int sayi2;
        void metod()
        {
            
        }
    }
    public class IkiDegerAl : TekDegerAl
    {

    }
    public class SecimAl : Deger
    {
        public void Menu()
        {
            Console.WriteLine("Aşağıdaki işlemlerden birisini seçiniz");
            Console.WriteLine("(1) - sin\n(2) - cos\n(3) - tan\n(4) - karekök\n(5) - Log\n(6) - 10 üsleri\n(7) - Karesini Hesapla\n(8) - Üssünü al\n(9) - Modunu al\n(+) - Topla\n(-) - Çıkar\n(*) - Çarp\n(/) - Böl");
            cki = Console.ReadKey();
        }
    }
    public class Secim : Deger
    {
        public string SecimKontrol()
        {
            
            return tekcift;
        }
    }
    public class Bilimselİslemler:Deger
    {

    }
}
