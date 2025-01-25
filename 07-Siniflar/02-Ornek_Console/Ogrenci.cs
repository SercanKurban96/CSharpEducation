using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Ornek_Console
{
    class Ogrenci
    {
        //CONSTRUCTOR
        //public Ogrenci()
        //{
        //    Console.WriteLine("Ad: Sercan");
        //    Console.WriteLine("Soyad: Kurban");
        //    Console.WriteLine("Meslek: Yazılımcı");
        //}

        public Ogrenci(string bilgi)
        {
            Console.WriteLine("Durum: " + bilgi);
        }

        //DERS SONU ÖRNEK
        public Ogrenci(string ad, string soyad, int yas, string meslek)
        {
            Console.WriteLine("Ad: " + ad);
            Console.WriteLine("Soyad: " + soyad);
            Console.WriteLine("Yaş: " + yas);
            Console.WriteLine("Meslek: " + meslek);
        }
    }
}
