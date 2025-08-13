using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Temel Dizi (Array) Örnekleri

            // Aynı veri tipine sahip birden fazla veriyi saklamak için kullanılan yapılara diziler denir.

            // DeğeşkenTürü[] DiziAd = new DeğişkenTürü[ElemanSayısı];

            //string[] colors = new string[5];
            //colors[0] = "Kırmızı"; // Diziler 0.index'ten başlar.
            //colors[1] = "Mavi";
            //colors[2] = "Yeşil";
            //colors[3] = "Sarı";
            //colors[4] = "Mor";

            //Console.WriteLine("Dizinin 0. İndeksindeki = Dizinin 1. Elemanı: " + colors[0]);
            //Console.WriteLine("Dizinin 1. İndeksindeki = Dizinin 2. Elemanı: " + colors[1]);
            //Console.WriteLine("Dizinin 2. İndeksindeki = Dizinin 3. Elemanı: " + colors[2]);
            //Console.WriteLine("Dizinin 3. İndeksindeki = Dizinin 4. Elemanı: " + colors[3]);
            //Console.WriteLine("Dizinin 4. İndeksindeki = Dizinin 5. Elemanı: " + colors[4]);

            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine("Dizinin " + (i + 1) + ".elemanı: " + colors[i]);
            //}

            //string[] cities = new string[5] { "İstanbul", "Ankara", "İzmir", "Bursa", "Adana" };
            // cities dizisi 5 elemanlı bir dizi olarak tanımlandı ve başlangıçta 5 şehir ismi ile dolduruldu.

            // Console.WriteLine(cities[5]); // Bu satır hata verecektir çünkü dizinin 5. indeksi yoktur. Diziler 0'dan başlar, bu yüzden 5 elemanlı bir dizide 0-4 arası indeksler bulunur.

            // int[] number = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10}; // int türünde bir dizi tanımlandı ve başlangıçta 10 elemanla dolduruldu.Ama burda kısa tanımlama yöntemi kullanıldı.
            //Dizinin boyutunu yazmadık çünkü C# dizilerinin boyutunu otomatik olarak belirler.Dizinin boyutunu yazmak için new anahtarını kullanırız.

            //int[] number = new int[10];

            //number[0] = 50;
            //number[1] = 60;
            //number[2] = 70;
            //number[3] = 80;
            //number[7] = 90;

            //Console.WriteLine(number[7]);
            //Console.WriteLine(number[4]); // Dizide 4.indeksi tanımlamadıgımız için bu indekse default olarak 0 değeri atanır.



            #endregion

            #region Dizideki Tüm Elemanları Listeleme

            //string[] colors = {"Kırmızı","Mavi","Yeşil","Sarı","Mor","Beyaz","Turuncu","Pembe"};

            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}

            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12};

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 0)
            //    {
            //        Console.WriteLine("Çift Sayılar Dizisi: " + numbers[i]);
            //    }
            //}

            //char[] letters = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J' };
            //for (int i = 0; i < letters.Length; i++)
            //{
            //    Console.WriteLine(letters[i]);
            //}

            //int[] myArray = { 1258, 1001, 548, 40, 50, 7804, 5401, 80, 90, 100 };
            //int maxNumber = myArray[0];

            //for (int i = 1; i < myArray.Length; i++)
            //{
            //    if (maxNumber < myArray[i])
            //    {
            //        maxNumber = myArray[i];
            //    } 
            //}

            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    if (myArray[i] > maxNumber)
            //    {
            //        maxNumber = myArray[i];
            //    }
            //}
            //Console.WriteLine("Dizideki En Büyük Sayı: " + maxNumber);

            //string[] persons = { "Ali", "Ayşe", "Mehmet", "Fatma", "Ahmet", "Zeynep" };
            ////string[] persons = new string[6] { "Ali", "Ayşe", "Mehmet", "Fatma", "Ahmet", "Zeynep" }; bunla aynı şeydir.
            //Console.WriteLine("Dizideki Kişi Sayısı: " + persons.Length);

            //int[] numbers = { 41, 85, 57, 67, 548, 42, 59, 10214, 254 };

            //Array.Sort(numbers); // Diziyi sıralar.

            //Console.Write("Dizinin Sıralanmış Hali: ");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.Write(numbers[i] + " , ");
            //}

            //Console.WriteLine();
            //Console.WriteLine();

            //Array.Reverse(numbers); // Diziyi ters çevirir.

            //Console.Write("Dizinin Tersten Sıralanmış Hali : ");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.Write(numbers[i] + " , ");
            //}

            //Console.WriteLine();
            //Console.WriteLine();

            //Insertion Sort // QuickSort // HeapSort // Bubble Sort // Selection Sort

            //int[] numbers = { 5, 3, 8, 4, 2 };

            //for (int i = 0; i < numbers.Length - 1; i++)
            //{
            //    for (int j = 0; j < numbers.Length - 1 - i; j++)
            //    {
            //        if (numbers[j] > numbers[j + 1])
            //        {
            //            int temp = numbers[j];
            //            numbers[j] = numbers[j + 1];
            //            numbers[j + 1] = temp;
            //        }
            //    }
            //}


            #endregion

            #region Dizi Metotları

            //string[] customers = { "Ali", "Ayşe", "Mehmet", "Fatma", "Ahmet", "Zeynep" };
            ////customers[0] = "Hasan"; // Dizinin 0. indeksindeki elemanı değiştirir.
            ////customers[1] = "Elif"; // Dizinin 1. indeksindeki elemanı değiştirir.

            //int index = Array.IndexOf(customers, "Mehmet"); // Dizideki "Mehmet" elemanının indeksini bulur.
            //Console.WriteLine("Dizideki 'Mehmet' Elemanının İndeksi: " + index);

            //int[] numbers = { 589, 873, 845, 458, 227 };
            //Console.WriteLine("Dizinin En Küçük Elemanı: " + numbers.Min()); // Dizinin en küçük elemanını bulur.
            //Console.WriteLine("Dizinin En Büyük Elemanı: " + numbers.Max()); // Dizinin en büyük elemanını bulur.



            #endregion

            #region Kullanıcıdan Dizi Elemanlarını Alma

            //Console.Write("Lütfen dizi boyutunu giriniz: ");
            //int index = int.Parse(Console.ReadLine());

            //string[] cities = new string[index]; // Kullanıcıdan alınan boyutta bir dizi tanımlandı.
            ////for (int i = 0; i < cities.Length; i++) // cities.Length ile index değişkeni aynı değere sahip olduğu için bu şekilde de kullanılabilir.
            ////{
            ////    Console.Write("Lütfen " + (i + 1) + ". şehri giriniz: ");
            ////    cities[i] = Console.ReadLine(); // Kullanıcıdan şehir isimleri alındı ve diziye atandı.
            ////}

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($"Lütfen {i + 1}.şehri giriniz: "); // Burda $ işareti ile string interpolasyonu(Yani string içinde değişken kullanımı) yapıldı.
            //                                                  // (Yani ikili tırnak içinde değişken kullanımı)(Burada çift tırnak bütünlüğü bozmamak için kullanıldı.)
            //    cities[i] = Console.ReadLine();
            //}

            ////for (int i = 0; i < index; i++)
            ////{
            ////    Console.WriteLine("Dizinin " + (i + 1) + ". elemanı: " + cities[i]); // Dizinin elemanları ekrana yazdırıldı.
            ////}

            //Console.WriteLine();
            //Console.WriteLine("-------------------------------------");

            //for (int i = 0; i < index; i++)
            //{
            //    Console.WriteLine($"Dizinin {i + 1}.elemanı: {cities[i]}");
            //}

            //int[] integer = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //int sum = 0;

            //for (int i = 0; i < integer.Length; i++)
            //{
            //    sum += integer[i];
            //}
            //Console.WriteLine("Dizinin Elemanlarının Toplamı: " + sum);

            //int[] numbers = { 147, 258, 369, 741, 852, 963, 159, 753, 456, 321 };
            //int[] evenNumbers = new int[numbers.Length];
            //int[] oddNumbers = new int[numbers.Length];

            //int evenIndex = 0; // çiftleri eklemek için sayaç
            //int oddIndex = 0;  // tekleri eklemek için sayaç

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 0)
            //    {
            //        evenNumbers[evenIndex] = numbers[i];
            //        evenIndex++;
            //    }
            //    else
            //    {
            //        oddNumbers[oddIndex] = numbers[i];
            //        oddIndex++;
            //    }
            //}

            //Console.WriteLine("Dizinin Çift Elemanları: ");
            //for (int i = 0; i < evenIndex; i++)
            //{
            //    Console.Write(evenNumbers[i] + " ");
            //}

            //Console.WriteLine();

            //Console.WriteLine("Dizinin Tek Elemanları: ");
            //for (int i = 0; i < oddIndex; i++)
            //{
            //    Console.Write(oddNumbers[i] + " ");
            //}

            //int[] numbers = { 147, 258, 369, 741, 852, 963, 159, 753, 456, 321 };

            //Console.Write("Dizinin Çift Elemanları: ");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 0)
            //    {
            //        Console.Write($"{numbers[i]} ");
            //    }
            //}

            //Console.WriteLine();
            //Console.WriteLine("----------------------------------------------------------");
            //Console.WriteLine();

            //Console.Write("Dizinin Tek Elemanları: ");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 != 0) // (numbers[i] % 2 == 1) aynı şeydir.
            //    {
            //        Console.Write($"{numbers[i]} ");
            //    }
            //}

            //Console.WriteLine();
            //Console.WriteLine("----------------------------------------------------------");
            //Console.WriteLine();
            #endregion
        }
    }
}
