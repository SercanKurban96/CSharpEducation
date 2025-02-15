![image](https://github.com/user-attachments/assets/23c45924-a03e-4e00-9bea-aeea58f63d75)# <img height="50" src="https://user-images.githubusercontent.com/25181517/121405384-444d7300-c95d-11eb-959f-913020d3bf90.png"> Uygulama Geliştirerek C# Öğrenin: A'dan Z'ye Eğitim Seti
👋 Merhabalar, oluşturmuş olduğum bu repo, Murat Yücedağ hocamızın Udemy üzerinden hazırlamış olduğu Uygulama Geliştirerek C# Öğrenin: A'dan Z'ye Eğitim Seti süresince tamamlamış olduğum projeleri içermektedir. Bu eğitimde C# Windows Form Uygulaması'ndan Temel Araç Kullanımları ile başlayıp OOP ile N Katmanlı Mimari'de proje geliştirmeye kadar anlatılmaktadır.
<br><hr>
# 🖥️ Bölüm 1 - Temel Araç Kullanımları
Görsel programlamada arayüz oluşturabilmek için ihtiyacımız olan bileşenlerdir. C# formda araçlar araç kutusu (toolbox) üzerinden eklenir.
<br><br>
<b>⚙️ Button: </b> Olayları gerçekleştirmek için kullanılan tetikleme aracıdır. Bir lambayı açıp kapatmak için ihtiyacımız olan düğme aslında bir butondur.<br><br>
<b>⚙️ Label: </b> Formda özellikle açıklamalar için kullanılan, etiket görevi gören araçtır. Amaç ilgili bileşen hakkında bilgi vermektir.<br><br>
<b>⚙️ TextBox: </b>Veri girişi yapmak için kullanılan araçtır. Yapı olarak Label aracının özelliklerine çok benzer.<br><br>
<b>⚙️ ComboBox: </b>Çoklu seçim kutusu olarak kullanılan araçtır. Bir listede istenilen değerlerden herhangi birini seçtirmek için kullanılır.<br><br>
<b>⚙️ ListBox: </b>Verilerin listelenmesi için kullanılan araçtır. Yapı olarak ComboBox aracına benzer. Listelenecek veriler <<items.add>> komutu kullanılarak ListBox aracına yansıtılır.<br><br>
<b>⚙️ MaskedTextBox: </b>Maskeli metin kutusu anlamına gelir. TextBox aracının bazı nitelikler alan formatıdır. Telefon numarası, TC kimlik numarası, posta kodu gibi formatlarda kullanılabilir.<br><br>
<b>⚙️ PictureBox: </b>Formda resim kutusu olarak kullanılan araçtır. Amaç forma resim dosyaları ekleyip görüntüleyebilmektir.<br><br>
<b>⚙️ DateTimePicker: </b>Kullanıcının bir tarih ve saat seçmesine ve bu tarih ve saati belirtilen biçimde görüntülemesine izin vermek için kullanılır. DateTimePicker veri doğrulama işleminin büyük bir kısmını otomatik olarak işlediğinden tarih ve saatlerle çalışmayı kolaylaştırır.<br><br>
<b>⚙️ CheckBox: </b>Kontrol kutusu anlamına gelir. Çoklu seçim durumlarında kullanılmaktadır.<br><br>
<b>⚙️ RadioButton: </b>Çoklu seçim işlemlerinde sadece 1 tane değer seçimine izin veren araçtır. Form üzerinde bulunan CheckBox araçlarının tamamı seçilebilirken, RadioButton ise aynı anda sadece 1 tane seçilebilmektedir.<br><br>
<b>⚙️ RichTextBox: </b>Zengin metin kutusu denetimini temsil eder. Kullanıcı metin girebilir ve düzenleyebilir. Standart TextBox denetimden daha gelişmiş biçimlendirme özellikleri de sağlar.<br><br>
<b>⚙️ Panel: </b>Koleksiyonları gruplandırmak için kullanılır. Çoklu seçimlerden panelin içinde yer alan RadioButton ile panelde bulunmayan RadioButton araçları aynı anda seçebilme özelliğini sağlar.<br><br>
<b>⚙️ GroupBox: </b>Araçları gruplandırmak için kullanılan form aracıdır. Amaç özellikle birbiriyle ilişkili olan bileşenleri bir arada tutabilmektir.<br><br>

<hr>

# 🖥️ Bölüm 2 - Değişkenler
C#'ta değişkenler, verileri saklamak için kullanılan isimlendirilmiş bellek alanlarıdır. Değişkenler belirli bir veri tipine sahiptir ve o veri tipine uygun değerler alabilirler.
<br>

## C#'ta Temel Veri Türleri ve Değişkenler
📌 <b>1. Tamsayı Türleri</b><br>
📍 byte (0 - 255)<br>
📍 sbyte (-128 ile 127)<br>
📍 short (-32,768 ile 32,767)<br>
📍 ushort (0 ile 65,535)<br>
📍 int (-2,147,483,648 ile 2,147,483,647)<br>
📍 uint (0 ile 4,294,967,295)<br>
📍 long (-9 kentilyon ile +9 kentilyon)<br>
📍 ulong (0 ile çok büyük bir pozitif sayı)<br>

📌 <b>2. Ondalıklı Sayılar</b><br>
📍 float (Tek hassasiyetli, 7 basamağa kadar)<br>
📍 double (Çift hassasiyetli, 15-16 basamağa kadar)<br>
📍 decimal (28-29 basamağa kadar, finansal işlemler için uygun)<br>

📌 <b>3. Karakter ve Metin Türleri</b><br>
📍 char (Tek bir karakter, örneğin 'A')<br>
📍string (Metin verileri, örneğin "Merhaba Dünya")<br>

📌 <b>4. Mantıksal Tür</b><br>
📍bool (Sadece true veya false değerlerini alır)<br>

📌 <b>5. Nesne ve Diğer Türler</b><br>
📍 object (Tüm türlerin atasıdır, her türlü veri saklanabilir)<br>
📍 var (Türü derleyici tarafından belirlenen değişken)<br>
📍 dynamic (Çalışma zamanında belirlenen tür)<br>

## Değişken Tanımlama Örnekleri
int sayi = 10;<br>
double pi = 3.14;<br>
char harf = 'A';<br>
string mesaj = "Merhaba";<br>
bool dogruMu = true;<br>
var otomatikBelirlenen = 42;  // int olarak algılanır<br>

✅ C#’ta değişken isimleri harfle veya _ (alt çizgi) ile başlamalıdır, rakamla başlayamaz. Ayrıca, büyük-küçük harf duyarlıdır (sayi ile Sayi farklı değişkenlerdir).<br><br>

<hr>

# 🖥️ Bölüm 3 - Karar Yapıları
C#'ta karar yapıları, programın belirli koşullara göre farklı yollar izlemesini sağlar. Genellikle koşul ifadeleri (if, switch gibi) ile gerçekleştirilir.<br><br>

## 📌 1. if - else Karar Yapısı
Belirli bir koşul doğru (true) ise bir kod bloğu çalıştırılır, aksi takdirde diğer kod bloğu çalıştırılır.<br>

### ⚙️ Kullanım Örnekleri
int sayi = 10;<br>

if (sayi > 0)<br>
{<br>
    Console.WriteLine("Sayı pozitiftir.");<br>
}<br>
else<br>
{<br>
    Console.WriteLine("Sayı negatiftir veya sıfırdır.");<br>
}<br>

### ⚙️ if - else if - else Kullanımı
int not = 85;<br>

if (not >= 90)<br>
{<br>
    Console.WriteLine("Harf Notu: A");<br>
}<br>
else if (not >= 80)<br>
{<br>
    Console.WriteLine("Harf Notu: B");<br>
}<br>
else if (not >= 70)<br>
{<br>
    Console.WriteLine("Harf Notu: C");<br>
}<br>
else<br>
{<br>
    Console.WriteLine("Harf Notu: F");<br>
}<br>

## 📌 2. switch Karar Yapısı
Bir değişkenin değerine bağlı olarak farklı kod bloklarını çalıştırmak için kullanılır.<br>
### ⚙️ Kullanım Örneği
int gun = 3;

switch (gun)<br>
{<br>
    case 1:<br>
        Console.WriteLine("Pazartesi");<br>
        break;<br>
    case 2:<br>
        Console.WriteLine("Salı");<br>
        break;<br>
    case 3:<br>
        Console.WriteLine("Çarşamba");<br>
        break;<br>
    default:<br>
        Console.WriteLine("Geçersiz gün!");<br>
        break;<br>
}<br>

✅ break komutu, her durumu sonlandırır. Eğer break konmazsa, sonraki case blokları da çalışır.

## 📌 3. Ternary Operator (? :)
Tek satırda basit bir if-else işlemi yapmayı sağlar.<br>
### ⚙️ Kullanım Örneği
int sayi = 15;<br>
string sonuc = (sayi % 2 == 0) ? "Çift Sayı" : "Tek Sayı";<br>
Console.WriteLine(sonuc);<br>
✅Eğer sayi çiftse "Çift Sayı" yazdırır, aksi halde "Tek Sayı" yazdırır.<br>br>

<hr>

# 🖥️ Bölüm 4 - Döngüler
C#'ta döngüler, belirli bir kod bloğunun tekrarlı olarak çalışmasını sağlar. Döngüler, belirli bir koşul doğru olduğu sürece çalışmaya devam eder.<br>

## 📌 1. for Döngüsü
Belirli bir sayıda işlem yapmak için kullanılır. Sayaç tabanlıdır ve genellikle kaç kere döneceği önceden bilinir.<br>
for (int i = 1; i <= 5; i++)<br>
{<br>
    Console.WriteLine("Merhaba! " + i);<br>
}<br>

### ⚙️ Çalışma Mantığı
📍 int i = 1; → Döngü sayacı başlatılır.<br>
📍 i <= 5; → Koşul sağlandıkça döngü devam eder.<br>
📍 i++ → Döngü her çalıştığında i artırılır.<br>

✅ Çıktı:<br>
Merhaba! 1  <br>
Merhaba! 2  <br>
Merhaba! 3  <br>
Merhaba! 4  <br>
Merhaba! 5  <br>

## 📌 2. while Döngüsü
Koşul doğru (true) olduğu sürece döner.<br>
### ⚙️ Kullanımı:
int sayi = 1;<br>

while (sayi <= 5)<br>
{<br>
    Console.WriteLine("Sayı: " + sayi);<br>
    sayi++;<br>
}<br>
✅ Çıktı:<br>
Sayı: 1  <br>
Sayı: 2  <br>
Sayı: 3  <br>
Sayı: 4  <br>
Sayı: 5  <br>

💯 Not: Eğer döngü koşulu hiç sağlanmazsa while bloğu çalışmaz.<br>

## 📌 3. do-while Döngüsü
do-while, şartı en son kontrol ettiği için en az bir kez çalışır.<br>
### ⚙️ Kullanımı:
int sayi = 1;
<br>
do<br>
{<br>
    Console.WriteLine("Sayı: " + sayi);<br>
    sayi++;<br>
}<br>
while (sayi <= 5);<br>
✅ Çıktı:<br>
Sayı: 1  <br>
Sayı: 2  <br>
Sayı: 3  <br>
Sayı: 4  <br>
Sayı: 5  <br>

❗ Farkı: Koşul en sonda kontrol edilir, bu yüzden döngü en az bir defa çalışır.<br>

## 📌 4. foreach Döngüsü
Diziler (array) veya koleksiyonlar üzerinde elemanları tek tek almak için kullanılır.<br>
### ⚙️ Kullanımı:
string[] meyveler = { "Elma", "Armut", "Muz", "Çilek" };<br>
<br>
foreach (string meyve in meyveler)<br>
{<br>
    Console.WriteLine(meyve);<br>
}<br>
✅ Çıktı:<br>
Elma  <br>
Armut  <br>
Muz  <br>
Çilek  <br>
<br>
💯 Not: foreach, elemanları değiştirmeye izin vermez, sadece okumak için kullanılır.<br>

## 📌 5. break ve continue Kullanımı
Bazı durumlarda döngüyü durdurmak (break) veya belirli bir adımı atlamak (continue) gerekebilir.<br>

### ⚙️ break Kullanımı (Döngüyü Sonlandırır)
for (int i = 1; i <= 10; i++)<br>
{<br>
    if (i == 5)<br>
    {<br>
        break; // 5 olduğunda döngüden çıkar<br>
    }<br>
    Console.WriteLine(i);<br>
}<br>
✅ Çıktı:<br>
1  <br>
2  <br>
3  <br>
4  <br>

### ⚙️ continue Kullanımı (Atlama Yapar)
for (int i = 1; i <= 5; i++)<br>
{<br>
    if (i == 3)<br>
    {<br>
        continue; // 3'ü atla, devam et<br>
    }<br>
    Console.WriteLine(i);<br>
}<br>
✅ Çıktı:<br>
1  <br>
2  <br>
4  <br>
5  <br>

<hr>

# 🖥️ Bölüm 5 - Diziler
C#'ta diziler (Arrays), aynı türdeki birden fazla veriyi tek bir değişkende saklamaya yarayan veri yapılarıdır.<br>

## 📌 1. Dizi Tanımlama ve Kullanımı
C#’ta dizi [] (köşeli parantezler) ile tanımlanır.<br>
### ⚙️ Örnek
int[] sayilar = new int[5]; // 5 elemanlı bir dizi oluşturuldu
sayilar[0] = 10;<br>
sayilar[1] = 20;<br>
sayilar[2] = 30;<br>
sayilar[3] = 40;<br>
sayilar[4] = 50;<br>
<br>
Console.WriteLine(sayilar[2]); // 30<br><br>

💯 Diziler sıfırdan (0) başlar. İlk eleman sayilar[0], ikinci eleman sayilar[1] vb.

## 📌 2. Dizi Tanımlamanın Farklı Yolları
1️⃣ Önceden boyut belirtme (Sonradan değer atama):<br><br>
int[] dizi = new int[3]; // 3 elemanlı dizi<br>
dizi[0] = 5;<br>
dizi[1] = 10;<br>
dizi[2] = 15;<br><br>

2️⃣ Tanımlarken doğrudan değer verme:<br><br>
int[] dizi = { 5, 10, 15, 20 };<br><br>

3️⃣ new anahtar kelimesi ile kısa kullanım:<br><br>
int[] dizi = new int[] { 5, 10, 15, 20 };<br><br>

## 📌 3. Diziler Üzerinde İşlemler
### ⚙️ for Döngüsü ile Dizi Kullanımı
int[] sayilar = { 1, 2, 3, 4, 5 };<br>
<br>
for (int i = 0; i < sayilar.Length; i++)<br>
{<br>
    Console.WriteLine("Eleman: " + sayilar[i]);<br>
}<br>
✅ Çıktı:<br>
Eleman: 1  <br>
Eleman: 2  <br>
Eleman: 3  <br>
Eleman: 4  <br>
Eleman: 5  <br><br>
💯 sayilar.Length, dizinin uzunluğunu döndürür.<br>

### ⚙️ foreach Döngüsü ile Dizi Kullanımı
string[] meyveler = { "Elma", "Muz", "Çilek" };<br>
<br>
foreach (string meyve in meyveler)<br>
{<br>
    Console.WriteLine(meyve);<br>
}<br>
✅ Çıktı:<br>
Elma  <br>
Muz  <br>
Çilek  <br>
💯 Not: foreach, elemanları değiştirmek için kullanılmaz, sadece okumaya izin verir.<br><br>

## 📌 4. Çok Boyutlu Diziler
C# dizileri tek boyutlu (int[]), iki boyutlu (int[,] - matris) veya daha fazla boyutlu olabilir.<br><br>

### ⚙️ İki Boyutlu Dizi (Matris)
int[,] matris = {<br>
    { 1, 2, 3 },<br>
    { 4, 5, 6 },<br>
    { 7, 8, 9 }<br>
};<br>
<br>
Console.WriteLine(matris[1, 2]); // 2. satır, 3. sütun -> 6<br>
✅ Çıktı: 6 <br><br>

## 📌 5. Array Sınıfı ile Dizi Metotları
C#’ta diziler üzerinde işlem yapmak için Array sınıfı kullanılır.<br>
### ⚙️ Örnekler
int[] sayilar = { 10, 5, 20, 15 };<br>
<br>
// Diziyi küçükten büyüğe sıralama<br>
Array.Sort(sayilar);<br>
<br>
// Diziyi ters çevirme<br>
Array.Reverse(sayilar);<br>
<br>
// Belirli bir elemanı arama (varsa index döndürür, yoksa -1)<br>
int index = Array.IndexOf(sayilar, 15);<br>
<br>
// Dizinin tüm elemanlarını temizleme (0'a çevirir)<br>
Array.Clear(sayilar, 0, sayilar.Length);<br>

<hr>

# 🖥️ Bölüm 6 - Metotlar
C#'ta metotlar, belirli bir görevi yerine getiren kod bloklarıdır. Metotlar sayesinde kod tekrarını önleyebilir, kodu daha düzenli ve okunabilir hale getirebiliriz.<br>

## 📌 1. Metot Tanımlama ve Kullanımı
Bir metot geri_dönüş_tipi, metot_adı, parametreler ve gövde içerir.<br>
### ⚙️ Temel Metot Tanımı:
erişim_belirteci dönüş_tipi MetotAdi(parametreler)<br>
{<br>
    // Metot içeriği<br>
    return değer; // (Eğer dönüş tipi void değilse)<br>
}<br>
<br>
### ⚙️ Örnek: Parametresiz ve Geri Dönüş Değeri Olmayan Metot
using System;<br>
<br>
class Program<br>
{<br>
    static void SelamVer()<br>
    {<br>
        Console.WriteLine("Merhaba, hoş geldiniz!");<br>
    }<br>
<br>
    static void Main()<br>
    {<br>
        SelamVer(); // Metot çağrılıyor<br>
    }<br>
}<br>
<br>
✅ Çıktı:<br>
Merhaba, hoş geldiniz!<br>
💯 Not: void metodu bir değer döndürmez.<br><br>

## 📌 2. Parametreli Metotlar
Metotlara parametre ekleyerek dinamik hale getirebiliriz.<br>

static void Topla(int sayi1, int sayi2)<br>
{<br>
    int toplam = sayi1 + sayi2;<br>
    Console.WriteLine("Toplam: " + toplam);<br>
}<br>
<br>
static void Main()<br>
{<br>
    Topla(5, 10);  // Çıktı: Toplam: 15<br>
}<br>
💯 Not: sayi1 ve sayi2, metoda gönderilen parametrelerdir.<br><br>

## 📌 3. Geri Değer Döndüren Metotlar (return)
Bazı metotlar bir sonuç döndürmelidir. Bu tür metotlarda void yerine bir veri türü (örneğin int, string, double) kullanılır.<br><br>

static int KareAl(int sayi)<br>
{<br>
    return sayi * sayi;<br>
}<br>
<br>
static void Main()<br>
{<br>
    int sonuc = KareAl(4);<br>
    Console.WriteLine("Sonuç: " + sonuc);  // Çıktı: Sonuç: 16<br>
}<br><br>

## 📌 4. Metotlarda ref ve out Kullanımı
C#’ta metotlara referans (ref) veya çıkış (out) parametreleri göndererek değişkenlerin değerlerini değiştirebiliriz.<br>

### ⚙️ ref Kullanımı (Mevcut değeri değiştirme)
static void DegerArttir(ref int sayi)<br>
{<br>
    sayi += 10;<br>
}<br>
<br>
static void Main()<br>
{<br>
    int x = 5;<br>
    DegerArttir(ref x);<br>
    Console.WriteLine("Yeni Değer: " + x);  // Çıktı: Yeni Değer: 15<br>
}<br>
<br>
💯 Not: ref kullanırken değişkenin önceden atanmış olması gerekir.<br><br>

### ⚙️ out Kullanımı (Değer atamak için)
out, metoda veri göndermek yerine metottan veri almak için kullanılır.<br><br>
static void Hesapla(int a, int b, out int toplam, out int fark)<br>
{<br>
    toplam = a + b;<br>
    fark = a - b;<br>
}<br>
<br>
static void Main()<br>
{<br>
    int t, f;<br>
    Hesapla(10, 4, out t, out f);<br>
    Console.WriteLine("Toplam: " + t + ", Fark: " + f);  // Çıktı: Toplam: 14, Fark: 6<br>
}<br>
<br>
💯 Not: out parametrelerine metot içinde değer atanması zorunludur.<br><br>

## 📌 5. Aşırı Yükleme (Method Overloading)
Aynı isimde fakat farklı parametre tipleri veya sayısına sahip metotlar oluşturabiliriz.<br><br>

static int Topla(int a, int b)<br>
{<br>
    return a + b;<br>
}<br>
<br>
static double Topla(double a, double b)<br>
{<br>
    return a + b;<br>
}<br>
<br>
static void Main()<br>
{<br>
    Console.WriteLine(Topla(5, 10));       // Çıktı: 15 (int)<br>
    Console.WriteLine(Topla(4.5, 2.5));    // Çıktı: 7 (double)<br>
}<br>
<br>
💯 Not: Derleyici, parametrelere göre hangi metodu çağıracağını belirler.<br><br>

## 📌 6. Varsayılan (Default) Parametreler
Metotlara varsayılan değerler atanabilir.<br><br>

static void MesajGoster(string mesaj = "Merhaba!")<br>
{<br>
    Console.WriteLine(mesaj);<br>
}<br>
<br>
static void Main()<br>
{<br>
    MesajGoster();               // Çıktı: Merhaba!<br>
    MesajGoster("Hoş geldin!");  // Çıktı: Hoş geldin!<br>
}<br>
<br>

## 📌 7. Metotlar ve static Kullanımı
static metotlar, sınıf örneği oluşturmadan çağrılabilir.<br><br>
### ⚙️ Örnek
static void Yazdir() { Console.WriteLine("Merhaba!"); }<br>

❗ <strong>Eğer bir metot static değilse, onu kullanabilmek için sınıftan bir örnek (instance) oluşturmalısınız.</strong><br><br>

class HesapMakinesi<br>
{<br>
    public int Carp(int a, int b)<br>
    {<br>
        return a * b;<br>
    }<br>
}<br>
<br>
static void Main()<br>
{<br>
    HesapMakinesi h = new HesapMakinesi();  // Nesne oluşturuldu<br>
    Console.WriteLine(h.Carp(3, 4));        // Çıktı: 12<br>
}<br>
<br>

<hr>

# 🖥️ Bölüm 7 - Sınıflar
C#’ta sınıflar (classes), nesne tabanlı programlamanın (OOP - Object Oriented Programming) temel yapı taşıdır. Veri (değişkenler) ve işlevleri (metotlar) bir araya getiren bir yapıdır.<br><br>

## 📌 1. Sınıf Tanımlama ve Nesne Kullanımı
Bir sınıf tanımlamak için class anahtar kelimesi kullanılır.<br><br>
### ⚙️ Temel Sınıf Tanımlama
class Araba<br>
{<br>
    public string marka;<br>
    public int yil;<br>
    <br>
    public void BilgiGoster()<br>
    {<br>
        Console.WriteLine("Marka: " + marka + ", Yıl: " + yil);<br>
    }<br>
}<br>
<br>

📌 Sınıfın içinde:<br>
✅ <b>Değişkenler (Fields):</b> marka, yil gibi özellikler saklanır.<br>
✅ <b>Metotlar (Methods):</b> BilgiGoster() gibi işlemler yapılır.<br><br>

## 📌 2. Nesne (Object) Oluşturma
Bir sınıfı kullanabilmek için <strong>ondan bir nesne türetmemiz gerekir.</strong><br><br>

class Program<br>
{<br>
    static void Main()<br>
    {<br>
        // Araba sınıfından bir nesne oluştur<br>
        Araba benimArabam = new Araba();<br>
        <br>
        // Özellikleri ata<br>
        benimArabam.marka = "Toyota";<br>
        benimArabam.yil = 2022;<br>
<br>
        // Metodu çağır<br>
        benimArabam.BilgiGoster();<br>
    }<br>
}<br>
<br>
✅ Çıktı:<br>
Marka: Toyota, Yıl: 2022<br>
💯 Not: benimArabam nesnesi Araba sınıfının bir örneğidir (instance).<br><br>

## 📌 3. Yapıcı Metotlar (Constructors)

Yapıcı metotlar (constructor), sınıf çağrıldığında otomatik olarak çalışır.<br>
❗ <strong>Metodun adı, sınıf adıyla aynı olmalıdır.</strong><br><br>
### ⚙️ Yapıcı Metot Kullanımı

class Araba<br>
{<br>
    public string marka;<br>
    public int yil;<br>
<br>
    // Yapıcı Metot (Constructor)<br>
    public Araba(string _marka, int _yil)<br>
    {<br>
        marka = _marka;<br>
        yil = _yil;<br>
    }<br>
<br>
    public void BilgiGoster()<br>
    {<br>
        Console.WriteLine("Marka: " + marka + ", Yıl: " + yil);<br>
    }<br>
}<br>
<br>
class Program<br>
{<br>
    static void Main()<br>
    {<br>
        Araba araba1 = new Araba("BMW", 2021);<br>
        araba1.BilgiGoster();  // Çıktı: Marka: BMW, Yıl: 2021<br>
    }<br>
}<br>
<br>
✅ Avantajı: Nesne oluştururken değerleri doğrudan atayabiliriz.<br><br>

## 📌 4. Kapsülleme (Encapsulation)
💯 Değişkenleri private yaparak doğrudan erişimi engelleyebiliriz.<br>
Erişimi kontrol etmek için public get/set metotları (property'ler) kullanılır.<br><br>

class Kisi<br>
{<br>
    private string isim;<br>
<br>
    // İsmi ayarlayan metot<br>
    public void SetIsim(string yeniIsim)<br>
    {<br>
        isim = yeniIsim;<br>
    }<br>
<br>
    // İsmi döndüren metot<br>
    public string GetIsim()<br>
    {<br>
        return isim;<br>
    }<br>
}<br>
<br>
class Program<br>
{<br>
    static void Main()<br>
    {<br>
        Kisi kisi = new Kisi();<br>
        kisi.SetIsim("Ahmet");<br>
        Console.WriteLine(kisi.GetIsim());  // Çıktı: Ahmet<br>
    }<br>
}<br>
<br>

📍 Amaç: Değişkenlere doğrudan erişimi sınırlandırmak ve güvenliği sağlamak.<br><br>

## 📌 5. Özellikler (Properties) Kullanımı
C#’ta get ve set ile kapsülleme daha kolay yapılabilir.<br><br>
### ⚙️ Property Kullanımı
class Araba<br>
{<br>
    private string _marka;<br>
<br>
    public string Marka<br>
    {<br>
        get { return _marka; }    // Değeri döndür<br>
        set { _marka = value; }   // Değer ata<br>
    }<br>
}<br>
<br>
class Program<br>
{<br>
    static void Main()<br>
    {<br>
        Araba araba = new Araba();<br>
        araba.Marka = "Mercedes";  // set çalışır<br>
        Console.WriteLine(araba.Marka);  // get çalışır, Çıktı: Mercedes<br>
    }<br>
}<br>
<br>

📍 value, set içinde gönderilen değeri temsil eder.

## 📌 6. Kalıtım (Inheritance) - Miras Alma
Bir sınıf, başka bir sınıftan özellikleri ve metotları miras alabilir.<br><br>

### ⚙️ : (extends) Kullanımı
class Hayvan<br>
{<br>
    public void SesCikar()<br>
    {<br>
        Console.WriteLine("Hayvan sesi çıkarıyor...");<br>
    }<br>
}<br>
<br>
// `Kedi` sınıfı `Hayvan` sınıfından türetilmiştir.<br>
class Kedi : Hayvan<br>
{<br>
    public void Miyavla()<br>
    {<br>
        Console.WriteLine("Miyav Miyav!");<br>
    }<br>
}<br>
<br>
class Program<br>
{<br>
    static void Main()<br>
    {<br>
        Kedi kedi = new Kedi();<br>
        kedi.SesCikar();  // Miras alınan metot<br>
        kedi.Miyavla();    // Kendi metodu<br>
    }<br>
}<br>
<br>
✅ Çıktı:<br>
Hayvan sesi çıkarıyor...<br>
Miyav Miyav!<br>
<br>
💯 Not: Kedi sınıfı, Hayvan sınıfının tüm özelliklerini alır ve kendine özgü eklemeler yapabilir.<br><br>

## 📌 7. Soyut Sınıflar (abstract)
Bazı sınıflar tamamlanmamış (soyut) olabilir. Bunlar abstract ile tanımlanır.<br><br>
abstract class Sekil<br>
{<br>
    public abstract void Ciz(); // Soyut metot (gövdesiz)<br>
}<br>
<br>
class Daire : Sekil<br>
{<br>
    public override void Ciz()<br>
    {<br>
        Console.WriteLine("Daire çizildi.");<br>
    }<br>
}<br>
<br>
class Program<br>
{<br>
    static void Main()<br>
    {<br>
        Daire daire = new Daire();<br>
        daire.Ciz();  // Çıktı: Daire çizildi.<br>
    }<br>
}<br>
<br>
💯 Not:<br>
✅ Soyut sınıflardan doğrudan nesne oluşturulamaz.<br>
✅ Alt sınıflar, override ile eksik metotları tamamlamak zorundadır.<br><br>

## 📌 8. Arayüzler (interface)
Arayüzler, sınıfların uyması gereken kuralları belirler.<br><br>
interface IArac<br>
{<br>
    void HareketEt();<br>
}<br>
<br>
class Araba : IArac<br>
{<br>
    public void HareketEt()<br>
    {<br>
        Console.WriteLine("Araba gidiyor...");<br>
    }<br>
}<br>
<br>
class Program<br>
{<br>
    static void Main()<br>
    {<br>
        Araba araba = new Araba();<br>
        araba.HareketEt();  // Çıktı: Araba gidiyor...<br>
    }<br>
}<br>
<br>
💯 Not:<br>
✅ Arayüzler sadece metot imzaları içerir.<br>
✅ Sınıflar, interface içindeki metotları uygulamak zorundadır.<br><br>

<hr>

# 🖥️ Bölüm 8 - Ekstra Araçlar
Bu bölümde 4 tane araç kullanılmıştır. Bunlar MenuStrip, WebBrowser, Chart ve ContextMenuStrip araçlarıdır.<br><br>

## 📌 1. MenuStrip (Menü Çubuğu)
MenuStrip, Windows Forms uygulamalarında üst kısma eklenen menü çubuğudur. (Dosya, Düzen, Yardım gibi seçenekler içerebilir.)<br><br>
### ⚙️ MenuStrip Kullanımı
1️⃣ Visual Studio’da bir Windows Forms uygulaması açın.<br>
2️⃣ Toolbox’tan MenuStrip bileşenini forma sürükleyin.<br>
3️⃣ Menü öğelerini (Dosya, Düzen vb.) ekleyin.<br>
4️⃣ Kod ile olayları (Click vb.) bağlayın.<br>

![image](https://github.com/user-attachments/assets/1d617eca-124b-4c0f-9cbb-2c9d0b12c5f7)<br>
Burada Kategoriler bölümünde filmin türlerini belirledik. Buradan seçtiğimiz değerlere göre işlemler yapabiliriz. Burada ekstradan WebBrowser aracını kullandık. WebBrowser aracı bir sonraki maddede anlatılacaktır. Buradan seçtiğimiz filme göre videonun fragmanı gelmektedir.<br><br>
![image](https://github.com/user-attachments/assets/29f53130-8cf4-4177-b129-6a3a6a0d9c3a)<br>
Buradaki renkler kısmı seçtiğimiz renge göre formun arka planını değiştirir.<br><br>
![image](https://github.com/user-attachments/assets/b4eb8e39-86ec-487f-8fe8-3fae035a9893)<br>
Burada hakkımızda kısmına tıklandığında proje ile ilgili bilgiyi, çıkış seçeneğine tıkladığımızda program kapanır.<br><br>

## 📌 2. WebBrowser (Web Tarayıcı)
WebBrowser, Windows Forms içinde web sayfalarını görüntülemek için kullanılır.<br><br>

### ⚙️ WebBrowser Kullanımı
1️⃣ Toolbox’tan WebBrowser bileşenini forma ekleyin.<br>
2️⃣ Örneğin bir buton ekleyip, tarayıcıya bir sayfa yükleyin.<br>

![image](https://github.com/user-attachments/assets/a5905f3b-ea73-4418-a127-d9a41254ada5)
<br>
Burada bir tane WebBrowser aracı ekledik. Kategoriler bölümünden herhangi bir kategoriye tıklayarak ilgili filme tıkladığımızda o filme ait fragmanı gelecektir.<br>
![image](https://github.com/user-attachments/assets/0f097d1b-f448-4152-a6f5-a3230d312db8)
<br>
Örnek kod kullanımı bu şekildedir.<br><br>

## 📌 3. Chart (Grafik Çizme)
Chart bileşeni, verileri grafiksel olarak göstermek için kullanılır.<br><br>

### ⚙️ Chart Kullanımı
1️⃣ Toolbox’tan Chart bileşenini forma ekleyin.<br>
2️⃣ Verileri ve grafik türünü belirleyin.<br>

![image](https://github.com/user-attachments/assets/b497626c-597c-4c44-8416-c183fcbce1eb)
<br>
![image](https://github.com/user-attachments/assets/f427ba7f-dec9-47c0-8ff4-9b0d05a694af)
Örnek kod kullanımı bu şekildedir.<br><br>

## 📌 4. ContextMenuStrip (Sağ Tık Menüsü)
ContextMenuStrip, sağ tıklama menüsü (bağlam menüsü) oluşturmak için kullanılır.<br><br>
### ⚙️ ContextMenuStrip Kullanımı
1️⃣ Toolbox’tan ContextMenuStrip bileşenini ekleyin.<br>
2️⃣ Menü seçenekleri belirleyin.<br>
3️⃣ Menüyü bir nesneye bağlayın.<br>
<br>
![image](https://github.com/user-attachments/assets/07c4abe8-9a78-4389-8b35-23a9f39cd7ef)
<br>
Form'a eklediğimizde herhangi bir şey gözükmez ancak Form'un Properties kısmından ContextMenuStrip'e gelinip contextMenuStrip1 olarak belirliyoruz.<br>

![image](https://github.com/user-attachments/assets/0866a27b-0a78-4399-80bd-e74af2d0c31c)
<br>
Programı çalıştırdığımız zaman fareye sağ tıkladığımızda buradaki menüler gözükecektir.<br><br>

<hr>

# 🖥️ Bölüm 9 - Ekstra Yapılar
Bu bölümde Random kullanımı, CAPTCHA oluşturma, formlar arası veri taşıma, Point, Enum, Matematik Fonksiyonları ve Dinamik Araçlar konuları içermektedir.<br><br>

## 📌 1. Random (Rastgele Sayı Üretme)
C#’ta rastgele sayı üretmek için Random sınıfı kullanılır.<br><br>
### ⚙️ Rastgele Sayı Üretme
Random rastgele = new Random();<br>
int sayi = rastgele.Next(1, 101); // 1 ile 100 arasında sayı üretir<br>
Console.WriteLine("Rastgele Sayı: " + sayi);<br><br>
💯 Not: Next(min, max), min dahil, max hariç değer üretir.<br><br>

## 📌 2. Captcha (Güvenlik Kodu)
Captcha, botları engellemek için kullanılan bir doğrulama yöntemidir.<br><br>
### ⚙️ Basit Captcha Üretme
Random rnd = new Random();<br>
string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";<br>
string captcha = "";<br>
<br>
for (int i = 0; i < 6; i++)<br>
{<br>
    captcha += chars[rnd.Next(chars.Length)];<br>
}<br>
<br>
Console.WriteLine("Captcha: " + captcha);<br>
<br>
✅ Çıktı:<br>
Captcha: X9B2MZ
<br><br>

## 📌 3. Formlar Arası Veri Taşıma
Windows Forms’ta bir formdan diğerine veri taşımak için konstrüktör veya public değişkenler kullanılabilir.<br><br>
### ⚙️ Örnek Kullanım
2 tane Form açtığımızı düşünelim. İlk formumuza bir tane buton eklediğimiz zaman butona tıkladığımızda ikinci bir forma gitmesini sağlayan kodlar aşağıdaki gibidir.<br><br>

Form2 fr = new Form2();<br>
fr.Show();<br>
this.Hide();<br><br>

## 📌 4. Point (Koordinat Kullanımı)
Point, bir nesnenin X ve Y koordinatlarını tutar.<br><br>
### ⚙️ Örnek Kullanım
Point konum = new Point();<br>
konum.X = 300;<br>
konum.Y = 200;<br>
pictureBox1.Location = konum;<br><br>

💯 pictureBox1, (300, 200) konumuna yerleşir.<br><br>

## 📌 5. Enum (Sabit Değerler Tanımlama)
Enum, sabit değerler içeren bir veri tipidir.<br><br>
### ⚙️ Enum Tanımlama
enum Gunler { Pazartesi, Salı, Çarşamba, Perşembe, Cuma, Cumartesi, Pazar }<br>
<br>
Gunler bugun = Gunler.Çarşamba;<br>
Console.WriteLine("Bugün: " + bugun);<br><br>
✅ Çıktı:<br>
Bugün: Çarşamba<br><br>

## 📌 6. Matematik Fonksiyonları
C#’ta Math sınıfı birçok matematiksel işlem sağlar.<br><br>
### ⚙️ Kullanım Örnekleri
double sayi = 25.6;<br><br>

Console.WriteLine(Math.Abs(-10));   // Mutlak değer: 10<br>
Console.WriteLine(Math.Sqrt(16));   // Karekök: 4<br>
Console.WriteLine(Math.Pow(2, 3));  // Üs alma: 8<br>
Console.WriteLine(Math.Round(sayi)); // Yuvarlama: 26<br>
Console.WriteLine(Math.Floor(sayi)); // Aşağı yuvarla: 25<br>
Console.WriteLine(Math.Ceiling(sayi)); // Yukarı yuvarla: 26<br><br>

## 📌 7. Dinamik Araçlar (Runtime Controls)
Dinamik araçlar, program çalışırken (runtime) oluşturulan nesnelerdir.<br><br>

### ⚙️ Dinamik Buton Ekleme
Button btn = new Button();<br>
btn.Text = "Tıkla";<br>
btn.Size = new Size(100, 50);<br>
btn.Location = new Point(50, 50);<br>
btn.Click += (s, e) => MessageBox.Show("Butona tıklandı!");<br>
this.Controls.Add(btn);<br><br>

<hr>

# 🖥️ Bölüm 10 - Veri Tabanı SQL

## 📌 1. SQL Veri Tabanı Nedir?
SQL (Structured Query Language), ilişkisel veri tabanlarını yönetmek için kullanılan bir sorgulama dilidir.<br><br>
### ✅ SQL Kullanılan Popüler Veri Tabanları:
📍 Microsoft SQL Server<br>
📍 MySQL<br>
📍 PostgreSQL<br>
📍 Oracle Database<br>
📍 SQLite<br>
📍 MariaDB<br><br>
Bu veri tabanları, tablolar, sütunlar ve ilişkiler ile çalışır.<br><br>

## 📌 SQL’de Veri Tabanı (Database) Oluşturma
Bir veri tabanı oluşturmak için CREATE DATABASE komutu kullanılır.<br><br>
### ✅ Basit Veri Tabanı Oluşturma
CREATE DATABASE MusteriDB;<br><br>
📍 Bu komut, "MusteriDB" adında bir veri tabanı oluşturur.<br><br>

## 📌 Veri Tabanını Kullanma (USE DATABASE)
SQL Server'da çalışacağımız veri tabanını seçmek için USE komutunu kullanırız.<br><br>
USE MusteriDB;<br><br>
📍 Bundan sonra tüm işlemler "MusteriDB" veri tabanında yapılır.<br><br>

## 📌 SQL’de Tablo (Table) Oluşturma
Bir veri tabanında tablolar kullanarak verileri düzenleriz. CREATE TABLE komutu ile yeni bir tablo oluşturabiliriz.<br><br>
### ✅ Örnek: "Musteriler" Tablosu Oluşturma

CREATE TABLE Musteriler (<br>
    MusteriID INT PRIMARY KEY,  -- Birincil anahtar (Benzersiz Kimlik)<br>
    Ad VARCHAR(50) NOT NULL,    -- Metin (Maksimum 50 karakter) ve boş olamaz<br>
    Soyad VARCHAR(50) NOT NULL,<br>
    Yas TINYINT CHECK (Yas >= 18), -- Yaş en az 18 olmalı<br>
    Email VARCHAR(100) UNIQUE,   -- Email benzersiz olmalı<br>
    KayitTarihi DATETIME DEFAULT GETDATE() -- Varsayılan olarak şu anki tarih<br>
);<br>
### 📌 Açıklamalar:
📍 MusteriID INT PRIMARY KEY → MusteriID sütunu birincil anahtar olarak kullanılır (benzersiz olmalı).<br>
📍 VARCHAR(50) NOT NULL → Ad ve Soyad sütunları boş bırakılamaz.<br>
📍 CHECK (Yas >= 18) → Yas sütunu en az 18 olmalıdır.<br>
📍 UNIQUE → Email sütunu benzersiz olmalıdır.<br>
📍 DEFAULT GETDATE() → KayitTarihi varsayılan olarak o anki tarih ve saat olur.<br><br>

## 📌 SQL’de Tabloya Veri Ekleme (INSERT INTO)
Bir tabloya veri eklemek için INSERT INTO komutu kullanılır.<br><br>

INSERT INTO Musteriler (MusteriID, Ad, Soyad, Yas, Email)<br>
VALUES (1, 'Sercan', 'Kurban', 29, 'sercan@gmail.com');<br><br>
📍 Bu komut, "Musteriler" tablosuna bir müşteri ekler.<br><br>

## 📌 SQL’de Tabloları Görüntüleme
Mevcut tabloları listelemek için:<br><br>
SELECT * FROM Musteriler;<br><br>
📍 Bu sorgu, "Musteriler" tablosundaki tüm verileri getirir.<br><br>

## 📌 SQL’de Tabloyu Güncelleme (UPDATE)
Tablodaki verileri güncellemek için UPDATE komutu kullanılır.<br><br>
UPDATE Musteriler<br>
SET Email = 'sercan.kurban@gmail.com'<br>
WHERE MusteriID = 1;<br><br>
📍 Bu komut, ID’si 1 olan müşterinin e-posta adresini değiştirir.<br><br>

## 📌 SQL’de Tablodaki Elemanı Silme
Tablodaki verileri silmek için DELETE komutu kullanılır.<br><br>
DELETE FROM Musteriler<br>
WHERE MusteriID = 1;<br><br>
📍 Bu komut, ID’si 1 olan müşteriyi siler.<br><br>

## 📌 SQL’de Tablo Silme (DROP TABLE)
Bir tabloyu tamamen silmek için DROP TABLE komutu kullanılır.<br><br>
DROP TABLE Musteriler;<br><br>
📍 Bu komut "Musteriler" tablosunu tamamen kaldırır.<br><br>

## 📌 SQL’de Veri Tabanı Silme (DROP DATABASE)
Bir veri tabanını silmek için DROP DATABASE komutu kullanılır.<br><br>
DROP DATABASE MusteriDB;<br><br>
❗ <strong>Dikkat: Bu komut, tüm tablolar ve verilerle birlikte veri tabanını tamamen siler!</strong><br><br>

## 📌 SQL’de Tablo Yapısını Değiştirme (ALTER TABLE)
Mevcut bir tabloya yeni bir sütun eklemek veya var olan bir sütunu değiştirmek için ALTER TABLE kullanılır.<br><br>
### ✅ Yeni Sütun Ekleme
ALTER TABLE Musteriler<br>
ADD Telefon VARCHAR(15);<br><br>
📍 Bu komut, "Musteriler" tablosuna "Telefon" adında yeni bir sütun ekler.<br><br>

### ✅ Sütun Silme
ALTER TABLE Musteriler<br>
DROP COLUMN Telefon;<br>
📍 Bu komut, "Telefon" sütununu siler.<br><br>

## 📌 2. SQL Veri Tipleri Nelerdir?
SQL’de veri tipleri 3 ana gruba ayrılır:<br><br>
![image](https://github.com/user-attachments/assets/288d0fbd-74a5-4ff9-ad6c-399e2d082bb1)
<br>
### ✅ 2.1 Sayısal (Numeric) Veri Tipleri
Sayılarla işlem yapmak için kullanılan veri tipleridir.<br><br>
![image](https://github.com/user-attachments/assets/26e9ea71-cd5e-4dd7-93f8-6cb6f80599e5)
<br>
### ⚙️ Örnek Kullanım
CREATE TABLE Musteriler (<br>
    MusteriID INT PRIMARY KEY,<br>
    Yas TINYINT,<br>
    Maas DECIMAL(10,2)  -- 10 basamaklı, 2 ondalık<br>
);<br><br>
### ✅ 2.2 Metinsel (String) Veri Tipleri
Metin verileri için kullanılan veri tipleridir.<br><br>
![image](https://github.com/user-attachments/assets/304af2f3-dc81-4d91-94ca-08c738344c36)
<br>
### ⚙️ Örnek Kullanım
CREATE TABLE Urunler (<br>
    UrunID INT PRIMARY KEY,<br>
    UrunAdi VARCHAR(100),<br>
    Aciklama TEXT<br>
);<br>
<br>
💯 CHAR(10) → "KİTAP " (Boşluk bırakır)
💯 VARCHAR(10) → "KİTAP" (Boşluk bırakmaz)

### ✅ 2.3 Tarih ve Zaman (Date/Time) Veri Tipleri
Tarih ve saat bilgilerini saklamak için kullanılır.<br><br>
![image](https://github.com/user-attachments/assets/45cf71c6-9c13-4a6a-bc38-04e3214d2ce1)
<br>
CREATE TABLE Siparisler (<br>
    SiparisID INT PRIMARY KEY,<br>
    SiparisTarihi DATETIME,<br>
    TeslimTarihi DATE<br>
);<br><br>

## 📌 3. Diğer Özel Veri Tipleri
![image](https://github.com/user-attachments/assets/bb6bb1aa-5b79-4a09-8616-e884f9b529d3)
<br>
### ⚙️ Örnek Kullanım
CREATE TABLE Loglar (<br>
    LogID INT PRIMARY KEY,<br>
    LogDetay JSON<br>
);<br><br>

C# ile SQL Server bağlantısını kurmak için ilk olarak bağlantı adresini almamız gerekmektedir. Adımlar aşağıdaki gibidir.<br><br>
![image](https://github.com/user-attachments/assets/1efff21f-1dd5-42c4-9271-4b2ebd7cf020)
<br>
Yukarıda yer alan menülerden Project kısmına gelinip Add New Data Source kısmına tıklanır.<br>
![image](https://github.com/user-attachments/assets/972e5642-386a-448e-b25e-546ab7deb60c)<br>
Karşımıza çıkan Database seçili halde gelecektir. Next diyoruz.<br>
![image](https://github.com/user-attachments/assets/5c319097-b54e-4229-834a-eab3d3cced07)<br>
Tekrardan Next diyoruz.<br>
![image](https://github.com/user-attachments/assets/89e62977-893e-4d41-ad36-2fdb3e888cf6)<br>
Daha önceden herhangi bir veri tabanı işlemi yapmadıysanız buradaki PersonelVeriTabaniConnectionString kısmı sizde boş gözükecektir. Sağ tarafta yer alan New Connection butonuna tıklıyoruz.<br>
![image](https://github.com/user-attachments/assets/c566fdad-0595-4dbc-ab0b-7ac19b506332)<br>
Burada Server Name kısmı sizin SQL veri tabanı adresinizin ismidir. SQL adresinizi öğrenmek için;<br>
![image](https://github.com/user-attachments/assets/3db70985-9e95-4803-8c28-e884251ba961)<br>
SQL'e gelip sol tarafta yer alan Object Explorer kısmındaki menülerin en üstündekine sağ tıklayıp Properties seçeneğine gelinir.<br>
![image](https://github.com/user-attachments/assets/f0ac6615-bc5d-41ea-a582-9d2d111c76fb)<br>
Buradaki Name kısmı sizin SQL adresinizdir. Burayı direkt kopyalayarak C#'ta Server Name kısmına yapıştırabiliriz.<br>
Tekrardan Connection kısmına gelip Encrypt kısmını isterseniz Mandatory(True), isterseniz Optional(False) yapabilirsiniz. Mandatory yaptığınız zaman Trust Server Certificate kısmının seçili olması gerekmektedir. Veri tabanımızı seçtikten sonra OK diyoruz.<br>
![image](https://github.com/user-attachments/assets/f3264b1d-396e-4efc-8672-1147afbf9e80)<br>
Aşağıdaki işareti seçili hale getirdikten sonra bağlantı adresimiz bu şekilde olacaktır. Bu adresi kopyalayıp Cancel diyoruz veya direkt verileri hazır olarak tutmak için Next diyoruz.<br>
![image](https://github.com/user-attachments/assets/c2ccc85f-0639-4996-b0dd-e9c4a95a8fc7)<br>
Ardından seçmek istediğimiz tabloyu seçiyoruz, burada istediğimiz sütunları alabiliriz. Burada tamamını alıp Finish diyoruz.<br><br>

## 📌 1. Gerekli Kütüphaneler
C# ile SQL Server’a bağlanmak için System.Data.SqlClient kütüphanesini kullanırız.<br><br>
using System;<br>
using System.Data;<br>
using System.Data.SqlClient; Kullanacağımız kütüphane bu olacaktır.<br><br>

## 📌 2. SQL Bağlantı Dizesi (Connection String)
Önce SQL Server’a bağlanmak için bir connection string tanımlamalıyız.<br><br>
### ✅ SQL Server’a Bağlantı Kurma
SqlConnection baglanti = new SqlConnection("Data Source=SERCAN\\SQLEXPRESS;Initial Catalog=PersonelVeriTabani;Integrated Security=True");<br><br>
📍 Data Source → SQL Server adını belirtir (Local ise localhost veya . kullanılır).<br>
📍 Initial Catalog → Kullanılacak veri tabanının adıdır.<br>
📍 Integrated Security=True → Windows kimlik doğrulaması kullanır.<br>

❗ Eğer SQL kullanıcı adı ve şifre ile bağlanıyorsanız:<br><br>
SqlConnection baglanti = new SqlConnection("Data Source=SERCAN\\SQLEXPRESS;Initial Catalog=PersonelVeriTabani;User Id=sa;Password=1234;");<br><br>

## 📌 3. SQL Bağlantısı Açma ve Kapatma
using (SqlConnection conn = new SqlConnection(connectionString))<br>
{<br>
    try<br>
    {<br>
        conn.Open();<br>
        Console.WriteLine("Bağlantı başarılı!");<br>
    }<br>
    catch (Exception ex)<br>
    {<br>
        Console.WriteLine("Bağlantı hatası: " + ex.Message);<br>
    }<br>
}<br><br>
✅ using bloğu sayesinde bağlantı iş bittikten sonra otomatik kapanır.<br><br>

## 📌 4. CRUD İşlemleri

![image](https://github.com/user-attachments/assets/03ed1086-99f5-4603-b706-a466f1aa2273)<br>
Burada örnek olarak bir Personel Kayıt Sistemi projesi oluşturduk. Şimdi Create (Ekle), Read (Oku), Update (Güncelle), Delete (Sil) işlemlerini yapalım.<br><br>

### ✅ 4.1 Veri Ekleme (CREATE - INSERT INTO)
private void btnKaydet_Click(object sender, EventArgs e)<br>
{<br>
    baglanti.Open();<br>
    SqlCommand komut = new SqlCommand("insert into Tbl_Personel (PerAd,PerSoyad,PerSehir,PerMaas,PerMeslek,PerDurum) values (@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);<br>
    komut.Parameters.AddWithValue("@p1", txtPersonelAd.Text);<br>
    komut.Parameters.AddWithValue("@p2", txtPersonelSoyad.Text);<br>
    komut.Parameters.AddWithValue("@p3", cmbSehir.Text);<br>
    komut.Parameters.AddWithValue("@p4", mskMaas.Text);<br>
    komut.Parameters.AddWithValue("@p5", txtMeslek.Text);<br>
    komut.Parameters.AddWithValue("@p6", label8.Text);<br>
    komut.ExecuteNonQuery();<br>
    baglanti.Close();<br>
    MessageBox.Show("Personel Eklendi");<br>
    this.tbl_PersonelTableAdapter.Fill(this.personelVeriTabaniDataSet.Tbl_Personel);<br>
}<br><br>

📍 Kaydetme işlemi için ilk olarak bağlantımızı açıyoruz.<br>
📍 Ardından CRUD işlemlerini veya başka sorgular yazmak için SqlCommand komutunu kullanıyoruz.<br>
📍 Daha sonra Parameters.AddWithValue ile tek tek atamalarımızı yapıyoruz.<br>
📍 Sorguyu kaydetmek için ExecuteNonQuery komutunu kullanıyoruz ve bağlantıyı kapatıyoruz.<br><br>

### ✅ 4.2 Veri Okuma (READ - SELECT)
private void btnListele_Click(object sender, EventArgs e)<br>
{<br>
    this.tbl_PersonelTableAdapter.Fill(this.personelVeriTabaniDataSet.Tbl_Personel);<br>
}<br><br>
Bu kod hazır hale Form'un Load kısmına gelecektir.<br><br>

### ✅ 4.3 Veri Güncelleme (UPDATE)
private void btnGuncelle_Click(object sender, EventArgs e)<br>
{<br>
    baglanti.Open();<br>
    SqlCommand komut = new SqlCommand("update Tbl_Personel set PerAd=@p1,PerSoyad=@p2,PerSehir=@p3,PerMaas=@p4,PerDurum=@p5,PerMeslek=@p6 where PersonelID=@p7", baglanti);<br>
    komut.Parameters.AddWithValue("@p1", txtPersonelAd.Text);<br>
    komut.Parameters.AddWithValue("@p2", txtPersonelSoyad.Text);<br>
    komut.Parameters.AddWithValue("@p3", cmbSehir.Text);<br>
    komut.Parameters.AddWithValue("@p4", mskMaas.Text);<br>
    komut.Parameters.AddWithValue("@p5", label8.Text);<br>
    komut.Parameters.AddWithValue("@p6", txtMeslek.Text);<br>
    komut.Parameters.AddWithValue("@p7", txtPersonelID.Text);<br>
    komut.ExecuteNonQuery();<br>
    baglanti.Close();<br>
    MessageBox.Show("Personel Güncellendi");<br>
    this.tbl_PersonelTableAdapter.Fill(this.personelVeriTabaniDataSet.Tbl_Personel);<br>
}<br><br>

### ✅ 4.4 Veri Silme (DELETE)
private void btnSil_Click(object sender, EventArgs e)<br>
{<br>
    baglanti.Open();<br>
    SqlCommand komut = new SqlCommand("delete from Tbl_Personel where PersonelID=@p1", baglanti);<br>
    komut.Parameters.AddWithValue("@p1", txtPersonelID.Text);<br>
    komut.ExecuteNonQuery();<br>
    baglanti.Close();<br>
    MessageBox.Show("Personel Silindi");<br>
    this.tbl_PersonelTableAdapter.Fill(this.personelVeriTabaniDataSet.Tbl_Personel);<br>
}<br><br>

<hr>

# 🖥️ Bölüm 11 - Dosya İşlemleri
C#'ta dosya işlemleri, System.IO kütüphanesi ile gerçekleştirilir. Bu kütüphane, dosya okuma, yazma, silme, taşıma gibi işlemleri yapmamızı sağlar.<br><br>
## 📌 1. Gerekli Kütüphane
Dosya işlemleri için System.IO kütüphanesini kullanmalıyız:<br><br>
using System;<br>
using System.IO;<br><br>

## 📌 2. Dosya Oluşturma ve Yazma (File.WriteAllText, StreamWriter)
Bir dosya oluşturup içine veri yazmak için File.WriteAllText() veya StreamWriter kullanılır.<br><br>
### ✅ File.WriteAllText() ile Yazma
string dosyaYolu = "C:\\Dosyalar\\ornek.txt";<br>
File.WriteAllText(dosyaYolu, "Merhaba, bu bir dosya yazma testidir.");<br>
Console.WriteLine("Dosya başarıyla oluşturuldu!");<br><br>
📍 Dosya yoksa oluşturur, varsa üzerine yazar.<br><br>
### ✅ StreamWriter ile Yazma
using (StreamWriter sw = new StreamWriter("C:\\Dosyalar\\ornek.txt"))<br>
{<br>
    sw.WriteLine("Bu bir StreamWriter testidir.");<br>
    sw.WriteLine("İkinci satır.");<br>
}<br>
Console.WriteLine("Dosya yazıldı!");<br><br>
📍 using bloğu sayesinde dosya otomatik kapanır.<br><br>

## 📌 3. Dosyadan Okuma (File.ReadAllText, StreamReader)
Bir dosyanın içeriğini okumak için File.ReadAllText() veya StreamReader kullanılır.<br><br>
### ✅ File.ReadAllText() ile Okuma
string icerik = File.ReadAllText("C:\\Dosyalar\\ornek.txt");<br>
Console.WriteLine("Dosya İçeriği:\n" + icerik);<br><br>
📍 Dosyanın tamamını okur.<br><br>
### ✅ StreamReader ile Satır Satır Okuma
using (StreamReader sr = new StreamReader("C:\\Dosyalar\\ornek.txt"))<br>
{<br>
    string satir;<br>
    while ((satir = sr.ReadLine()) != null)<br>
    {<br>
        Console.WriteLine(satir);<br>
    }<br>
}<br><br>
📍 Dosyayı satır satır okur.<br><br>

C#’ta OpenFileDialog, SaveFileDialog ve FolderBrowserDialog, kullanıcıya dosya veya klasör seçtirme işlemleri için kullanılan bileşenlerdir. Windows Forms uygulamalarında System.Windows.Forms kütüphanesi içinde bulunurlar.<br><br>
## 📌 1. OpenFileDialog (Dosya Açma Penceresi)
Kullanıcının bir dosya seçmesini sağlar. Seçilen dosyanın yolunu alarak programda kullanabiliriz.<br><br>
### ✅ Kullanımı
using System;<br>
using System.Windows.Forms;<br>
<br>
class Program<br>
{<br>
    [STAThread] // OpenFileDialog için gerekli<br>
    static void Main()<br>
    {<br>
        OpenFileDialog openFileDialog = new OpenFileDialog();<br>
        openFileDialog.Title = "Dosya Seç";<br>
        openFileDialog.Filter = "Metin Dosyaları|*.txt|Tüm Dosyalar|*.*";<br>
        openFileDialog.InitialDirectory = "C:\\";<br>
<br>
        if (openFileDialog.ShowDialog() == DialogResult.OK)<br>
        {<br>
            string dosyaYolu = openFileDialog.FileName;<br>
            MessageBox.Show("Seçilen Dosya: " + dosyaYolu);<br>
        }<br>
    }<br>
}<br><br>

✔ Filter = "Metin Dosyaları|*.txt|Tüm Dosyalar|*.*"; → Sadece belirli dosya türlerini gösterir.<br>
✔ InitialDirectory = "C:\\"; → İlk açıldığında gösterilecek klasörü belirler.<br>
✔ FileName → Seçilen dosyanın tam yolunu döndürür.<br><br>

## 📌 2. SaveFileDialog (Dosya Kaydetme Penceresi)
Kullanıcının bir dosya kaydetmesini sağlar. Kullanıcı dosya adını belirleyip Kaydet dediğinde, program bu yolu alır ve içine veri yazabilir.<br><br>

### ✅ Kullanımı
using System;<br>
using System.IO;<br>
using System.Windows.Forms;<br>
<br>
class Program<br>
{<br>
    [STAThread]<br>
    static void Main()<br>
    {<br>
        SaveFileDialog saveFileDialog = new SaveFileDialog();<br>
        saveFileDialog.Title = "Dosya Kaydet";<br>
        saveFileDialog.Filter = "Metin Dosyaları|*.txt|Tüm Dosyalar|*.*";<br>
        saveFileDialog.DefaultExt = "txt";<br>
        saveFileDialog.FileName = "yeni_dosya.txt";<br>
<br>
        if (saveFileDialog.ShowDialog() == DialogResult.OK)<br>
        {<br>
            string dosyaYolu = saveFileDialog.FileName;<br>
            File.WriteAllText(dosyaYolu, "Bu dosya C# ile kaydedildi.");<br>
            MessageBox.Show("Dosya başarıyla kaydedildi!");<br>
        }<br>
    }<br>
}<br><br>

✔ Kullanıcı, kaydetme penceresinden bir dosya adı belirler.<br>
✔ File.WriteAllText(dosyaYolu, "İçerik"); → Seçilen yola yazma işlemi yapar.<br>
✔ DefaultExt = "txt"; → Varsayılan dosya uzantısını belirler.<br>
✔ FileName = "yeni_dosya.txt"; → Varsayılan dosya adını belirler.<br>

## 📌 3. FolderBrowserDialog (Klasör Seçme Penceresi)
Kullanıcının bir klasör seçmesini sağlar.<br><br>
### ✅ Kullanımı
using System;<br>
using System.Windows.Forms;<br>
<br>
class Program<br>
{<br>
    [STAThread]<br>
    static void Main()<br>
    {<br>
        FolderBrowserDialog folderDialog = new FolderBrowserDialog();<br>
        folderDialog.Description = "Bir klasör seçin:";<br>
        folderDialog.ShowNewFolderButton = true; // Yeni klasör oluşturma butonu göster<br>
<br>
        if (folderDialog.ShowDialog() == DialogResult.OK)<br>
        {<br>
            string klasorYolu = folderDialog.SelectedPath;<br>
            MessageBox.Show("Seçilen Klasör: " + klasorYolu);<br>
        }<br>
    }<br>
}<br><br>
✔ ShowNewFolderButton = true; → Kullanıcının yeni klasör oluşturmasına izin verir.<br>
✔ SelectedPath → Seçilen klasörün tam yolunu döndürür.<br><br>

<hr>

# 🖥️ Bölüm 12 - Hastane Yönetim ve Randevu Sistemi Otomasyon Projesi
Bu bölümde C# ve SQL ile bilgilerimizi pekiştirerek bir tane otomasyon hazırladık.<br><br>
📍 Bu otomasyonda 3 tane kullanıcı girişi (hasta, doktor ve sekreter),<br> 
📍 Hasta giriş veya kayıt olma özelliği,<br> 
📍 Hasta branş, doktor ve şikayetini yazarak randevu alabilme,<br> 
📍 Hasta bilgilerini düzenleme,<br> 
📍 Doktor giriş yapabilme,<br> 
📍 Doktor duyuruları görebilme, randevuları görebilme ve bilgileri düzenleme,<br> 
📍 Sekreter giriş yapabilme,<br> 
📍 Sekreter doktor paneli, branş panelini yönetebilme,<br> 
📍 Sekreter duyuru oluşturabilme,<br> 
📍 Sekreter randevu oluşturma işlemlerini yapmaktadır.<br><br> 

Projeye ait ekran görüntüleri;<br><br>

![image](https://github.com/user-attachments/assets/934643d6-723a-4f3a-9777-845081b685fc)<br><br>
![image](https://github.com/user-attachments/assets/5c5963f1-b685-4976-aa08-c23520a973c6)<br><br>
![image](https://github.com/user-attachments/assets/36f0c0fa-8b93-4c2a-901a-ed652ba99bb4)<br><br>
![image](https://github.com/user-attachments/assets/75c68cc2-ff5c-4fc1-8a08-26d43b57c272)<br><br>
![image](https://github.com/user-attachments/assets/fd9bd96e-88c8-46c3-804a-66484bef053c)<br><br>
![image](https://github.com/user-attachments/assets/dd0100f0-34e7-4532-8abb-2b937377238f)<br><br>
![image](https://github.com/user-attachments/assets/8de82da0-00fc-437c-a1ce-cb953b88bdbd)<br><br>
![image](https://github.com/user-attachments/assets/1afa5308-aa57-4f01-8ffb-831f3edaa2ec)<br><br>
![image](https://github.com/user-attachments/assets/71bdf04f-6601-476d-9627-07e488b7f585)<br><br>
![image](https://github.com/user-attachments/assets/c9bc8d32-c41f-40ff-841d-b50b2b5a09e8)<br><br>
![image](https://github.com/user-attachments/assets/a26421f8-1ebb-4ba3-9523-a0e0f77465f1)<br><br>
![image](https://github.com/user-attachments/assets/f4cf7188-9f79-4b55-91c3-7943dfbfd5d0)<br><br>

<hr>

# 🖥️ Bölüm 13 - Access Veri Tabanı
C# ile Microsoft Access veritabanı bağlantısı kurarak CRUD (Create, Read, Update, Delete) işlemleri yapabiliriz. Access veritabanına bağlanmak için System.Data.OleDb kütüphanesini kullanırız.<br><br>
## 📌 1. Gerekli Kütüphaneler
C# uygulamanda Access veritabanına bağlanmak için aşağıdaki kütüphaneyi eklemeliyiz:<br>
using System.Data.OleDb;<br><br>

C# üzerinden Access veri tabanına bağlanmak için aynı şekilde Project kısmından Add New Data Source diyerek aynı adımları yapıyoruz;<br><br>
![image](https://github.com/user-attachments/assets/b4fd8755-68ac-4f63-8b6a-936e2b6889aa)
Burada en üstte yer alan Data Source kısmı Microsoft SQL Server olarak çıkacaktır. Access seçmek için sağda bulunan Change butonuna tıklıyoruz.<br>
![image](https://github.com/user-attachments/assets/86f8f597-231a-4009-b209-0a3d1f774f82)<br>
Burada en üstte yer alan Microsoft Access Database File seçiyoruz.<br>
![image](https://github.com/user-attachments/assets/dd22e9a9-f911-45bd-a803-35d8fa66bf0e)<br>
Buradan Database file name kısmından veri tabanı seçmek için Browse diyoruz ve ilgili veri tabanımızı seçiyoruz.<br><br>

## 📌 2. Access Veritabanına Bağlantı (OleDbConnection)
Access dosyanın konumuna göre bağlantı dizesi (Connection String) belirlemeliyiz.<br>
‼️ <strong>.accdb (Access 2007 ve sonrası) ve .mdb (Access 2003 ve öncesi) uzantıları için bağlantı şekli farklıdır.</strong><br><br>

### ✅ Access 2007+ (.accdb) için bağlantı
string baglantiYolu = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Veritabanim.accdb;";<br>
OleDbConnection baglanti = new OleDbConnection(baglantiYolu);<br><br>
<hr>

## ✅ Access 2003 (.mdb) için bağlantı
string baglantiYolu = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Veritabanim.mdb;";<br>
OleDbConnection baglanti = new OleDbConnection(baglantiYolu);<br><br>

## 📌 3. Access Veritabanına Bağlanma
try<br>
{<br>
    baglanti.Open();<br>
    MessageBox.Show("Veritabanı bağlantısı başarılı!");<br>
    baglanti.Close();<br>
}<br>
catch (Exception ex)<br>
{<br>
    MessageBox.Show("Bağlantı hatası: " + ex.Message);<br>
}<br><br>

## 📌 4. CRUD İşlemleri (Ekleme, Okuma, Güncelleme, Silme)
CRUD işlemleri SQL ile aynıdır, ancak SQL'de SqlCommand kullanırken Access'te OleDbCommand kullanırız.<br><br>
## ✅ a) Veri Ekleme (INSERT INTO)
string ekleSorgu = "INSERT INTO Kullanici (Ad, Soyad, Yas) VALUES (@Ad, @Soyad, @Yas)";<br>
OleDbCommand komut = new OleDbCommand(ekleSorgu, baglanti);<br>
<br>
komut.Parameters.AddWithValue("@Ad", "Ali");<br>
komut.Parameters.AddWithValue("@Soyad", "Yılmaz");<br>
komut.Parameters.AddWithValue("@Yas", 25);<br>
<br>
baglanti.Open();<br>
komut.ExecuteNonQuery();<br>
baglanti.Close();<br>
MessageBox.Show("Kayıt başarıyla eklendi!");<br><br>

## ✅ b) Veri Okuma (SELECT)
string secSorgu = "SELECT * FROM Kullanici";<br>
OleDbCommand komut = new OleDbCommand(secSorgu, baglanti);<br>
baglanti.Open();<br>
<br>
OleDbDataReader okuyucu = komut.ExecuteReader();<br>
while (okuyucu.Read())<br>
{<br>
    Console.WriteLine($"ID: {okuyucu["ID"]}, Ad: {okuyucu["Ad"]}, Soyad: {okuyucu["Soyad"]}, Yaş: {okuyucu["Yas"]}");<br>
}<br>
<br>
baglanti.Close();<br><br>

## ✅ c) Veri Güncelleme (UPDATE)
string guncelleSorgu = "UPDATE Kullanici SET Yas = @YeniYas WHERE ID = @ID";<br>
OleDbCommand komut = new OleDbCommand(guncelleSorgu, baglanti);<br>
<br>
komut.Parameters.AddWithValue("@YeniYas", 30);<br>
komut.Parameters.AddWithValue("@ID", 1);<br>
<br>
baglanti.Open();<br>
komut.ExecuteNonQuery();<br>
baglanti.Close();<br>
MessageBox.Show("Kayıt güncellendi!");<br><br>

## ✅ d) Veri Silme (DELETE)
string silSorgu = "DELETE FROM Kullanici WHERE ID = @ID";<br>
OleDbCommand komut = new OleDbCommand(silSorgu, baglanti);<br>
<br>
komut.Parameters.AddWithValue("@ID", 1);<br>
<br>
baglanti.Open();<br>
komut.ExecuteNonQuery();<br>
baglanti.Close();<br>
MessageBox.Show("Kayıt silindi!");<br><br>

<hr>

# 🖥️ Bölüm 14 - Hata Kontrolleri
C#’ta hata kontrolleri (Exception Handling), programın çalışma sırasında beklenmeyen hataları yakalayıp yönetmek için kullanılır.<br>
En yaygın hata kontrol yöntemi try-catch-finally bloğudur. Ayrıca throw, when, checked/unchecked, Debug.Assert gibi farklı hata yönetimi yöntemleri de vardır.<br><br>

## 📌 1. Try-Catch-Finally Kullanımı
Bir hata oluştuğunda programın çökmesini engelleyerek kontrolü ele alabiliriz.<br><br>
### ✅ Temel Kullanım
try<br>
{<br>
    int sayi1 = 10, sayi2 = 0;<br>
    int sonuc = sayi1 / sayi2;  // Sıfıra bölme hatası oluşur<br>
}<br>
catch (Exception ex)<br>
{<br>
    Console.WriteLine("Hata oluştu: " + ex.Message);<br>
}<br><br>
✔ try → Hata olabilecek kod buraya yazılır.<br>
✔ catch → Hata yakalandığında burası çalışır.<br>
✔ ex.Message → Hatanın açıklamasını verir.<br><br>

## 📌 2. Spesifik Hata Türlerini Yakalama
Bazı hatalar daha spesifik olabilir, bu yüzden farklı türde catch blokları kullanabiliriz.<br><br>
### ✅ Örnek
try<br>
{<br>
    int[] dizi = { 1, 2, 3 };<br>
    Console.WriteLine(dizi[5]); // Dizinin sınırlarını aşıyor<br>
}<br>
catch (IndexOutOfRangeException ex)<br>
{<br>
    Console.WriteLine("Dizinin sınırlarını aştınız!");<br>
}<br>
catch (DivideByZeroException ex)<br>
{<br>
    Console.WriteLine("Sıfıra bölme hatası!");<br>
}<br>
catch (Exception ex)<br>
{<br>
    Console.WriteLine("Bilinmeyen bir hata oluştu: " + ex.Message);<br>
}<br><br>
✔ IndexOutOfRangeException → Dizi sınırlarını aşma hatasını yakalar.<br>
✔ DivideByZeroException → Sıfıra bölme hatasını yakalar.<br>
✔ Genel Exception → Diğer hataları yakalar.<br><br>

## 📌 3. Finally Bloğu (İsteğe Bağlı)
finally bloğu, hata olsa da olmasa da her zaman çalıştırılır.<br>
Özellikle veritabanı bağlantısı kapatma, dosya kapatma gibi işlemler için kullanılır.<br><br>
### ✅ Örnek
OleDbConnection baglanti = new OleDbConnection("Bağlantı_dizesi");<br>
<br>
try<br>
{<br>
    baglanti.Open();<br>
    Console.WriteLine("Veritabanı bağlantısı açıldı.");<br>
}<br>
catch (Exception ex)<br>
{<br>
    Console.WriteLine("Hata oluştu: " + ex.Message);<br>
}<br>
finally<br>
{<br>
    baglanti.Close();  // Bağlantıyı kapat<br>
    Console.WriteLine("Bağlantı kapatıldı.");<br>
}<br><br>
✔ Hata olsa da olmasa da finally bloğu her zaman çalışır.<br><br>

## 📌 4. Hata Fırlatma (throw)
Bazen kendi özel hatalarımızı oluşturmak isteyebiliriz.<br><br>
### ✅ Kullanımı
static void SifiraBolmeKontrol(int sayi)<br>
{<br>
    if (sayi == 0)<br>
    {<br>
        throw new DivideByZeroException("Sayı sıfır olamaz!");<br>
    }<br>
    Console.WriteLine("Sonuç: " + (10 / sayi));<br>
}<br>
<br>
try<br>
{<br>
    SifiraBolmeKontrol(0);<br>
}<br>
catch (Exception ex)<br>
{<br>
    Console.WriteLine("Hata yakalandı: " + ex.Message);<br>
}<br><br>
✔ throw → Özel hata oluşturup fırlatır.<br>
✔ catch bloğunda bu hata yakalanabilir.<br><br>

<hr>

# 🖥️ Bölüm 15 - Örnek Proje: İlişkili Tablolar ile E-Okul Benzeri Uygulama + Dataset ile Crud İşlemleri
Bu bölümde bir bonus projesi yapıldı.<br><br>
📍 Bu projede öğrenci ve öğretmen giriş panelleri bulunmaktadır.<br>
📍 Burada öğrenci numarasını girdiğinde kendi notlarını görüntüleyebilir.<br>
📍 Öğretmen numarasını direkt 0000 olarak belirledik. Öğretmen panelinde 5 tane işlem bulunmaktadır.<br>
📍 Kulüp kısmında ADO.NET ile CRUD işlemleri yapılmıştır.<br>
📍 Diğer tüm işlemlerde ise Dataset ile CRUD işlemleri yapılmıştır.<br><br>

Dataset oluşturmak için katmanımıza sağ tıklayarak Add kısmından New Item seçilir.<br>
![image](https://github.com/user-attachments/assets/910412d4-81e8-4aef-b974-5599516c64fc)<br>
Sağ tarafta yer alan Data kısmından Dataset seçip Add diyoruz. Dataset eklediğimizde ilk başta boş bir pencere gözükecektir.<br>
![image](https://github.com/user-attachments/assets/6e082f99-153d-4075-910b-d584006f1eee)<br>
Boş alana sağ tıklayıp Add kısmından TableAdapter diyoruz.<br>
Buradan veri tabanınımızı ekleyip Next diyoruz.<br>
![image](https://github.com/user-attachments/assets/471d3461-a426-447e-9938-0f6570068578)<br>
Karşımıza çıkan pencerede en üstteki Use SQL statements seçili gelecektir. Next diyoruz.<br>
![image](https://github.com/user-attachments/assets/5993f6a8-5da3-4c13-9cce-a53950ffb906)<br>
Bu ekranda bir sorgu oluşturmaya çalışacağız. Bunun için sağ altta yer alan Query Builder'a tıklıyoruz.<br>
![image](https://github.com/user-attachments/assets/876d3a49-f569-4297-9764-393086405198)<br>
Buradan yapmak istediğimiz CRUD işlemi hangisiyse ilgili tabloyu seçiyoruz. Örnek olarak Dersler tablosunu seçelim.<br>
![image](https://github.com/user-attachments/assets/98e5d145-4617-42c8-a331-ca38d93cb421)<br>
Buradaki bütün alanları seçtikten sonra otomatik olarak sorguyu oluşturacaktır. OK diyoruz.<br>
![image](https://github.com/user-attachments/assets/28c6730b-0243-4089-8fd9-0e7a19961d35)<br>
Sorguyu oluşturdu. Next diyoruz.<br>
![image](https://github.com/user-attachments/assets/be436463-b8c7-4f5e-9d7b-e33396e2603d)<br>
Burada Method name kısmında Default olarak GetData isminde çıkacaktır. Burayı değiştirip ismini DersListesi olarak belirliyoruz ve Next diyoruz.<br>
![image](https://github.com/user-attachments/assets/a551adfd-2a12-4be4-a1da-bb0e5d101c3d)<br>
Burada eğer sorguda herhangi bir hata yapmadıysak karşımıza bu şekilde hepsi ✔ işaretiyle çıkacaktır. Finish diyoruz.<br><br>

Dersler formuna giderek temel CRUD işlemlerini yapalım.<br>

Global alana yazacağımız kod;<br><br>
DataSet1TableAdapters.TBLDERSLERTableAdapter ds = new DataSet1TableAdapters.TBLDERSLERTableAdapter();

CRUD İşlemleri için kodlar;<br><br>
private void btnListele_Click(object sender, EventArgs e)<br>
{<br>
    dgvDersler.DataSource = ds.DersListesi();<br>
}<br>
<br>
private void btnEkle_Click(object sender, EventArgs e)<br>
{<br>
    ds.DersEkle(txtDersAdi.Text);<br>
    MessageBox.Show("Ders Ekleme İşlemi Yapılmıştır");<br>
    txtDersAdi.Clear();<br>
    dgvDersler.DataSource = ds.DersListesi();<br>
}<br>
<br>
private void btnSil_Click(object sender, EventArgs e)<br>
{<br>
    ds.DersSil(byte.Parse(txtDersID.Text));<br>
    MessageBox.Show("Ders Silme İşlemi Yapılmıştır");<br>
    txtDersID.Clear();<br>
    txtDersAdi.Clear();<br>
    dgvDersler.DataSource = ds.DersListesi();<br>
}<br>
<br>
private void btnGuncelle_Click(object sender, EventArgs e)<br>
{<br>
    ds.DersGuncelle(txtDersAdi.Text, byte.Parse(txtDersID.Text));<br>
    MessageBox.Show("Ders Güncelleme İşlemi Yapılmıştır");<br>
    txtDersID.Clear();<br>
    txtDersAdi.Clear();<br>
    dgvDersler.DataSource = ds.DersListesi();<br>
}<br>
<br>
private void dgvDersler_CellClick(object sender, DataGridViewCellEventArgs e)<br>
{<br>
    try<br>
    {<br>
        txtDersID.Text = dgvDersler.Rows[e.RowIndex].Cells[0].Value.ToString();<br>
        txtDersAdi.Text = dgvDersler.Rows[e.RowIndex].Cells[1].Value.ToString();<br>
    }<br>
    catch (Exception)<br>
    {<br>
<br>
    }<br>
}<br>
<br>

<hr>

# 🖥️ Bölüm 16 - Entity Framework
Entity Framework (EF), C# ile veritabanı işlemlerini kolaylaştıran bir ORM (Object-Relational Mapping) kütüphanesidir. Yani, SQL komutları yazmadan veritabanı ile çalışmamızı sağlar.<br><br>

✔ SQL sorgularını otomatik oluşturur.<br>
✔ Verileri nesne olarak kullanmamızı sağlar.<br>
✔ Veritabanı işlemlerini hızlandırır.<br>
✔ Kodun daha okunabilir ve yönetilebilir olmasını sağlar.<br><br>

## 📌 Entity Framework Kullanım Yöntemleri
Entity Framework’ü 3 farklı şekilde kullanabiliriz:<br><br>
![image](https://github.com/user-attachments/assets/a1ff1068-c1b2-4266-bbbd-39f5f02caffa)
<br><br>

Bu eğitimde DbFirst modelini kullanacağız.<br><br>
Katmanımıza sağ tıklayarak Add kısmından New Item seçilir.<br>
![image](https://github.com/user-attachments/assets/eb127591-3d20-4edc-870f-42cda4b12746)<br>
Sol taraftan Data kısmını seçerek ADO.NET Entity Data Model seçtikten sonra Add diyoruz.<br>
![image](https://github.com/user-attachments/assets/6f80a266-3782-4678-9909-776079c2ec64)<br>
Burada başlangıçta EF Designer from Database seçili hale gelecektir. Next diyoruz.<br>
![image](https://github.com/user-attachments/assets/ce053590-458d-4786-9f2f-be987f3cc92f)<br>
Veri tabanımızı seçerek Next diyoruz.<br>
![image](https://github.com/user-attachments/assets/9edd3a83-71ec-4a0d-9668-ba627ff2a3a3)<br>
Buradan istediğimiz tabloları seçiyoruz ve Finish diyoruz.<br>
![image](https://github.com/user-attachments/assets/36e1dfa8-6958-4040-8d11-87d7788c0f9a)<br>
Modelimiz bu şekilde olacaktır.<br><br>

![image](https://github.com/user-attachments/assets/d2734f84-0b1f-4cbe-81a9-f0a589e4b5f5)<br>
Kategori işlemleri için Entity Framework ile temel CRUD işlemlerini yapıyoruz.<br><br>

Global alana yazılacak kod;<br>
EntityUrunDbEntities db = new EntityUrunDbEntities();<br>

CRUD işlemleri için yazılacak kodlar;<br><br>

private void btnListele_Click(object sender, EventArgs e)<br>
{<br>
    var kategoriler = db.TBLKATEGORI.ToList();<br>
    dgvKategori.DataSource = kategoriler;<br>
}<br>
<br>
private void btnEkle_Click(object sender, EventArgs e)<br>
{<br>
    TBLKATEGORI t = new TBLKATEGORI();<br>
    t.KategoriAd = txtKategoriAdi.Text;<br>
    db.TBLKATEGORI.Add(t);<br>
    db.SaveChanges();<br>
    MessageBox.Show("Kategori Eklendi");<br>
}<br>
<br>
private void btnSil_Click(object sender, EventArgs e)<br>
{<br>
    int x = Convert.ToInt32(txtKategoriID.Text);<br>
    var ktgr = db.TBLKATEGORI.Find(x);<br>
    db.TBLKATEGORI.Remove(ktgr);<br>
    db.SaveChanges();<br>
    MessageBox.Show("Kategori Silindi");<br>
}<br>
<br>
private void btnGuncelle_Click(object sender, EventArgs e)<br>
{<br>
    int x = Convert.ToInt32(txtKategoriID.Text);<br>
    var ktgr = db.TBLKATEGORI.Find(x);<br>
    ktgr.KategoriAd = txtKategoriAdi.Text;<br>
    db.SaveChanges();<br>
    MessageBox.Show("Kategori Güncellendi");<br>
}<br>
<br>
private void dgvKategori_CellClick(object sender, DataGridViewCellEventArgs e)<br>
{<br>
    try<br>
    {<br>
        txtKategoriID.Text = dgvKategori.Rows[e.RowIndex].Cells[0].Value.ToString();<br>
        txtKategoriAdi.Text = dgvKategori.Rows[e.RowIndex].Cells[1].Value.ToString();<br>
    }<br>
    catch (Exception)<br>
    {<br>
<br>
        throw;<br>
    }       <br>
}<br>
<br>

<hr>

# 🖥️ Bölüm 17 - OOP ile N Katmanlı Mimaride Proje Geliştirme
N Katmanlı Mimari, C# projelerinde kodları farklı katmanlara bölerek daha modüler, okunabilir ve yönetilebilir hale getiren bir mimari modeldir.<br><br>

Bu mimariyi kullanarak:<br>
✔ Kod tekrarını önleriz.<br>
✔ Bağımsız bileşenler oluşturarak her katmanı ayrı geliştirebiliriz.<br>
✔ Bakımı ve test edilmesi kolay bir yapı kurabiliriz.<br><br>

## 📌 Katmanlar Nelerdir?
Genellikle 3 veya daha fazla katmandan oluşur. En yaygın model 3 katmanlı mimaridir:<br><br>
![image](https://github.com/user-attachments/assets/3845693a-6795-49f8-8ea6-8923d6bdbbb9)<br><br>
Burada EntityLayer katmanını da kullanacağız.<br><br>

Katman eklemek için ilgili projeye yeni bir proje ekliyoruz. Seçeceğimiz uygulama ise bir Class Library (.NET Framework) olacaktır. İsmini EntityLayer olarak belirliyoruz.<br>
