📘 Proje Adı: Kelime Ezberleme Uygulaması (C# Windows Forms)
🧠 Proje Açıklaması
Bu proje, C# dili ve Windows Forms kullanılarak geliştirilen, çoktan seçmeli sorularla kullanıcıların İngilizce kelime ezberlemesini kolaylaştıran bir uygulamadır. Kullanıcı, dışarıdan eklenen sözlük dosyalarından kelimeleri yükler ve test çözmeye başlar. Her doğru cevap 10 puan kazandırır; yanlış cevaplarda doğru seçeneğe ulaşana kadar puan verilmez.

🎯 Özellikler
.txt uzantılı sözlük dosyalarından kelime ve anlamları yükleyebilme

Rastgele sırayla gelen çoktan seçmeli sorular

Her soru için 1 doğru + 3 yanlış cevap seçeneği

Puan hesaplama ve görsel geribildirim

Test sonunda otomatik puan bildirimi

Modern, kullanıcı dostu arayüz (renklendirme ve hizalama)

Tüm programın tek form kapatıldığında sonlanması

🛠️ Kullanılan Teknolojiler
C# (.NET Framework)

Windows Forms (WinForms)

Nesneye Dayalı Programlama (OOP)

Visual Studio IDE

📂 Sözlük Dosya Formatı
Her satır şu şekilde olmalıdır:

css
Kopyala
Düzenle
ingilizceKelime[TAB]turkceAnlam
Örnek:

nginx
Kopyala
Düzenle
computer	bilgisayar
keyboard	klavye
mobile phone	cep telefonu
🚀 Nasıl Çalıştırılır?
Projeyi Visual Studio'da aç

bin\Debug\net48\ klasörüne .txt sözlük dosyalarını koy

Uygulamayı çalıştır (F5)

Sözlük seç → Yükle → Başlat

📌 Notlar
Uygulama bireysel ödev kapsamında geliştirilmiştir

Form1 ana ekran, SoruFormu ise test ekranıdır

lblSoruDurum üzerinden Paint metodu ile hem soru durumu hem puan gösterimi tek Label üzerinde sağlanmaktadır
