using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Kodlara ait kütüphaneleri üst tarafda ekledik

namespace _01_MainSubjects //Projeye verdigimiz isim
{
    internal class Program //
    {
        static void Main(string[] args)
        {

            #region Yazdırma Komutları
            // region ve endregion bir bütüne alıyor
            //--------Yazdırma Komutları---------

            //Kodlarımızı main denilen method 'un içerisine yazıcaz
            // Console.WriteLine("Merhaba Dünya"); //Eger ekleyecegimiz yapının method oldugunu mor küp sembolü ile anlarız ve Her satır sonu noktalı virgül kullanılır
            // Console.Write("Hello World"); //write sadece yazar aynı satırda kalır writeline bir alt satıra geçer 

            //Console.WriteLine("****** Yemek Kategorileri ******");
            //Console.WriteLine();
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Soğuk Başlangıçlar");
            //Console.WriteLine("4-Salatalar"); // ctrl + D yaparsan o satırı aşşağdaki satıra yapıştırır
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("6-İçecekler");
            //Console.WriteLine("");
            //Console.WriteLine("****** Yemek Kategorileri ******"); 

            // ctrl + ö yada ctrl + K yada ctrl + C Açıklama satırı yapar
            #endregion

            #region String Değişkenler // Variable
            //-----------Değişkenler-----------
            // Geçici olarak Ram da tutulan ve istenildigi zaman işlem yapılan degerlerdir

            // Değişken_Türü Değişken_adi;
            // string alfabetik türde verileri tutar
            //string name;
            //name = "Furkan"; //Ramde değişken oluşturuldu ama ekranda göstermez
            //Console.Write(name); //Ramdeki değer ekrana gelir

            //string customerName = "Halil"; //Değişken adlandırırken camelCase yapısı kullandık
            //string customerSurname = "Bertizlioğlu"; // 1.Değer atama yöntemi
            //string customerPhone= "+90 500 400 30 20";
            //string customerEmail, district, city; //Bir satırda aynı türde birden fazla değişken tanımladık

            //customerEmail = "deneme@gmail.com"; // 2.Değer atama yöntemi
            //district = "onikişubat";
            //city = "maraş";

            //Console.WriteLine("**** Rezervasyon Kartı ****");
            //Console.WriteLine();
            //Console.WriteLine("---------------------------------------");
            //Console.WriteLine("Müsteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("Email: " + customerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);
            //Console.WriteLine("---------------------------------------");

            //customerName = "Furkan"; //Aynı isimli iki değişken oluşturduk Bilgisayar yukarıdan aşşagı okudugu için ilk halil sonra furkanı yazdırır
            //                         //yani customerName yeni değer atadı
            //customerSurname = "ÖZTÜRK";
            //customerPhone = "+90 400 300 20 10";
            //customerEmail = "test@gmail.com";
            //district = "Sapanca";
            //city = "Sakarya";

            //Console.WriteLine();
            //Console.WriteLine("---------------------------------------");
            //Console.WriteLine("Müsteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("Email: " + customerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);
            //Console.WriteLine("---------------------------------------");



            #endregion

            #region Int Değişkenler

            // int tam sayı değişkenleri
            //int number = 24;
            //Console.WriteLine(number);

            //int hamburgerPrice = 300;
            //int cokePrice = 35;
            //int waterPrice = 10;
            //int friesPrice = 50;
            //int pizzaPrice = 250;
            //int lemonadePrice = 30;

            //Console.WriteLine("**** Restoran Menü Fiyatı ****");
            //Console.WriteLine();
            //Console.WriteLine("-----Hamburger Fiyatı: " + hamburgerPrice + " TL");
            //Console.WriteLine("-----Pizza Fiyatı: " + pizzaPrice + " TL");
            //Console.WriteLine("-----Kola Fiyatı: " + cokePrice + " TL");
            //Console.WriteLine("-----Limonata Fiyatı: " + lemonadePrice + " TL");
            //Console.WriteLine("-----Su Fiyatı: " + waterPrice + " TL");
            //Console.WriteLine("-----Kızartma Patates Fiyatı: " + friesPrice + " TL");
            //Console.WriteLine();
            //Console.WriteLine("**** Restoran Menü Fiyatı ****");

            //Console.WriteLine();
            //int hamburgerCount = 3;
            //int cokeCount = 3;
            //int waterCount = 3;
            //int pizzaCount = 0;
            //int friesCount = 1;
            //int lemonadeCount = 0;

            //int totalHamburgerPrice = (hamburgerCount * hamburgerPrice);
            //int totalWaterPrice = (waterCount * waterPrice);
            //int totalPizzaPrice = (pizzaCount* pizzaPrice);
            //int totalFriesPrice = (friesCount* friesPrice);
            //int totalCokePrice = (cokeCount * cokePrice);
            //int totalLemonadePrice = (lemonadeCount * lemonadePrice);

            //int totalPrice = totalWaterPrice + totalPizzaPrice + totalFriesPrice + totalCokePrice + totalHamburgerPrice + totalLemonadePrice;

            //Console.WriteLine("---------------------------------------");
            //Console.WriteLine("Hamburger Tutarı: " + totalHamburgerPrice + " TL");
            //Console.WriteLine("Pizza Tutarı: " + totalPizzaPrice + " TL");
            //Console.WriteLine("Kızartma Tutarı: " + totalFriesPrice + " TL");
            //Console.WriteLine("Lemonata Tutarı: " + totalLemonadePrice + " TL");
            //Console.WriteLine("Kola Tutarı: " + totalCokePrice + " TL");
            //Console.WriteLine("Su Tutarı: " + totalWaterPrice + " TL");

            //Console.WriteLine();
            //Console.WriteLine("Toplam Tutar: " + totalPrice + " TL");




            #endregion

            Console.Read(); // Read methodu cmd içinde kod açılır ve biz enter tuşuna basana kadar cmd kapanmaz
        }
    }
}




