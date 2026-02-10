# CvProject – Kişisel Portfolyo Web Uygulaması

Bu proje, **ASP.NET Core MVC** kullanılarak geliştirilmiş,  
**admin panelli ve veritabanı destekli** bir kişisel portfolyo web uygulamasıdır.

Amaç; gerçek bir projeye yakın mimari ile **MVC, EF Core ve Admin Panel** yapısını öğrenmek ve uygulamaktır.

---

## 🚀 Proje Amacı
- ASP.NET Core MVC mimarisini öğrenmek
- Entity Framework Core (Code First) ile CRUD işlemleri yapmak
- Admin Panel + Public (Vitrin) yapısını gerçek projeye yakın kurmak
- Katmanlı ve okunabilir bir proje yapısı oluşturmak

---

## 🛠 Kullanılan Teknolojiler
- ASP.NET Core MVC
- C#
- Entity Framework Core (Code First)
- MS SQL Server
- HTML, CSS
- Bootstrap (Public)
- TailwindCSS (Admin Panel)

---

## ✨ Özellikler

### 🔹 Public (Vitrin)
- Ana Sayfa
- Hakkımda
- Deneyimler
- Hizmetler
- Projeler
- İletişim Formu

### 🔹 Admin Panel
- Dashboard (istatistikler)
- Deneyim CRUD
- Proje CRUD
- Mesaj yönetimi
- İçerik güncelleme

---

## 📸 Ekran Görüntüleri

## 🌐 Public (Vitrin) – Anasayfa
![Anasayfa 1](screenshots/anasayfa1.png)
![Anasayfa 2](screenshots/anasayfa2.png)
![Anasayfa 3](screenshots/anasayfa3.png)
![Anasayfa 4](screenshots/anasayfa4.png)
![Anasayfa 5](screenshots/anasayfa5.png)
![Anasayfa 6](screenshots/anasayfa6.png)

---

## 🧩 Admin Panel – Deneyimler
![Deneyim Listesi](screenshots/deneyimlistesi.png)

---

## 🛠 Admin Panel – Hizmetler
![Hizmetler](screenshots/Hizmetlerim.png)

---

## 📊 Admin Panel – Mesaj İstatistikleri
![Mesaj İstatistik](screenshots/Mesajistatistik.png)

---

## 💬 Admin Panel – Mesaj Ekranı
![Mesaj Ekranı](screenshots/Mesajsekmesi.png)

---

## 📁 Admin Panel – Portfolyo
![Portfolyo](screenshots/PortfolioList.png)

---

## ⭐ Admin Panel – Referanslar
![Referanslar](screenshots/testimonial.png)

---

## ✏️ Admin Panel – Hakkımda Güncelleme
![Hakkımda](screenshots/UpdateAbout.png)

---

## 🧠 Admin Panel – Yetenekler
![Yetenekler](screenshots/YetenekListesi.png)

Eğitim & Teşekkür
--------------------------
Bu proje, M&Y Yazılım Eğitim Akademi Danışmanlık tarafından sağlanan eğitim kapsamında geliştirilmiştir. Değerli katkıları ve öğretileri için Murat Yücedağ hocama teşekkür ederim.


## ⚙️ Kurulum

1. Repoyu klonlayın:
```bash
1- git clone https://github.com/abdullahkanik/CvProject.git
```
2- Projeyi Açın: ResumeProjectDemoNight.sln dosyasını Visual Studio ile açın.
3- Veritabanı Bağlantısını Yapılandırın: appsettings.json dosyasındaki ConnectionStrings bölümünü kendi SQL Server bilgilerinize göre güncelleyin.
4- Migrationları Uygulayın (Veritabanını Oluşturun): Visual Studio'da Package Manager Console'u açın ve şu komutu çalıştırın:
```
update-database
```
5- Projeyi Başlatın: Ctrl + F5 veya F5 tuşuna basarak projeyi tarayıcıda çalıştırın.





