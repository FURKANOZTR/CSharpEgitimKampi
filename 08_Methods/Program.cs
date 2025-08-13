using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Void Methods
            // Method alsında bir fonksiyon, bir işlevdir. C dilinde de fonksiyonlara benzer bir yapı vardır. C# Örnek Methods Parse bir metodudur.          
            // Methodlar, kodun tekrarını önlemek ve kodu daha okunabilir hale getirir.Methodların sonunda () parantezler bulunur. Parantezler içinde parametreler bulunabilir.
            // Methodlar C# da mor küp olarak görünür.
            // 1-Geriye değer döndüren methodlar 2-Geriye değer döndürmeyen methodlar(Void) olarak ikiye ayrılır.

            //void customerList() // Methodun üstüne gelince kilit işareti görünür bu methodun private olduğunu gösterir.
            //{
            //    Console.WriteLine("Ali Yıldız");
            //    Console.WriteLine("Ayşe Yıldız");
            //    Console.WriteLine("Veli Çınar");
            //    Console.WriteLine("Hakan Öztürk"); //Ekrana bir şey yazdırmaz Çünkü customerList() metodu çağrılmadı.
            //}

            //customerList(); // customerList() metodu çağrıldı. Ekrana yazdırma işlemi gerçekleşti.

            //Console.WriteLine();

            //for(int i = 1; i <= 5; i++)
            //{
            //    customerList(); // customerList() metodu 5 kez çağrıldı. Ekrana yazdırma işlemi 5 kez gerçekleşti.
            //}

            //void Sum() // Mehodları adlandırırken PascalCase kullanılır. Yani ilk harf büyük, sonraki harfler küçük yazılır.
            //{ 
            //    int x = 10, y = 20;
            //    int result = x + y;
            //    Console.WriteLine("Toplam: " + result); // Ekrana toplamı yazdırır.
            //}

            //Sum(); // Sum() metodu çağrıldı. Ekrana toplamı yazdırma işlemi gerçekleşti.










            #endregion

            #region Geriye Değer Döndürmeyen String Parametreli Methodlar

            //void Write(string customerName) // parametrenin ingilizcesi argumenttir. Parametreler methodların içine yazılır.
            //{
            //    Console.WriteLine($"Merhaba, C# Programlama Dili! ve Senin İsmin: {customerName}");
            //}

            //Write("Muhammed Furkan Öztürk");

            //void CustomerCard(string name, string surname)
            //{
            //    Console.WriteLine($"Müşteri Kartı Oluşturuldu: {name} {surname}");
            //}

            ////CustomerCard(); // Böyle hata verir çünkü parametreler boş bırakıldı.iki parametre göndermelisiniz.
            //CustomerCard("Nimet", "Öztürk");
            //CustomerCard("Bekir", "Öztürk");

            #endregion

            #region Geriye Değer Döndürmeyen Int Parametreli Methodlar

            //void Sum(int number1, int number2) // Methodun geri dönüş tipi int. Yani bu method bir int değer döndürecek.
            //{
            //    int result = number1 + number2; // return ifadesi ile geri dönüş yapılır. return ifadesi ile methoddan çıkılır.
            //    Console.WriteLine($"Toplam: {result}"); // Ekrana toplamı yazdırır.
            //}

            //Sum(10, 20); // Sum() metodu çağrıldı. Ekrana toplamı yazdırma işlemi gerçekleşti.

            #endregion

            #region Geriye Değer Döndüren String Parametreli ve Parametresiz Methodlar

            //string CustomerName(string name, string surname) // Methodun geri dönüş tipi string. Yani bu method bir string değer döndürecek.
            //{
            //    return $"Müşteri Adı: {name} {surname}"; // return ifadesi ile geri dönüş yapılır. return ifadesi ile methoddan çıkılır.
            //}

            //CustomerName("Furkan", "Öztürk"); //Bir karşılıgı olmaz sadece değeri geri dönderdi. Ekrana yazdırma işlemi gerçekleşmedi.

            //string CustomerName(string name, string surname) 
            //{
            //    return $"Müşteri Adı: {name} {surname}"; 
            //}

            //Console.WriteLine(CustomerName("Furkan", "Öztürk")); // Böyle yaparsak ekrana yazdırma işlemi gerçekleşir. Çünkü CustomerName() metodu çağrıldı
            //                                                     // ve geri dönüş değeri Console.WriteLine() ile ekrana yazdırıldı.

            //string StudentCard()
            //{
            //    string name = "Furkan";
            //    string surname = "Öztürk";

            //    return $"{name} {surname}";
            //}

            //Console.WriteLine(StudentCard()); // StudentCard() metodu çağrıldı. Ekrana yazdırma işlemi gerçekleşti.

            //string CountryCard1(string countryName, string capital, string flagColor)
            //{
            //    string cardKnow = $"Ülke: {countryName} / Başkent: {capital} / Bayrak Rengi: {flagColor}";
            //    return cardKnow;
            //}

            //string CountryCard2(string countryName, string capital, string flagColor)
            //{
            //    return $"Ülke: {countryName} / Başkent: {capital} / Bayrak Rengi: {flagColor}";
            //}

            //Console.Write("Lütfen Ülke Adını Giriniz: ");
            //string countryNameRead = Console.ReadLine();

            //Console.Write("Lütfen Başkent Adını Giriniz: ");
            //string capitalRead = Console.ReadLine();

            //Console.Write("Lütfen Bayrak Rengini Giriniz: ");
            //string flagColorRead = Console.ReadLine();

            //Console.WriteLine(CountryCard1(countryNameRead, capitalRead, flagColorRead)); // Bu şekilde çağırırsak ekrana yazdırma işlemi gerçekleşmez. Çünkü geri dönüş değeri yok.   

            //string read = CountryCard2(countryNameRead, capitalRead, flagColorRead); // Bu şekilde çağırırsak ekrana yazdırma işlemi gerçekleşmez. Çünkü geri dönüş değeri yok.   
            //Console.WriteLine(read);  // başka bir yöntemle ekrana yazdırma işlemi gerçekleşir. Çünkü geri dönüş değeri var.

            //Console.WriteLine(CountryCard1("Türkiye", "Ankara", "Kırmızı-Beyaz")); // Bu şekilde çağırırsak ekrana yazdırma işlemi gerçekleşir. Çünkü geri dönüş değeri var.



            #endregion

            #region Örnek Uygulama

            //int ExamResult1(string student, int exam1, int exam2, int exam3) // Methodun geri dönüş tipi int. Yani bu method bir int değer döndürecek.
            //{
            //    int result = (exam1 + exam2 + exam3) / 3; // return ifadesi ile geri dönüş yapılır. return ifadesi ile methoddan çıkılır.
            //    Console.WriteLine($"Öğrenci: {student} / Sınav Sonucu: {result}");
            //    return result; // Geri dönüş değeri olarak result değişkenini döndürür.
            //}

            //ExamResult1("Furkan Öztürk", 80, 90, 100); // ExamResult() metodu çağrıldı. Ekrana yazdırma işlemi gerçekleşti. 

            string ExamResult2(string student, int exam1, int exam2, int exam3) // Methodun geri dönüş tipi int. Yani bu method bir int değer döndürecek.
            {
                int result = (exam1 + exam2 + exam3) / 3;
                if (result >= 50)
                {
                    return $"Öğrenci: {student} / Başarılı / Sınav Sonucu: {result}";
                }
                else
                {
                    return $"Öğrenci: {student} / Başarısız / Sınav Sonucu: {result}";
                }
            }
            Console.WriteLine(ExamResult2("Furkan Öztürk", 80, 90, 100)); 
            Console.WriteLine(ExamResult2("Furkan Öztürk", 20, 10, 5));











            #endregion
        }
    }
}
