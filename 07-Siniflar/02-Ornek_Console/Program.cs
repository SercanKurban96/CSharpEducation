using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _02_Ornek_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Merhaba");
            //Console.Write("Dünya");

            //string kelime;
            //kelime = "25 Ocak";
            //Console.Write(kelime);

            //int sayi = 5;
            //Console.WriteLine(sayi);


            //Mesaj msj = new Mesaj();
            //msj.metin();


            //Kisiler ks = new Kisiler();

            //ks.kisilistesi(" merhaba");

            //ks.kisilistesi("Sercan Kurban");
            //ks.kisilistesi("Ahmet Karaca");

            //string ads;
            //Console.Write("İsim Girin: ");
            //ads = Console.ReadLine();
            //ks.kisilistesi(ads);


            //DERS SONU ÖRNEK: Konsol ekranında kişinin adını,soyadını,yaşını ve mesleğini tanımlamış olduğunuz metottaki parametrelerle alıp bunları ekrana yazdıran program.

            //DersSonuOrnek ds = new DersSonuOrnek();

            //Console.Write("Adınızı Giriniz: ");
            //string ad = Console.ReadLine();
            //Console.Write("Soyadınızı Giriniz: ");
            //string soyad = Console.ReadLine();
            //Console.Write("Yaşınızı Giriniz: ");
            //int yas = Convert.ToInt16(Console.ReadLine());
            //Console.Write("Mesleğinizi Giriniz: ");
            //string meslek = Console.ReadLine();
            //Console.WriteLine();
            //ds.kisiBilgileri(ad, soyad, yas, meslek);

            //SINIF İÇİNDE GERİYE DEĞER DÖNDÜREN METOTLAR
            //islem isl = new islem();
            //isl.topla(7, 6);
            //isl.topla(4, 5);

            //Console.WriteLine("\n\n\n");

            //isl.kare(6);

            //DERS SONU ÖRNEK: Klavyeden girilen 2 sayıya 4 işlem uygulayan metotları hazırlayın.

            //DersSonuOrnek2 ds2 = new DersSonuOrnek2();
            //Console.Write("1. Sayıyı Giriniz: ");
            //int s1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("2. Sayıyı Giriniz: ");
            //int s2 = Convert.ToInt32(Console.ReadLine());

            //ds2.topla(s1, s2);
            //ds2.cikar(s1, s2);
            //ds2.carp(s1, s2);
            //ds2.bol(s1, s2);


            //CONSTRUCTOR (YAPICI) METOTLAR
            //Ogrenci ogr = new Ogrenci();

            //Ogrenci ogr = new Ogrenci("Sercan - Kültür ve Edebiyat");

            //string blg;
            //Console.Write("Ad - Kulüp: ");
            //blg = Console.ReadLine();
            //Ogrenci ogr = new Ogrenci(blg);


            //DERS SONU ÖRNEK: Ogrenci class'ında yapılan string bilgi kısmını arttırın. (ad soyad yaş ve meslek ekleyin.) Sonra bunları Form kısmında girmiş olduğunuz değerlere göre ekrana yazdıran program.

            //Console.Write("Adınızı Giriniz: ");
            //string ad = Console.ReadLine();
            //Console.Write("Soyadınızı Giriniz: ");
            //string soyad = Console.ReadLine();
            //Console.Write("Yaşınızı Giriniz: ");
            //int yas = Convert.ToInt16(Console.ReadLine());
            //Console.Write("Mesleğinizi Giriniz: ");
            //string meslek = Console.ReadLine();

            //Ogrenci ogr = new Ogrenci(ad, soyad, yas, meslek);


            Kimlik kml = new Kimlik();

            kml.AD = "Sercan";
            kml.SOYAD = "Kurban";
            kml.MEMLEKET = "Erzincan";
            kml.YAS = 29;
            kml.CINSIYET = 'E';

            Console.WriteLine(kml.AD);
            Console.WriteLine(kml.SOYAD);
            Console.WriteLine(kml.MEMLEKET);
            Console.WriteLine(kml.YAS);
            Console.WriteLine(kml.CINSIYET);

            Console.Read();
        }
    }
}
