using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Ornek_Console
{
    class DersSonuOrnek2
    {
        public int topla(int s1, int s2)
        {
            int sonuc = s1 + s2;
            Console.WriteLine("Toplam: " + sonuc);
            return sonuc;
        }

        public int cikar(int s1, int s2)
        {
            int sonuc = s1 - s2;
            Console.WriteLine("Fark: " + sonuc);
            return sonuc;
        }

        public int carp(int s1, int s2)
        {
            int sonuc = s1 * s2;
            Console.WriteLine("Çarpım: " + sonuc);
            return sonuc;
        }

        public double bol(double s1, double s2)
        {
            double sonuc = s1 / s2;
            Console.WriteLine("Bölüm: " + sonuc);
            return sonuc;
        }
    }
}
