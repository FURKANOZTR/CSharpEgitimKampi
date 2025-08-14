using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_DatabaseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region SQL Kurulumu ve SQL Server Management Studio Kurulumu ve Arayüz Kullanımı

            // https://www.microsoft.com/tr-tr/sql-server/sql-server-downloads içerisinden  ekspres sürümünü indirip kuruyoruz.

            // Ardından Basic olan seçeneği seçiyoruz. Kurulum tamamlandıktan sonra Install SSMS ile SQL Server Management Studio'yu indirip kuruyoruz.
            // Visual Studio ile SQL Server Management Studio farklı programlardır.Ama visual Studio 2022 içersinde kurulum yapılınıyor.
            // SQL Server Management Studio, SQL Server veritabanlarını yönetmek için kullanılan bir araçtır. 

            // SQL Server Management Studio 21 açarız server adı olarak FURKAN-34\\SQLEXPRESS yazıyoruz.
            // Windows Authentication ile bağlanıyoruz. Bu, Windows hesabımızla SQL Server'a bağlanmamızı sağlar.Bağlantı başarılı olursa Nesne Gezgininde veritabanlarını görebiliriz.
            // DataBase kısmında sağ tıklayıp Yeni Veritabanı seçeneğini seçiyoruz.İsmini EgitimKampiDb olarak belirliyoruz ve Tamam diyoruz.veritabanımız oluştu.
            // EgitimKampiDb veritabanına sağ tıklayıp Yeni Sorgu seçeneğini seçiyoruz. Bu, SQL sorgularını yazabileceğimiz bir pencere açar.
            // EgitimKampiDb Tables kısmına sağ tıklayıp Yeni -> Tablo seçeneğini seçiyoruz. Bu, yeni bir tablo oluşturabileceğimiz bir pencere açar.

            // Column Name kısmına sütun adını yazıyoruz. Mesela Id, CategoryName, CategoryDescription gibi.
            // Data Type kısmında sütunun veri tipini seçiyoruz. Mesela Id için int, CategoryName için nvarchar(50), CategoryDescription için nvarchar(200) gibi.
            // Id sütununu Primary Key olarak işaretliyoruz. Bu, bu sütunun benzersiz olduğunu ve her kaydın bu sütunla tanımlanacağını belirtir.
            // Ardından Tabloyu Kaydet butonuna tıklıyoruz. Tablo ismini TblCategory olarak belirliyoruz. Bu, TblCategory adında bir tablo oluşturur.
            // Kaydetmek için Ctrl + S tuşlarına basabiliriz.
            // İlk başta tools menüsünden Options kısmına gelerek tasarımcılar kısmından tablo yeniden oluşturma gerektiren değişiklikleri kaydetmeyi engelle seçeneğini kaldırıyoruz.
            // Sonra Alt tarafta sütün özellikleri kısmında Identity Specification kısmını Yes yapıyoruz. Bu, Id sütununun otomatik artan bir sütun olmasını sağlar.

            // oluşturduğumuz TblCategory tablosuna sağ tıklayıp Verileri Görüntüle seçeneğini seçiyoruz. Bu, tablonun içeriğini görüntüler.
            // verileri dolduruyoruz. Mesela Id: 1, CategoryName: Süt ve Süt Ürünleri, CategoryDescription: Süt ve süt ürünleri kategorisi gibi.

            #endregion

            #region SQL Sorguları
            //--Select / Insert / Update / Delete

            //-- Select bir tabloda istenen sütunları getirmemizi sağlayan SQL sorgusudur
            //-- Select* From TblCategory-- TblCategory tablosundan bütün sütunları getir dedik


            ////--Select * From TblProduct-- yıldız simgesinin üzerine gelirsen bu tablodaki bütün sütunları gösterir

            //-- Select ProductName From TblProduct
            //--Select ProductName,ProductPrice From TblProduct

            //-- Select* From TblProduct WHERE ProductName = 'Sütlaç'-- ilk olarak where if mantıgında çalışır koşulu sağlıyanları alır ve
            //-- SQL de string ifadeler '' tek tırnak içinde olur çünkü karekter olarak görünüyor


            ////--Select * From TblProduct WHERE ProductPrice < 80 And ProductStatus = 1-- And ifadesi && ile aynı anlamda
            ///



            #endregion

            #region Ado.Net, C# ile veritabanı işlemlerini yapmamızı

            // Ado.Net bize C# dilinde SQL yapılarını kulanmamızı sağlayan bir kütüphanedir.
            // Ado.Net ile veritabanı bağlantısı yapabilir, veritabanına sorgular gönderebilir ve veritabanından sonuçlar alabiliriz.

            Console.WriteLine("***** C# Ürün Kategori Bilgi Sistemi *****");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("1- Ürün Kategorileri");
            Console.WriteLine("2- Ürünler");
            Console.WriteLine("3- Siparişler");
            Console.WriteLine("4- Çıkış");
            Console.Write("Lütfen getirmek istediginiz tablo numarasını giriniz: ");
            string tableNumber = Console.ReadLine();
            Console.WriteLine("---------------------------------------------");

            SqlConnection connection = new SqlConnection("Data Source = FURKAN-34\\SQLEXPRESS;initial Catalog=EgitimKampiDb;integrated security=true");
            // SqlConnection sınıfı ile bağlantı oluşturduk.

            //Burada bir nesne oluşturduk. SqlConnection sınıfından bir connection adında nesne oluşturduk.
            // SqlConnection yazısı üzerine geldiğimizde SqlConnection bir sınıf olduğunu anlarız
            // SqlConnection sınıfı, veritabanı bağlantısını temsil eder.
            // Parantez içinde veritabanı bağlantı dizesi (connection string) bulunur.
            // Data Source, veritabanı sunucusunun adını belirtir.Bunu microsoft SQL Server Management Studio'den Nesne Gezginine Bağlandan görebiliriz.
            // initial Catalog, veritabanının adını belirtir. Burada EgitimKampiDb veritabanına bağlanıyoruz.
            // integrated security=true, Windows kimlik doğrulamasını kullanır. Yani SQL Server'a bağlanmak için kullanıcı adı ve şifre yerine Windows hesabımızı kullanır.

            connection.Open(); // Veritabanı bağlantısını açar. Bu işlem başarılı olursa veritabanına bağlanmış oluruz. // Bağlantıyı açmak için Open() metodunu kullanırız.

            SqlCommand command = new SqlCommand("Select * From TblCategory", connection); // SQLcommand sınıfından bir command adında nesne oluşturduk.
            // Parantez içinde SQL sorgusunu yazdık. Bu sorgu, TblCategory tablosundaki tüm verileri getirir.
            // Parantez içinde connection nesnesini de verdik. Bu, komutun hangi veritabanı bağlantısını kullanacağını belirtir.

            SqlDataAdapter adapter = new SqlDataAdapter(command); // SqlDataAdapter sınıfından bir adapter adında nesne oluşturduk.
            // SqlDataAdapter komutu bize C# ile SQL sorgusu arasında köprü görevi görür.
            // Parantez içinde command nesnesini verdik. Bu, SqlDataAdapter'ın hangi SQL komutunu kullanacağını belirtir.

            DataTable dataTable = new DataTable(); // DataTable sınıfından bir dataTable adında nesne oluşturduk.
            // DataTable, veritabanından gelen verileri tutmak için kullanılır. Yani veritabanından gelen verileri bir tablo şeklinde saklar.
            // Verilerimizi gecici ram bellekte tutar.

            adapter.Fill(dataTable); // adapter nesnesinin Fill metodunu kullanarak dataTable nesnesine verileri doldurduk.
            // Fill metodu, SqlDataAdapter'ın veritabanından gelen verileri DataTable'a doldurmasını sağlar.

            connection.Close(); // Veritabanı bağlantısını kapatır. Bu işlem, veritabanı ile olan bağlantıyı sonlandırır.

            foreach (DataRow row in dataTable.Rows) // DataTable'ın Rows özelliği, tablodaki satırları temsil eder.
                                                     // var niye kullanıyoruz çünkü item değişkeninin tipini bilmiyoruz.
                                                     // DataRow, DataTable'daki her bir satırı temsil eder. Yani veritabanından gelen her bir kaydı temsil eder.
            {
                //Console.WriteLine(item); // Bu bize DataRow nesnesinin adresini verir. Yani bu satırın bellekteki yerini gösterir.
                foreach(var item in row.ItemArray) // ItemArray özelliği, DataRow'daki her bir sütunu temsil eder. Yani veritabanından gelen her bir sütunu temsil eder.
                {
                    Console.Write(item.ToString()); // item.ToString() ile her bir sütunun değerini ekrana yazdırırız.String'e çeviriyoruz çünkü item değişkeni object tipinde.
                }
                Console.WriteLine(); // Her satırdan sonra yeni bir satıra geçeriz. Yani her bir DataRow'un değerlerini ekrana yazdırırız.
            }
            #endregion

            Console.Read(); 
        }
    }
}
