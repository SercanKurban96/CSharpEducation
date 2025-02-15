# <img height="50" src="https://user-images.githubusercontent.com/25181517/121405384-444d7300-c95d-11eb-959f-913020d3bf90.png"> Uygulama Geliştirerek C# Öğrenin: A'dan Z'ye Eğitim Seti
👋 Merhabalar, oluşturmuş olduğum bu repo, Murat Yücedağ hocamızın Udemy üzerinden hazırlamış olduğu Uygulama Geliştirerek C# Öğrenin: A'dan Z'ye Eğitim Seti süresince tamamlamış olduğum projeleri içermektedir. Bu eğitimde C# Windows Form Uygulaması'ndan "Merhaba Dünya" ile başlayıp OOP ile N Katmanlı Mimari'de proje geliştirmeye kadar anlatılmaktadır.
<br><hr>
# 🖥️ Bölüm 1 - Temel Araç Kullanımları
Görsel programlamada arayüz oluşturabilmek için ihtiyacımız olan bileşenlerdir. C# formda araçlar araç kutusu (toolbox) üzerinden eklenir.
<br>
### ⚙️ Button
Olayları gerçekleştirmek için kullanılan tetikleme aracıdır. Bir lambayı açıp kapatmak için ihtiyacımız olan düğme aslında bir butondur.
### ⚙️ Label
Formda özellikle açıklamalar için kullanılan, etiket görevi gören araçtır. Amaç ilgili bileşen hakkında bilgi vermektir.
### ⚙️ TextBox
Veri girişi yapmak için kullanılan araçtır. Yapı olarak Label aracının özelliklerine çok benzer.
### ⚙️ ComboBox
Çoklu seçim kutusu olarak kullanılan araçtır. Bir listede istenilen değerlerden herhangi birini seçtirmek için kullanılır.
### ⚙️ ListBox
Verilerin listelenmesi için kullanılan araçtır. Yapı olarak ComboBox aracına benzer. Listelenecek veriler <<items.add>> komutu kullanılarak ListBox aracına yansıtılır.
### ⚙️ MaskedTextBox
Maskeli metin kutusu anlamına gelir. TextBox aracının bazı nitelikler alan formatıdır. Telefon numarası, TC kimlik numarası, posta kodu gibi formatlarda kullanılabilir.
### ⚙️ PictureBox
Formda resim kutusu olarak kullanılan araçtır. Amaç forma resim dosyaları ekleyip görüntüleyebilmektir.
### ⚙️ DateTimePicker
Kullanıcının bir tarih ve saat seçmesine ve bu tarih ve saati belirtilen biçimde görüntülemesine izin vermek için kullanılır. DateTimePicker veri doğrulama işleminin büyük bir kısmını otomatik olarak işlediğinden tarih ve saatlerle çalışmayı kolaylaştırır.
### ⚙️ CheckBox
Kontrol kutusu anlamına gelir. Çoklu seçim durumlarında kullanılmaktadır.
### ⚙️ RadioButton
Çoklu seçim işlemlerinde sadece 1 tane değer seçimine izin veren araçtır. Form üzerinde bulunan CheckBox araçlarının tamamı seçilebilirken, RadioButton ise aynı anda sadece 1 tane seçilebilmektedir.
### ⚙️ RichTextBox
Zengin metin kutusu denetimini temsil eder. Kullanıcı metin girebilir ve düzenleyebilir. Standart TextBox denetimden daha gelişmiş biçimlendirme özellikleri de sağlar.
### ⚙️ Panel
Koleksiyonları gruplandırmak için kullanılır. Çoklu seçimlerden panelin içinde yer alan RadioButton ile panelde bulunmayan RadioButton araçları aynı anda seçebilme özelliğini sağlar.
### ⚙️ GroupBox
Araçları gruplandırmak için kullanılan form aracıdır. Amaç özellikle birbiriyle ilişkili olan bileşenleri bir arada tutabilmektir.

# 🖥️ Bölüm 2 - Değişkenler
C#'ta değişkenler, verileri saklamak için kullanılan isimlendirilmiş bellek alanlarıdır. Değişkenler belirli bir veri tipine sahiptir ve o veri tipine uygun değerler alabilirler.
<br>

## C#'ta Temel Veri Türleri ve Değişkenler
<b>1. Tamsayı Türleri</b><br>
byte (0 - 255)<br>
sbyte (-128 ile 127)<br>
short (-32,768 ile 32,767)<br>
ushort (0 ile 65,535)<br>
int (-2,147,483,648 ile 2,147,483,647)<br>
uint (0 ile 4,294,967,295)<br>
long (-9 kentilyon ile +9 kentilyon)<br>
ulong (0 ile çok büyük bir pozitif sayı)<br>
