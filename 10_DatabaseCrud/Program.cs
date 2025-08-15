using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // 4 Temel veritabanı işleme methodları --> (Creat - Read - Update - Delete) // CRUD bu metodların baş harflerinden oluşur.

            #region Kategori Ekleme İşlemi
            //Console.WriteLine("***** Menü Sipariş İşlem Paneli *****");
            //Console.WriteLine();


            //Console.WriteLine("-------------------------------------");
            //Console.Write("Eklemek İstediginiz Kategori Adı: ");
            //string categoryName = Console.ReadLine();

            //SqlConnection con = new SqlConnection("Data Source=FURKAN-34\\SQLEXPRESS;Initial Catalog=EgitimKampiDb;Integrated Security=True"); 
            //// connection kısaltılmı olarak con kullanıldı.

            //con.Open(); // Bağlantı açıldı.
            //SqlCommand cmd = new SqlCommand("INSERT into TblCategory (CategoryName) values (@p1)", con); // @ SQL'de parametre kullanımı için kullanılır.
            //cmd.Parameters.AddWithValue("@p1", categoryName);

            //// SqlCommand cmd = new SqlCommand("INSERT into TblCategory (productname,price,stock) values (@p1,@p2,@p3)", con); 
            //// Bu üste 3 parametre sırasıyla productname, price ve stock isimli kolanlara veri ekleniyor.

            //cmd.ExecuteNonQuery(); // ExecuteNonQuery metodu, SQL sorgusunu koşulsuz olarak çalıştırır ve etkilenen satır sayısını döner.
            //con.Close(); // Bağlantı kapatıldı.

            //Console.WriteLine("Kategori Eklendi.");


            #endregion

            #region Ürün Ekleme İşlemi
            //Console.WriteLine("***** Menü Sipariş İşlem Paneli *****");
            //Console.WriteLine();


            //Console.WriteLine("-------------------------------------");
            //// bool productStatus;

            //Console.Write("Eklemek İstediginiz Ürün Adı: ");
            //string productName = Console.ReadLine();

            //Console.Write("Eklemek İstediginiz Ürün Fiyatı: ");
            //decimal productPrice = decimal.Parse(Console.ReadLine());

            //SqlConnection baglanmaNesnesi = new SqlConnection("Data Source=FURKAN-34\\SQLEXPRESS;Initial Catalog=EgitimKampiDb;Integrated Security=True");
            //baglanmaNesnesi.Open();
            //SqlCommand komutNesnesi = new SqlCommand("insert into TblProduct (ProductName,ProductPrice,ProductStatus) values (@productName,@productPrice,@productStatus)", baglanmaNesnesi);

            //komutNesnesi.Parameters.AddWithValue("@productName", productName);
            //komutNesnesi.Parameters.AddWithValue("@productPrice", productPrice);
            //komutNesnesi.Parameters.AddWithValue("@productStatus", true); // ürünü durumu başlangıçta true olarak ayarlıyoruz.

            //komutNesnesi.ExecuteNonQuery();
            //baglanmaNesnesi.Close();

            //Console.WriteLine("Ürün Eklendi.");
            #endregion

            #region Ürün Listeleme İşlemi

            //SqlConnection connection = new SqlConnection("Data source=FURKAN-34\\SQLEXPRESS;initial catalog=EgitimKampiDb;integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("SELECT * FROM TblProduct", connection);
            //SqlDataAdapter dataAdapter = new SqlDataAdapter(command); // SqlDataAdapter, veritabanından veri almak için kullanılır. SQL'den verileri C#'a taşır.
            //DataTable dataTable = new DataTable(); // DataTable, verileri saklamak için kullanılır.Verileri gecici olarak saklar.
            //dataAdapter.Fill(dataTable); // DataAdapter, verileri DataTable'a doldurur.

            //foreach (DataRow row in dataTable.Rows) // DataTable'daki her bir satırı dolaşır.
            //{
            //    foreach (var item in row.ItemArray) // ItemArray, DataRow içindeki tüm sütun değerlerini bir dizi olarak döner. Var kullandık çünkü item'ın tipi belli değil.
            //    {
            //        Console.Write(item.ToString() + " "); // ToString() metodu, veriyi string olarak döner.
            //    }
            //    Console.WriteLine(); // Her satırdan sonra yeni bir satıra geçer.
            //}
            //connection.Close(); // Bağlantı kapatıldı.
            #endregion

            #region Ürün Silme İşlemi

            //Console.Write("Lütfen silmek istediğiniz ürün id: ");
            //int productId = int.Parse(Console.ReadLine());

            //SqlConnection con = new SqlConnection("Data source=FURKAN-34\\SQLEXPRESS;initial catalog=EgitimKampiDb;integrated security=true");
            //con.Open();

            //SqlCommand cmd = new SqlCommand("DELETE FROM TblProduct WHERE ProductId = @productId", con);
            //cmd.Parameters.AddWithValue("@productId", productId);  // addWithValue, SQL sorgusundaki parametreyi doldurmak için kullanılır.
            //cmd.ExecuteNonQuery(); // ExecuteNonQuery metodu, SQL sorgusunu koşulsuz olarak çalıştırır ve etkilenen satır sayısını döner.

            //con.Close(); // Bağlantı kapatıldı.

            //Console.WriteLine("Ürün Silindi.");

            #endregion

            #region Ürün Güncelleme İşlemi

            Console.Write("Lütfen güncellenecek ürün idsini giriniz: ");
            int productId = int.Parse(Console.ReadLine());
            //Kullanıcıdan güncellenecek ürünün ID değerini ister.
            //Console.ReadLine() ile gelen veri string olduğundan int.Parse() ile tam sayıya çevirir.
            //Bu ID, SQL sorgusundaki WHERE ProductId = @productId kısmında kullanılacak.

            Console.Write("Lütfen güncellenecek ürün adını giriniz: ");
            string productName = Console.ReadLine();

            Console.Write("Lütfen güncellenecek ürün fiyatını giriniz: ");
            double productPrice = double.Parse(Console.ReadLine());

            SqlConnection con = new SqlConnection("Data source=FURKAN-34\\SQLEXPRESS;initial catalog=EgitimKampiDb;integrated security=true");
            con.Open();
            //SqlConnection ile SQL Server veritabanına bağlanır.
            //Data source = FURKAN - 34\\SQLEXPRESS → Bağlanılacak sunucu ve SQL instance ismi.
            //initial catalog = EgitimKampiDb → Bağlanılacak veritabanı ismi.
            //integrated security = true → Windows hesabı ile giriş yapılacağını belirtir.
            //con.Open(); ile bağlantı açılır.

            SqlCommand cmd = new SqlCommand("UPDATE TblProduct SET ProductName = @productName, ProductPrice = @productPrice WHERE ProductId = @productId", con);
            //ProductName(soldaki)
            //Veritabanındaki sütun adı
            //TblProduct tablosunda kayıtlı olan kolon(alan)
            //SQL sorgusunda hangi sütunun güncelleneceğini belirtir.
            //Yani bu, veritabanındaki gerçek alanın ismi.
            // şu üst kısımda SQL DE ProductName sütunandaki eşleşen ıd değerine göre ProductName = @productName oluyor
            // sonra ise cmd.Parameters.AddWithValue("@productName", productName); ile üsteki eşitleme kısmındaki @productName yerine mavi productName geliyor
            // ProductName = productName oluyor ve güncelleme işlemi gerçekleşiyor.


            cmd.Parameters.AddWithValue("@productName", productName); // Burdaki mavi productName üste readline ile kullanıcıdan alınan değeri temsil eder.
            cmd.Parameters.AddWithValue("@productPrice", productPrice); 
            cmd.Parameters.AddWithValue("@productId", productId);
            //@productName(sağdaki)
            //Parametre adı
            //SQL sorgusuna dışarıdan(C# kodundan) gönderilecek değeri temsil eder.
            //Bu bir yer tutucu(placeholder) gibi çalışır.
            //cmd.Parameters.AddWithValue("@productName", productName); satırında, bu parametreye C# tarafındaki productName değişkeninin değeri atanır.

            cmd.ExecuteNonQuery(); // ExecuteNonQuery metodu, SQL sorgusunu koşulsuz olarak çalıştırır ve etkilenen satır sayısını döner.
            //SQL sorgusunu çalıştırır.
            //ExecuteNonQuery() → INSERT, UPDATE, DELETE gibi sonuç döndürmeyen sorgular için kullanılır.
            //Dönen değer, etkilenen satır sayısıdır(örneğin 1 satır güncellenirse 1 döner).

            //ExecuteNonQuery() → SQL sorgusunu uygular, verileri değiştirir, bize kaç satır değiştiğini söyler, ama veri tablosundan satır satır veri getirmez.

            con.Close(); // Bağlantı kapatıldı.

            Console.WriteLine("Ürün Güncellendi.");

            #endregion
        }
    }
}
