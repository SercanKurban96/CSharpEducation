using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Ornek_Console
{
    class DersSonuOrnek
    {
        public void kisiBilgileri(string ad, string soyad, int yas, string meslek)
        {
            Console.WriteLine("Adınız: " + ad);
            Console.WriteLine("Soyadınız: " + soyad);
            Console.WriteLine("Yaşınız: " + yas);
            Console.WriteLine("Mesleğiniz: " + meslek);
        }
    }
}
