# <img height="50" src="https://user-images.githubusercontent.com/25181517/121405384-444d7300-c95d-11eb-959f-913020d3bf90.png"> Uygulama Geliştirerek C# Öğrenin: A'dan Z'ye Eğitim Seti
👋 Merhabalar, oluşturmuş olduğum bu repo, Murat Yücedağ hocamızın Udemy üzerinden hazırlamış olduğu Uygulama Geliştirerek C# Öğrenin: A'dan Z'ye Eğitim Seti süresince tamamlamış olduğum projeleri içermektedir. Bu eğitimde C# Windows Form Uygulaması'ndan "Merhaba Dünya" ile başlayıp OOP ile N Katmanlı Mimari'de proje geliştirmeye kadar anlatılmaktadır.
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
