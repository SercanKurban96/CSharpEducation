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
