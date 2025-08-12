using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If / else / else if (Karar Yapıları)

            //string password;
            //Console.Write("Lütfen şifreyi giriniz: ");
            //password = Console.ReadLine();

            //if (password == "abcd") //Burda noktalı virgül kullanılmaz çünkü cümle bitmedi if ise şunu yap diyene kadar noktalı virgül olmaz
            //{
            //    Console.WriteLine("Şifre Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Şifre Yanlış");
            //}

            //string capital, country;
            //Console.Write("Başkenti Giriniz: ");
            //capital = Console.ReadLine();

            //Console.Write("Ülkeyi Giriniz: ");
            //country = Console.ReadLine();

            //if (capital == "ankara" & country == "türkiye") // & ile && aynı şey demek C# yeni sürümünde syntax değişti ikiside doğru
            //{ // cmd Ekranında büyük küçük harf duyarlılıgı vardır
            //    Console.WriteLine("Veriler doğrulandı");
            //}
            //else
            //{
            //    Console.WriteLine("Hatalı Bilgi");
            //}

            //int number;
            //Console.Write("Bir sayi giriniz: ");
            //number = int.Parse(Console.ReadLine());
            //if (number == 5)
            //{
            //    Console.WriteLine("Sayı doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı yanlış");
            //}

            //double exam1, exam2, exam3, average;
            //string result = "Hata";

            //Console.Write("1.Sınav: ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("2.Sınav: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("3.Sınav: ");
            //exam3 = double.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine("Sınavların Ortalaması: " + average);

            //if (average > 0 & average <= 50)
            //{
            //    result = "Sonuç vasat";
            //}
            //if (average > 50 & average <= 70)
            //{
            //    result = "Sonuç orta";
            //}
            //if (average > 70 & average <= 84)
            //{
            //    result = "Sonuç iyi";
            //}
            //if (average > 84 & average <= 100)
            //{
            //    result = "Sonuç mükemmel";
            //}

            //Console.WriteLine(result); // böyle yazarsan result üsteki koşullardan hiç birini sağlamazsa bir şey atanmamış olucak hatalı bir şey yazdırır
            // bu hatanın çözümü ya result en başda sabit bir değer ata string result = "";
            // yada else ile result bir değer ata


            //string city;
            //Console.Write("Lütfen bir şehir giriniz: ");
            //city = Console.ReadLine();

            //if (city == "adana" | city == "ankara" | city == "bursa" | city == "trabzon" |)
            //{
            //    Console.WriteLine("Şehir mevcut");
            //}
            //else
            //{
            //    Console.WriteLine("Şehir mevcut değil");
            //}

            //Console.Write("Lütfen kullanıcı adını giriniz: ");
            //string username = Console.ReadLine(); // buda kısa atama yapıp input alma işlemi
            //if (username != "admin")
            //{
            //    Console.WriteLine("bu kullanıcı adı kabul edilemez");
            //}
            //else
            //{
            //    Console.WriteLine("Hoşgeldin admin");
            //}

            #endregion

            #region Mod İşlemleri

            //int number = 27;
            //int result = number % 5;
            //Console.WriteLine(result);

            //Console.Write("1.sayiyi giriniz: ");
            //int number1 = int.Parse(Console.ReadLine());
            //Console.Write("2.sayiyi giriniz: ");
            //int number2 = int.Parse(Console.ReadLine());
            //int result = number1 % number2;
            //Console.WriteLine("1.sayinin 2.sayiya bölümünden kalan: " + result);

            //Console.Write("Bir sayi giriniz: ");
            //int number1 = int.Parse(Console.ReadLine());
            //if((number1 % 2) == 0)
            //{
            //    Console.WriteLine("Sayi çifttir");
            //}
            //else
            //{
            //    Console.WriteLine("Sayi tektir");
            //}

            #endregion

            #region Char Değişkenleri ile Karar Yapıları

            //Console.Write("Lütfen takımınızın baş harfini giriniz: ");
            //char team = char.Parse(Console.ReadLine());

            //if (team == 'g' | team == 'G')
            //{
            //    Console.WriteLine("Sen Galatasaraylısın");
            //}
            //else if(team == 'f' | team == 'F')
            //{
            //    Console.WriteLine("Sen Fenerbahçelisin");
            //}
            //else if (team == 't' | team == 'T')
            //{
            //    Console.WriteLine("Sen Trabzonsporlusun");
            //}
            //else if (team == 'b' | team == 'B')
            //{
            //    Console.WriteLine("Sen Beşiktaşlısın");
            //}
            //else
            //{
            //    Console.WriteLine("Böyle bir takım baş harfi bulunmamaktadır");
            //}

            #endregion

            #region Örnek Proje Uygulaması

            //Console.WriteLine("***** C# Eğitim Kampı Restoran ******");
            //Console.WriteLine();
            //Console.WriteLine("------------------------------------");
            //Console.WriteLine("1 - Ana Yemekler");
            //Console.WriteLine("2 - Pizzalar");
            //Console.WriteLine("3 - İçecekler");
            //Console.WriteLine("4 - Tatlılar");
            //Console.WriteLine("5 - Çorbalar");
            //Console.WriteLine("------------------------------------");

            //string menuItem;

            //Console.Write("Lütfen detayını görmek istediginiz menü seçin: ");
            //menuItem = Console.ReadLine();

            //if(menuItem == "1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("--------------Ana Yemekler--------------");
            //    Console.WriteLine("1-Köri Soslu Tavuk");
            //    Console.WriteLine("2-Kızartma Tabağı");
            //    Console.WriteLine("3-Fasulye Pilav");
            //    Console.WriteLine("4-Fırında Soman");
            //    Console.WriteLine("5-Patlıcan Mussakka");
            //    Console.WriteLine("--------------Ana Yemekler--------------");
            //}
            //else if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("--------------Pizzalar--------------");
            //    Console.WriteLine("1-Akdeniz Pizza");
            //    Console.WriteLine("2-Margaritha");
            //    Console.WriteLine("3-Tavuklu Pizza");
            //    Console.WriteLine("--------------Pizzalar--------------");
            //}
            //else if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("--------------İçecekler--------------");
            //    Console.WriteLine("1-Su");
            //    Console.WriteLine("2-Kola");
            //    Console.WriteLine("3-Ayran");
            //    Console.WriteLine("--------------İçecekler--------------");
            //}
            //else if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("--------------Tatlılar--------------");
            //    Console.WriteLine("1-Triliçe");
            //    Console.WriteLine("2-Kazandibi");
            //    Console.WriteLine("3-Sütlaç");
            //    Console.WriteLine("--------------Tatlılar--------------");
            //}
            //else if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("--------------Çorbalar--------------");
            //    Console.WriteLine("1-Mercimek Çorbası");
            //    Console.WriteLine("2-Ezogelin Çorba");
            //    Console.WriteLine("--------------Çorbalar--------------");
            //}
            //else
            //{
            //    Console.WriteLine("Böyle bir secenek yok");
            //}



            #endregion

            #region Switch-Case

            //Console.Write("Bir sayi giriniz: ");
            //int monthNumber = int.Parse(Console.ReadLine());

            //switch (monthNumber) 
            //{
            //    case 1: Console.WriteLine("Ocak"); break; // burda bir satırda yazdıgımız için {} süslü parante kullanmadık
            //    case 2: Console.WriteLine("Şubat"); break;
            //    case 3: Console.WriteLine("Mart"); break;
            //    case 4: Console.WriteLine("Nisan"); break;
            //    case 5: Console.WriteLine("Mayıs"); break;
            //    case 6: Console.WriteLine("Haziran"); break;
            //    case 7: Console.WriteLine("Temmuz"); break;
            //    case 8: Console.WriteLine("Agustos"); break;
            //    case 9: Console.WriteLine("Eylül"); break;
            //    case 10: Console.WriteLine("Ekim"); break;
            //    case 11: Console.WriteLine("Kasım"); break;
            //    case 12: Console.WriteLine("Aralık"); break;
            //    default: Console.WriteLine("Böyle bir ay yok"); break; // hiç bir durum olmazsa çalışır
            //}


            //switch (switch_on) // şu yapıyı hızlı oluşturmak için switch yaz iki kere taba baz
            //{
            //    default:
            //}

            #endregion

            #region Switch Case Hesap Makinesi

            //Console.Write("1.sayıyı giriniz: ");
            //int number1 = int.Parse(Console.ReadLine());

            //Console.Write("2.sayıyı giriniz: ");
            //int number2 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen yapmak istediginiz işlemin sembolünü giriniz: ");
            //int symbol = char.Parse(Console.ReadLine());

            //switch (symbol)
            //{
            //    case '+':
            //        {
            //            int result = number1 + number2;
            //            Console.WriteLine("Toplam: " + result);
            //            break; // diğer case leri boşa kontrol etmesin diye break kullandık ve çok fazla işlem yaptıgımız için süslü parantez kullandık
            //        }
            //    case '-':
            //        {
            //            int result = number1 - number2;
            //            Console.WriteLine("Fark: " + result);
            //            break; // diğer case leri boşa kontrol etmesin diye break kullandık ve çok fazla işlem yaptıgımız için süslü parantez kullandık
            //        }
            //    case '*':
            //        {
            //            int result = number1 * number2;
            //            Console.WriteLine("Çarpım: " + result);
            //            break; // diğer case leri boşa kontrol etmesin diye break kullandık ve çok fazla işlem yaptıgımız için süslü parantez kullandık
            //        }
            //    case '/':
            //        {
            //            if(number2 == 0)
            //            {
            //                Console.WriteLine("Bir sayı sıfıra bölünemez 2.sayıyı düzeltin");
            //                break;
            //            }
            //            else
            //            {
            //                int result = number1 / number2;
            //                Console.WriteLine("Bölüm: " + result);
            //                break; // diğer case leri boşa kontrol etmesin diye break kullandık ve çok fazla işlem yaptıgımız için süslü parantez kullandık
            //            }
            //        }
            //    default:Console.WriteLine("Böyle bir işlem yok");break;
            }

            #endregion
        }
    }
}
