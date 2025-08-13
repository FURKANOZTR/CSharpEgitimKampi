using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForEachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ForEach Döngüsü

            // ForEach döngüsü, bir koleksiyonun her bir elemanını teker teker işlemek için kullanılır.
            // Bu döngü, özellikle diziler, listeler ve diğer koleksiyonlar üzerinde işlem yaparken oldukça kullanışlıdır.
            // Foreach(1;2;3;4) parametre alır 1.Değişken türü 2.Değişken adı 3.In komutu 4.Liste, Kolesyon veya dizi

            //string[] cities = { "Ankara", "İstanbul", "İzmir", "Bursa", "İstanbul" };

            //foreach (string city in cities)
            //{
            //    Console.WriteLine(city);
            //}

            //int[] numbers = { 45, 245, 445, 896, 726, 784, 1407, 4555, 124 };

            //foreach (int number in numbers)
            //{
            //    // Her bir sayının karesini hesaplayıp ekrana yazdırıyoruz.
            //    Console.WriteLine($"Sayının Karesi: {number * number}");
            //}

            //foreach (int number in numbers)
            //{
            //    if (number % 2 == 0)
            //    {
            //        // Eğer sayı çift ise, ekrana çift sayıları yazdırıyoruz.
            //        Console.WriteLine($"Çift Sayı: {number}");
            //    }
            //    else
            //    {
            //        // Eğer sayı tek ise, ekrana tek sayıları yazdırıyoruz.
            //        Console.WriteLine($"Tek Sayı: {number}");
            //    }
            //}   

            //int[] numbers = { 45, 245, 445, 896, 726, 784, 1407, 4555, 124 };
            //int sum = 0;

            //foreach (int number in numbers) 
            //{ 
            //    sum += number;
            //}
            //Console.WriteLine($"Toplam: {sum}");

            //List<int> numbers = new List<int>(); // Liste oluşturma / Liste bir türdeki verileri saklamak için kullanılır.
            //numbers.Add(45);
            //numbers.Add(245);
            //numbers.Add(445);
            //numbers.Add(896);
            //numbers.Add(726);
            //numbers.Add(784); // listeye eleman ekleme

            //List<string> cities = new List<string>() { "Ankara", "İstanbul", "İzmir", "Bursa", "İstanbul" }; // Bu şekilde de liste oluşturabiliriz.

            //Console.WriteLine(numbers); // System.Collections.Generic.List`1[System.Int32] bu şekilde yazdırılır.

            //foreach (int number in numbers) 
            //{
            //    Console.WriteLine(number);
            //}

            //string word = "Merhaba Dünya"; // Bir kelime tanımlıyoruz.Ve bu kelimenin her bir harfini teker teker ekrana yazdıracağız.
            ////stringler C# bir dizidir. Yani stringler de bir koleksiyondur.
            //foreach (char letter in word)
            //{
            //    // Her bir harfi teker teker ekrana yazdırıyoruz.
            //    Console.WriteLine(letter);
            //}



            #endregion

            #region Tüm Konuların Tekrarı Örneği

            //Console.Write("Lütfen ögrenci sayısını giriniz:");
            //int studentCount = int.Parse(Console.ReadLine());

            //string[] studentsInfo = new string[studentCount]; // Öğrenci sayısı kadar bir dizi oluşturuyoruz.
            //int[] studentsNot = new int[studentCount];
            //int totalGrade = 0; // Toplam notu tutmak için bir değişken tanımlıyoruz.
            //int index1 = 0; // Dizi indeksini başlatıyoruz.
            //int index2 = 0; // Dizi indeksini başlatıyoruz.

            //foreach (string _ in studentsInfo) // _ işareti, değişkenin kullanılmadığını belirtir. Bu durumda sadece döngü için kullanıyoruz.
            //{
            //    Console.Write($"Lütfen {index1 + 1}.öğrencinin adını giriniz:");
            //    string name = Console.ReadLine();
            //    studentsInfo[index1] = name; // Her bir öğrencinin adını diziye ekliyoruz.
            //    index1++; // İndeksi artırıyoruz.
            //}

            //foreach (int _ in studentsNot) // _ işareti, değişkenin kullanılmadığını belirtir. Bu durumda sadece döngü için kullanıyoruz.
            //{
            //    Console.Write($"Lütfen {index2 + 1}.öğrencinin notunu giriniz:");
            //    int grade = int.Parse(Console.ReadLine());
            //    studentsNot[index2] = grade; // Her bir öğrencinin notunu diziye ekliyoruz.
            //    index2++; // İndeksi artırıyoruz.
            //    totalGrade += grade; // Notları topluyoruz.
            //}

            //Console.WriteLine("----------Öğrenci Bilgileri ve Notları----------");

            //for(int i = 0; i < studentCount; i++)
            //{
            //    // Öğrenci adını ve notunu ekrana yazdırıyoruz.
            //    Console.WriteLine($"Öğrenci Adı: {studentsInfo[i]} / Not: {studentsNot[i]}");
            //}

            //int averageGrade = totalGrade / studentCount; // Sınıf ortalamasını hesaplıyoruz.

            //Console.WriteLine($"Sınıf Ortalaması: {averageGrade}");


            //Console.Write("Lütfen ögrenci sayısını giriniz:");
            //int studentCount = int.Parse(Console.ReadLine());

            //string[] studentsInfo = new string[studentCount]; // Öğrenci sayısı kadar bir dizi oluşturuyoruz.
            //double[] studentsNot = new double[studentCount];
            //double totalGrade = 0; // Toplam notu tutmak için bir değişken tanımlıyoruz.

            //for(int i = 0; i < studentCount; i++)
            //{
            //    Console.Write($"Lütfen {i + 1}.öğrencinin adını giriniz:");
            //    string name = Console.ReadLine();
            //    studentsInfo[i] = name; // Her bir öğrencinin adını diziye ekliyoruz.
            //}

            //for (int i = 0; i < studentCount; i++)
            //{
            //    Console.Write($"Lütfen {i + 1}.öğrencinin notunu giriniz:");
            //    double grade = double.Parse(Console.ReadLine());
            //    studentsNot[i] = grade; // Her bir öğrencinin notunu diziye ekliyoruz.
            //    totalGrade += grade; // Notları topluyoruz.
            //}

            //Console.WriteLine("----------Öğrenci Bilgileri ve Notları----------");

            //for (int i = 0; i < studentCount; i++)
            //{
            //    // Öğrenci adını ve notunu ekrana yazdırıyoruz.
            //    Console.WriteLine($"Öğrenci Adı: {studentsInfo[i]} / Not: {studentsNot[i]}");
            //}

            //double averageGrade = totalGrade / studentCount; // Sınıf ortalamasını hesaplıyoruz.

            //Console.WriteLine($"Sınıf Ortalaması: {averageGrade}");



            //Console.Write("Lütfen ögrenci sayısını giriniz:");
            //int studentCount = int.Parse(Console.ReadLine());

            //Console.WriteLine("-----------------------------------------------------");

            //string[] studentsInfo = new string[studentCount]; // Öğrenci sayısı kadar bir dizi oluşturuyoruz.
            //double[] studentsAverageNot = new double[studentCount];

            //for (int i = 0; i < studentCount; i++)
            //{
            //    Console.Write($"Lütfen {i + 1}.öğrencinin adını giriniz:");
            //    string name = Console.ReadLine();
            //    studentsInfo[i] = name; // Her bir öğrencinin adını diziye ekliyoruz.
            //    Console.WriteLine();
            //    double totalGrade = 0; // Toplam notu tutmak için bir değişken tanımlıyoruz.Total notu her öğrenci için sıfırlıyoruz.

            //    for (int j = 1; j <= 3; j++)
            //    {
            //        Console.Write($"Lütfen {studentsInfo[i]} adlı öğrencinin {j}.notunu giriniz: ");
            //        double grade = double.Parse(Console.ReadLine());
            //        totalGrade += grade; // Notları topluyoruz.
            //    }
            //    Console.WriteLine("-----------------------------------------------------");

            //    studentsAverageNot[i] = totalGrade / 3; // Her öğrencinin not ortalamasını hesaplıyoruz.
            //}

            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine("----------Öğrenci Bilgileri ve Notları----------");

            //for (int i = 0; i < studentCount; i++)
            //{
            //    Console.WriteLine("-----------------------------------------------------");
            //    // Öğrenci adını ve notunu ekrana yazdırıyoruz.
            //    Console.WriteLine($"Öğrenci Adı: {studentsInfo[i]} / Not Ortalaması: {studentsAverageNot[i]}");
            //    if (studentsAverageNot[i] < 50)
            //    {
            //        Console.WriteLine($"{studentsInfo[i]} adlı öğrenci başarısız.");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{studentsInfo[i]} adlı öğrenci başarılı.");
            //    }
            //    Console.WriteLine("-----------------------------------------------------");
            //    Console.WriteLine();
            //}

            //double sum = 0;

            //for (int i = 0; i<studentCount; i++)
            //{
            //    sum += studentsAverageNot[i]; 
            //}
            //double averageGrade = sum / studentCount; // Sınıf ortalamasını hesaplıyoruz.

            //Console.WriteLine($"Sınıf Ortalaması: {averageGrade}");


            #endregion
        }
    }
}
