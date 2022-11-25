<section>
  <div>
    <img src="https://miro.medium.com/max/750/1*zc1BKfAHkpvrZlHPbUvuYA.png" width="28%">
    <img src="http://www.farukerdem.com/wp-content/uploads/2020/09/SQLSErver.png" width="28%">
    <img src="https://edvanberliansa.files.wordpress.com/2016/10/jsonlogo.png" width="20%">
  </div>
</section>

# Katmanlı Mimari ile .NET Core REST API Projesi

<section>
  .NET Core Web ve Windows Form uygulamalarından girilen müşteri verisi ve isteklere göre "GET","POST","PUT","DELETE" metotları üzerinden işlemler yapılır.
</section>

<br/>
<div>
  <section>
  2021 yılı yaz stajımda, <a href="https://www.mekaglobal.com/tr">MEKA</a> şirketinde, farazi "EnsGlobal" adı altında geliştirmiş olduğum REST API projesidir. Proje yazılırken nesne yönelimli programlama ve katmanlı mimari olmasına önem gösterilmiştir.
  </section>
  <br/>
  <img src="https://imgyukle.com/f/2022/11/24/JIsaxf.png" width="70%">
  <br/>
  <a>
  Projede API sistemi sıfırdan yazıldığı için API destekleyen tüm platformlardan istekler gönderilebilir.
  </a>
  <img src="https://imgyukle.com/f/2022/11/24/JIsLbS.png" width="80%">
  <br/>
  <section>
  API metotları localhostta Postman ve Swagger UI ile test edilmiştir.
  </section>
  <br/>
  <img src="https://imgyukle.com/f/2022/11/24/JIsjgs.png" width="80%">
  <br/>
</div>

## Proje Gereksinimleri

* .NET 5.0
* Microsoft SQL Server
* Visual Studio

## Nasıl İndirilir?

İlk olarak veritabanını detaylı şekilde çalıştırabilmek ve görüntüleyebilmek için <a href="https://visualstudio.microsoft.com/tr/">Visual Studio</a> ve <a href="https://www.microsoft.com/tr-tr/sql-server/sql-server-downloads">Microsoft SQL Server</a> kurulu olmalıdır. Kurulu ise proje sayfasından Code kısmına gelip "Download ZIP"e tıklanarak indirme işlemini başlatılır.

## Nasıl Çalıştırılır?

İndirdiğimiz "EnsGlobal_REST_API-main.zip" dosyasını bir klasöre çıkartırız. Gerekli IIS, MSSQL Server ve Windows ayarlarını yaptıktan sonra projeleri çalıştırınız. Başlatma seçeneği olarak her üç projeyi de dahil ediniz. 

<hr/>

# .NET Core REST API Project with Layered Architecture

According to the customer data and requests entered from .NET Core Web and Windows Form applications, operations are performed through the "GET","POST","PUT","DELETE" methods. It is a REST API project that I developed under the putative name "EnsGlobal" at MEKA during my summer internship in 2021. While writing the project, importance was given to object-oriented programming and layered architecture. Since the API system was written from scratch in the project, requests can be sent from all platforms that support the API. API methods have been tested on localhost with Postman and Swagger UI.

## Project Requirements

* .NET 5.0
* Microsoft SQL Server
* Visual Studio

## How to Download?

First of all, <a href="https://visualstudio.microsoft.com/tr/">Visual Studio</a> and <a href="https://www.microsoft.com/tr-tr/sql-server/sql-server-downloads">Microsoft SQL Server</a> must be installed in order to run and view the database in detail. If it is installed, go to the Code section on the project page and click "Download ZIP" to start the download process.

## How to Operate?
We extract the downloaded "EnsGlobal_REST_API-main.zip" file to a folder. After making the necessary IIS, MSSQL Server and Windows settings, run the projects. Include all three projects as launch options.
