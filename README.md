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
  <img src="https://imgyukle.com/f/2022/11/24/JIsaxf.png" width="50%">
  <br/>
  <a>
  Projede API sistemi sıfırdan yazıldığı için API destekleyen tüm platformlardan istekler gönderilebilir.
  </a>
  <img src="https://imgyukle.com/f/2022/11/24/JIsLbS.png" width="50%">
  <br/>
  <section>
  API metotları localhostta Postman ve Swagger UI ile test edilmiştir.
  </section>
  <img src="https://imgyukle.com/f/2022/11/24/JIsjgs.png" width="50%">
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

# Simple Personal Record Application with SQLite

The user enters the name, surname and salary information of the staff on the console. The data are transferred to the database. "CREATE", "READ", "UPDATE", "DELETE" operations can be done on the data. The database can be viewed through DB Browser (SQLite).

## Project Requirements

* Python 3.x
* DB Browser for SQLite
* Spyder, Visual Code oth. Python supporting editors

## How to Download?

First of all, <a href="https://sqlitebrowser.org">DB Browser</a> must be installed on the computer to view the database in detail. If it is installed, the download process is started by clicking on "Download ZIP" from the project page to the Code section.

## How to Operate?
We extract the downloaded "SQLite_ConsolApp_Personel-main.zip" file to a folder. We open the file named "SQLlite_ConsolApp.py" in a Python supported editor and run it.
