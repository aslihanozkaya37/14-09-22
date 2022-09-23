using System.Collections.Concurrent;
using System.Diagnostics.Metrics;
using System.Drawing;

namespace _21_09_2022_Dongular_EvÇalışması
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region 1'den 10'a kadar olan sayıları yazdıran program
            //for (int i = 1; i <= 10; i++)
            //{
            //    int toplam = 0;
            //    toplam = toplam + i;
            //    Console.WriteLine(toplam);
            //}
            //Console.WriteLine();
            #endregion

            #region 1'den 10'a kadar olan sayıları toplayan program
            //int toplam1 = 0;
            //for (int a = 1; a <= 10; a++)
            //{
            //    toplam1 = toplam1 + a;
            //}
            //Console.Write(toplam1);


            //Console.WriteLine();

            //int toplam2 = 0;
            //for (int b = 50; b < 60; b++)
            //{
            //    int c = b - 49;
            //    toplam2 = toplam2 + c;

            //}
            //Console.WriteLine(toplam2);
            //Console.WriteLine();
            #endregion

            #region Girilen metnin alt alta 10 defa yazdıılmasını sağlayan program

            //Console.Write("Bir Metin Giriniz: ");
            //string metin = Console.ReadLine();

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(metin);

            //}
            //Console.WriteLine();
            #endregion

            #region For döngüsü kullanarak kullanıcıdan alınan 10 adet sayıyı toplayarak ekranda gösteren uygulama.

            //int toplam3 = 0;
            //for (int k = 1; k <= 10; k++)
            //{
            //    Console.Write($"{k}.sayı: ");
            //    int sayi = int.Parse(Console.ReadLine());

            //    //toplam3 = toplam3 + sayi;
            //    toplam3 += sayi;
            //}
            //Console.WriteLine("Sayıların Toplamı: " + toplam3);
            //Console.WriteLine();
            #endregion

            #region For döngüsü ile harfleri A'dan Z'ye sıralayınız.

            //for (char n = 'A'; n <= 'Z'; n++)
            //{
            //    Console.WriteLine(n);
            //}
            //Console.WriteLine();
            #endregion

            #region 1'den 100'e kadar 3'e ve 5'e tam bölünebilen sayıları yazdırın.

            //for (int l = 15; l < 100; l = l + 15)
            //{
            //    Console.WriteLine(l);
            //}

            //Console.WriteLine();

            //for (int p = 1; p < 100; p++)
            //{
            //    if (p % 3 == 0 && p % 5 == 0)
            //    {
            //        Console.WriteLine(p);
            //    }
            //}
            //Console.WriteLine();
            #endregion

            #region 1 ile 1000 arasında 3'e tam bölünemeyen sayılar yazdırına programı yazdırınız.

            //for (int w = 1; w < 1000; w++)
            //{
            //    if (w % 3 != 0)
            //    {
            //        Console.WriteLine(w);
            //    }

            //}
            //Console.WriteLine();
            #endregion

            #region 1 ile 1000 arasında 3'e tam bölünmeyen sayıların adetini ve bunların toplamlarını yazdıran program

            //int counter = 0;
            //int total = 0;

            //for (int u = 1; u < 1000; u++)
            //{
            //    if (u % 3 != 0)
            //    {
            //        counter++;
            //        total = total + u;
            //    }
            //}
            //Console.WriteLine(counter);
            //Console.WriteLine(total);
            //Console.WriteLine();
            #endregion

            #region 1 ile 1000 arasında 3'e tam bölünebilen sayıların adetini ve bunların toplamlarını yazdıran program

            //int counter1 = 0;
            //int total1 = 0;

            //for (int t = 0; t < 1000; t++)
            //{
            //    if (t % 3 == 0)
            //    {
            //        counter1++;
            //        total1 = total1 + t;
            //    }
            //}
            //Console.WriteLine(counter1);
            //Console.WriteLine(total1);
            //Console.WriteLine();
            #endregion
            #region 1'den kullanıcının girdiği sayıya kadar olan sayıları listele, kaç adet olduğunu yazdır, toplamlarını yazdır, ortalamalarını yazdır.

            //Console.Write("Bir sayı giriniz: ");
            //int sayi7 = int.Parse(Console.ReadLine());

            //double counter2 = 0;
            //double total2 = 0;
            //double ortalama = 0;

            //for (int v = 0; v <= sayi7; v++)
            //{
            //    Console.WriteLine(v);
            //    counter2++;
            //    total2 = total2 + v;
            //}
            //ortalama = total2 / counter2;
            //Console.WriteLine(counter2);
            //Console.WriteLine(total2);
            //Console.WriteLine(ortalama);
            //Console.WriteLine();
            #endregion

            #region aşağıdaki çıktıyı veren program
            //1
            //1 2
            //1 2 3
            //1 2 3 4
            //1 2 3 4 5

            //for (int ay = 1; ay <= 5; ay++)
            //{
            //    for (int yıl = 1; yıl <= ay; yıl++)
            //    {
            //        Console.Write(yıl + " ");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine();
            #endregion

            #region kullanıcı tarafından sayılar girilecek.5 tuşuna basıldığı zaman program kapanacak.

            //while (true)
            //{
            //   Console.Write("Bir Sayı Giriniz: ");
            //   int sayi8 = int.Parse(Console.ReadLine());

            //        if (sayi8 == 5)
            //        {
            //        break;  
            //        }

            //    Console.WriteLine($"Girdiğiniz Sayı: {sayi8}");
            //    Console.WriteLine();
            //}
            #endregion
            #region 1.Kullanıcının girdiği iki sayı arasında bulunan 3 ile bölünebilen tam sayıların listesini, toplamını ve ortalamasını gösteren program  

            //Console.Write("Lütfen Bir Sayı Giriniz: ");
            //int deger4 = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen Bir Sayı Giriniz: ");
            //int deger5 = int.Parse(Console.ReadLine());

            //double syc = 0;
            //double tplm = 0;
            //double ort = 0;

            //if (deger4 < deger5)
            //{
            //    for (int ii = deger4; ii < deger5; ii++)
            //    {
            //        if (ii % 3 == 0)
            //        {
            //            Console.WriteLine(ii);
            //            syc++;
            //            tplm = tplm + ii;
            //        }
            //    }
            //    ort = tplm / syc;
            //    Console.WriteLine($"{deger4} ile  {deger5} arasında 3'e tam bölünebilen sayıların adedi: {syc}");
            //    Console.WriteLine($"{deger4} ile {deger5} arasındaki 3'e bölünebilen sayıların toplamı: {tplm}");
            //    Console.WriteLine($"{deger4} ile {deger5} arasında 3'e tam bölünebilen sayıların ortalaması: {ort}");

            //}
            //else if (deger5 < deger4)
            //{
            //    for (int iii = deger5; iii < deger4; iii++)
            //    {
            //        if (iii % 3 == 0)
            //        {
            //            Console.WriteLine(iii);
            //            syc++;
            //            tplm = +iii;
            //        }
            //    }
            //    ort = tplm / syc;
            //    Console.WriteLine($"{deger4} ile  {deger5} arasında 3'e tam bölünebilen sayıların adedi: {syc}");
            //    Console.WriteLine($"{deger4} ile {deger5} arasındaki 3'e bölünebilen sayıların toplamı: {tplm}");
            //    Console.WriteLine($"{deger4} ile {deger5} arasında 3'e tam bölünebilen sayıların ortalaması: {ort}");
            //}
            //Console.WriteLine();
            #endregion

            #region Kulanıcının girdiği 10 adet sayıdan kaç tanesinin 12 ile 35 arasında olduğunu gösteren program

            //int syc1 = 0;
            //int syc2 = 0;

            //for (int iin = 1; iin < 11; iin++)
            //{
            //    Console.Write($"{iin}.Sayıyı Giriniz: ");
            //    int deger8 = int.Parse(Console.ReadLine());

            //    if (deger8 < 35 && deger8 > 12)
            //    {
            //        syc1++;

            //    }
            //    else
            //    {
            //        syc2++;
            //    }
            //}
            //Console.WriteLine($"Girdiğiniz sayılardan 12 ile 35 arasıdan bulunan sayıların adedi: {syc1}");
            //Console.WriteLine($"Girdiğiniz sayılardan 12 ile 35 arasıdan bulunmayan sayıların adedi: {syc2}");
            #endregion

            #region Ekranda çarpım tablosunu gösteren program

            for (int firtsNum = 1; firtsNum <= 10; firtsNum++)
            {

                for (int secondNum = 1; secondNum <= 10; secondNum++)
                {
                    int işlem = firtsNum * secondNum;
                    Console.WriteLine($"{firtsNum} * {secondNum} = {işlem}");

                }
                Console.WriteLine();
            }
            #endregion



        }


    }
}