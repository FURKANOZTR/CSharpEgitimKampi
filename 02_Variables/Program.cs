using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // üst tarafda başlatın solunda ayarlar simgesinden cmd içinde hangi dosya çalıştırılıcaksa onu seciyoruz
            #region Double Değişkenler
            // Bütün değişkenler String / Int / Char / Double / Decimal / Float / Bool / Var(Variable ın kısaltılmışı bütün değişkenleri kapsar)
            // Ondalık değişenler için Double Float kullanılır
            //double number; // burda numberin altı yeşil ile cizili diyorki the variable 'number' is declared but never used yani number tanımladık ama hiç kullanmadık

            //double number1 = 4.85;
            //Console.WriteLine(number1);

            //Console.WriteLine("***** Fiyat Listesi *****");
            //Console.WriteLine();

            //double applePrice = 14.85, orangePrice = 20.95, strawberryPrice = 45, patatoPrice = 9.74, tomatoPrice = 6.88;

            //Console.WriteLine("---- Elma Birim Fiyatı: " + applePrice + " TL");
            //Console.WriteLine("---- Portakal Birim Fiyatı: " + orangePrice + " TL");
            //Console.WriteLine("---- Çilek Birim Fiyatı: " + strawberryPrice + " TL");
            //Console.WriteLine("---- Patates Birim Fiyatı: " + patatoPrice + " TL");
            //Console.WriteLine("---- Domates Birim Fiyatı: " + tomatoPrice + " TL");
            //Console.WriteLine();
            //Console.WriteLine();

            //double appleGram = 1.245, orangeGram = 2.650, strawberryGram = 0.750, patatoGram = 4.859, tomatoGram = 3.745;
            //double appleTotalPrice = appleGram * applePrice;
            //double orengeTotalPrice = orangeGram * orangePrice;
            //double strawberyTotalPrice = strawberryGram * strawberryPrice;
            //double patatoTotalPrice = patatoGram * patatoPrice;
            //double tomatoTotalPrice = tomatoGram * tomatoPrice;
            ////A Local variable or function named "depişken ismi" is already defined is this scope yani bu süslü parantez içinde bu değişkeni bir kez tanımladın bir daha izin vermem diyor

            //Console.WriteLine("Alınan Ürün: Elma - Birim Fiyati: " + applePrice + " - Gramaj: " + appleGram + " - Toplam Tutar: " + appleTotalPrice);
            //Console.WriteLine("Alınan Ürün: Portakal - Birim Fiyati: " + orangePrice + " - Gramaj: " + orangeGram + " - Toplam Tutar: " + orengeTotalPrice);
            //Console.WriteLine("Alınan Ürün: Çilek - Birim Fiyati: " + strawberryPrice + " - Gramaj: " + strawberryGram + " - Toplam Tutar: " + strawberyTotalPrice);
            //Console.WriteLine("Alınan Ürün: Patates - Birim Fiyati: " + patatoPrice + " - Gramaj: " + patatoGram + " - Toplam Tutar: " + patatoTotalPrice);
            //Console.WriteLine("Alınan Ürün: Domates - Birim Fiyati: " + tomatoPrice + " - Gramaj: " + tomatoGram + " - Toplam Tutar: " + tomatoTotalPrice);

            //double shoppingTotalPrice = appleTotalPrice + orengeTotalPrice + strawberyTotalPrice + patatoTotalPrice + tomatoTotalPrice;
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine("Alışveriş Toplam Tutar: " + shoppingTotalPrice + " TL");

            #endregion

            #region Char Değişkenler 
            // Char karekter türünde bir değişkendir
            //SEZAR ŞİFRELEMEDE bu char türünü kullanırız
            //Char türü tek tırnak ile tanımlanı stringler çift tırnakla tanımlanır

            //char symbol = 'a';
            //Console.WriteLine(symbol);

            #endregion

            #region Input (Klavyeden Veri Girişi - Stringler)

            //Console.WriteLine("***** CSharp Hava Yolları Yolcu Bilgisi *****");
            //Console.WriteLine();

            //// Diyelim bir yazıyı bütün kodda değiştireceksin ctrl + F yap ve orada iki sütun çıkacakdır ilk satır değiştirilecek kelime 2.satır yeni kelime

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;

            //Console.Write("Yolcu Adi: ");
            //passengerName = Console.ReadLine();

            //Console.Write("Yolcu Soyadi: ");
            //passengerSurname = Console.ReadLine();

            //Console.Write("İlçe Bilgisi: ");
            //passengerDistrict = Console.ReadLine();

            //Console.Write("İl Bilgisi: ");
            //passengerCity = Console.ReadLine();

            //Console.Write("Yolcu Yaşi: ");
            //passengerAge = Console.ReadLine();

            //Console.Write("Kimlik Bilgisi: ");
            //passengerIdentityNumber = Console.ReadLine();

            //Console.WriteLine();
            //Console.WriteLine("---------------------------------------");
            //Console.WriteLine("Yolcu: " + passengerName + " " + passengerSurname + "/ " + passengerDistrict + " - " + passengerCity + " / " + passengerAge + " / " + passengerIdentityNumber);

            #endregion

            #region Input (Klavyeden Veri Girişi - Integer - Double - Char)

            //Console.ReadLine(); // bu işlemi yapınca C# bu alınan okunan ifadeyi string olarak kabul ediyor bizde string dışında bir şey inputlayacagımız zaman dönüşüm yapmalıyız

            //int shoePrice, computerPrice, chairPrice, tvPrice;
            //shoePrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoeCount, computerCount, chairCount, tvCount;

            //Console.Write("Lütfen aldığınız ayakkabı sayısını giriniz: ");
            //shoeCount = int.Parse(Console.ReadLine()); //Okunan değeri parse ettik int değere dönüştürdük ve onuda shoeCount değişkenine atadadık

            //Console.Write("Lütfen aldığınız bilgisayar sayısını giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız sandalye sayısını giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız tv sayısını giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice = (shoeCount*shoePrice) + (computerCount*computerPrice) + (chairCount*chairPrice) + (tvCount*tvPrice);

            //Console.WriteLine();
            //Console.WriteLine("Toplam Ödemeniz Gereken Tutar: " + totalPrice);

            //----------------------------------------------------------------------------
            //Double

            //double exam1, exam2, exam3, result; // burada ondalık sayı yazarken nokta // cmd ekranında virgül kullanılır

            //Console.Write("Lütfen 1.sınav notunuzu giriniz: ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2.sınav notunuzu giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 3.sınav notunuzu giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine();
            //Console.WriteLine("Sınav Ortalamasi: " + result);

            //----------------------------------------------------------------------------
            //Char

            char gender;
            Console.Write("Lütfen cinsiyet seçiniz: ");
            gender = char.Parse(Console.ReadLine());

            Console.WriteLine("Seçtiginiz cinsiyet: " + gender);

            #endregion
        }
    }
}
