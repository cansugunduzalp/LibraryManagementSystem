Kütüphane Yönetim Sistemi
Bu proje, bir kütüphanenin kitap ve yazar işlemlerini yönetmek için geliştirilmiş bir ASP.NET Core MVC uygulamasıdır. Proje, kitap ve yazar bilgilerini ekleme, düzenleme, silme ve listeleme gibi temel CRUD (Create, Read, Update, Delete) işlemlerini destekler.
Proje Özellikleri
Kitap Yönetimi:
Kitapları listeleme.
Yeni kitap ekleme.
Kitap detaylarını görüntüleme.
Kitap bilgilerini düzenleme.
Kitap silme.
Yazar Yönetimi:
Yazarları listeleme.
Yeni yazar ekleme.
Yazar detaylarını görüntüleme.
Yazar bilgilerini düzenleme.
Yazar silme.

MVC Yapısı:
Model-View-Controller (MVC) mimarisi kullanılmıştır.
ViewModel'ler kullanılarak veri taşınması sağlanmıştır.

OOP Prensipleri:
Nesne yönelimli programlama (OOP) prensipleri uygulanmıştır.
Layout ve PartialView:
Projede ortak bir Layout kullanılmıştır.
PartialView'lar kullanılarak kod tekrarı önlenmiştir.

Footer:

Sayfanın altında sabit bir footer bulunur. Bu footer, projenin haklarının size ait olduğunu belirtir.

Proje Kurulumu
Projeyi yerel makinenizde çalıştırmak için aşağıdaki adımları izleyin:

Gereksinimler
.NET 6.0 SDK veya üzeri.

Visual Studio 2022 veya Visual Studio Code.

Adımlar
Projeyi İndirin:

Projeyi GitHub'dan klonlayın veya ZIP olarak indirin.
Projeyi İndirin:

Projeyi GitHub'dan klonlayın veya ZIP olarak indirin.

git clone https://github.com/sizin-kullanici-adiniz/LibraryManagementSystem.git
Proje Dizinine Gidin:

cd LibraryManagementSystem
Bağımlılıkları Yükleyin:

Proje bağımlılıklarını yüklemek için aşağıdaki komutu çalıştırın:
dotnet restore
Veritabanını Oluşturun (Eğer kullanıyorsanız):

Projede şu an için veritabanı kullanılmamaktadır. Ancak gelecekte Entity Framework Core ile entegrasyon yapılabilir.

Projeyi Çalıştırın:

Projeyi çalıştırmak için aşağıdaki komutu kullanın:
dotnet run
Alternatif olarak Visual Studio'da projeyi açıp F5 tuşuna basarak çalıştırabilirsiniz.

Tarayıcıda Görüntüleyin:

Proje çalıştıktan sonra tarayıcınızda https://localhost:5001 veya http://localhost:5000 adresine gidin.

Proje Yapısı
Proje klasör yapısı aşağıdaki gibidir:

LibraryManagementSystem/
│
├── Controllers/          # Controller sınıfları
│   ├── BookController.cs
│   └── AuthorController.cs
│
├── Models/               # Model ve ViewModel sınıfları
│   ├── Book.cs
│   ├── Author.cs
│   ├── BookViewModel.cs
│   └── AuthorViewModel.cs
│
├── Views/                # View dosyaları
│   ├── Book/
│   │   ├── List.cshtml
│   │   ├── Details.cshtml
│   │   ├── Create.cshtml
│   │   ├── Edit.cshtml
│   │   └── Delete.cshtml
│   ├── Author/
│   │   ├── List.cshtml
│   │   ├── Details.cshtml
│   │   ├── Create.cshtml
│   │   ├── Edit.cshtml
│   │   └── Delete.cshtml
│   ├── Shared/           # Layout ve PartialView'lar
│   │   ├── _Layout.cshtml
│   │   └── _Footer.cshtml
│   └── Home/             # Ana sayfa ve hakkında sayfaları
│       ├── Index.cshtml
│       └── About.cshtml
│
├── wwwroot/              # Statik dosyalar (CSS, JS, resimler)
│
├── Program.cs            # Uygulama giriş noktası
├── Startup.cs            # Uygulama yapılandırması
└── README.md             # Proje dokümantasyonu

