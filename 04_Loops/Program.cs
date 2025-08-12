using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region For Döngüsü
            //for(başlangıç;bitiş;artış veya azalış)
            //for (int i = 0; i < length; i++)
            //{
            // bu yapıyı oluşturmak için for yazdıkdan sonra iki kere taba bas
            //}


            //for (int i = 0; i < 5; i++) // Break-Point ile çalışma prensibini ögrene biliriz ve f11 ile döngüde adım adım ilerleriz ve kare kırmızı buton ile durdururuz
            //{
            //    Console.WriteLine("C# Eğitim Kampı");
            //    Console.WriteLine(i);
            //}

            //for (int i = 1; i < 50; i+=3) 
            //{
            //    Console.WriteLine(i); // i değişkenini 3 er 3 er yazdırır
            //}

            // Yorum satırına üsteki aranın altındaki metin düzleme kısmının altındaki yerden yapabilirsin geride alabilirsin

            //Console.Write("Lütfen ekrana yazılmasını istediginiz adedi giriniz: ");
            //int finishValue = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen ekrana yazılmasını istediginz yazıyı giriniz: ");
            //string mesaj = Console.ReadLine();
            //for (int i = 1; i <= finishValue; i++) //Mantığı varsa i değişkenini 1 den başlat ama dizilerde index mantığını kullanacaksan i değişkenini 0 dan başlat
            //{
            //    Console.WriteLine(mesaj);
            //}

            #endregion

            #region For Döngüsü ile Karar Yapıları

            //Console.WriteLine("----- 5 ile bölünenler -----");
            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 5 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}


            //int totalValue = 0;
            //for (int i = 1; i <= 10; i++)
            //{
            //    totalValue += i; // totalValue = totalValue + i ; aynı mantık
            //}
            //Console.WriteLine(totalValue);


            //int totalValue = 0;

            //for (int i = 1; i <= 20; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        totalValue += i;
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.WriteLine("_______+");
            //Console.WriteLine(totalValue);

            //int count = 0;
            //for (int i = 1; i < 50; i++)
            //{
            //    if (i % 7 == 0)
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine(count);


            //Console.Write("Lütfen kaç saat geçtigini giriniz: ");
            //int hours = int.Parse(Console.ReadLine());
            //int totalVirus = 1;

            //for (int i = 1; i <= hours; i++)
            //{
            //    totalVirus *= 2;

            //}
            //Console.WriteLine(totalVirus);



            //int bacterium = 1;
            //for (int i = 1; i <= 24; i++)
            //{
            //    bacterium *= 2;
            //    Console.WriteLine(i + ".Saat Sonunda: " + bacterium);
            //}


            #endregion

            #region While Döngüsü

            // While (şart) işlem sağlandığı mütdetçe devam eder
            //{
            // İşlemler
            //}

            //int i = 1;
            //while (i <= 10)
            //{
            //    Console.WriteLine(i);
            //    Console.WriteLine("Merhaba");
            //    i++;
            //}

            //int i = 1;

            //while (i <= 10)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}

            //int i = 1, sum = 0;

            //while (i <= 10)
            //{
            //    sum += i;
            //    Console.WriteLine(i);
            //    i++;
            //}
            //Console.WriteLine("------------");
            //Console.WriteLine("Toplam Değer: " + sum);






            #endregion

            #region Örnek Sınav Sorusu

            //Console.Write("3 Basamaklı bir sayi giriniz: ");
            //int number = int.Parse(Console.ReadLine());

            //int sum = (number / 100) + ((number / 10) % 10) + (number % 10);
            //int ones = (number % 10);
            //int tens = (number % 100) / 10;
            //int hundreds = (number / 100);
            //// onlar basamağı için (number % 100) / 10 yapabilirsin
            //Console.WriteLine(hundreds + "-" + tens + "-" + ones);
            //Console.WriteLine("Toplam: " + sum);

            #endregion



        }
    }
}
