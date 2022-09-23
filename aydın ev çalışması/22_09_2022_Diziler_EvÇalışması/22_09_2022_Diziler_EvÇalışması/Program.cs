namespace _22_09_2022_Diziler_EvÇalışması
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Rastgele üretilen 5 tane sayıyı büyükten küçüğe alt alta gösterin.

            //Random random0 = new Random();
            //int[] deger0 = new int[5];

            //for (int i = 0; i < deger0.Length; i++)
            //{
            //    deger0[i] = random0.Next(0, 100);
            //}

            //Array.Sort(deger0);
            //Array.Reverse(deger0);

            //foreach (int ii in deger0)
            //{
            //    Console.WriteLine(ii);
            //}
            #endregion

            #region 15 elemanlı bir diziye -52'den 112'ye kadar Random sayılar atan ve sonra bu dizinin elemanlarından pozitif, negatif ve sıfırlar sayılarından kaç tane atandığını gösteren programı yazınız.

            //Random random1 = new Random();
            //int[] deger1 = new int[15];
            //int counter1 = 0;
            //int counter2 = 0;
            //int counter3 = 0;

            //for (int m = 0; m < deger1.Length; m++)
            //{

            //    deger1[m] = random1.Next(-52,112);
            //    Console.WriteLine("Atanan Değerler: " + deger1[m]);

            //    if (deger1[m] > 0)
            //    {
            //        counter1++;
            //    }
            //    else if (deger1[m] < 0)
            //    {
            //        counter2++;
            //    }
            //    else
            //    {
            //        counter3++;
            //    }

            //}
            //Console.WriteLine($"{counter1} adet pozitif sayı vardır.");
            //Console.WriteLine($"{counter2} adet negatif sayı vardır.");
            //Console.WriteLine($"{counter3} adet sıfır vardır.");
            #endregion
            #region 20 elemanlı bir dizide (dizinin elemanlarını istediğiniz gibi atayabilirsiniz.) Kullanıcının girmiş olduğu sayının dizide olup olmadığını bulan, varsa kaç adet olduğunu ekrana yazdıran program.

            //1.çözüm
            //Random random2 = new Random();
            //int[] deger3 = new int[20];
            //int counter4 = 0;

            //Console.Write("Lütfen Pozitif Bir Değer Giriniz: ");
            //int input = int.Parse(Console.ReadLine());
            //Console.WriteLine();

            //for (int n = 0; n < deger3.Length; n++)
            //{
            //    deger3[n] = random2.Next(0,100);
            //    Console.WriteLine($"Rastgele Atanan {n+1}.değer = {deger3[n]}");

            //    if (input == deger3[n])
            //    {
            //        counter4++;
            //    }
            //}
            //Console.WriteLine();
            //Console.WriteLine($"Girmiş olduğunuz değer rastgele atanan değerler içinde {counter4} adet var.");

            Console.WriteLine();

            //2.çözüm 

            Random random3 = new Random();
            int[] deger4 = new int[20];

            for (int k = 0; k < deger4.Length; k++)
            {
                deger4[k] = random3.Next(0, 100);
                Console.WriteLine(deger4[k]);
            }

            int counter5 = 0;

            while (true)
            {

                Console.WriteLine("Lütfen Bir Sayı Giriniz: ");
                int input1 = Convert.ToInt32(Console.ReadLine());
                counter5++;
                int input2 = Convert.ToInt32(Console.ReadLine());


                if (input2 == -1)
                {
                    break;
                }
                else
                {
                    counter5++;
                }




            }













            #endregion
            #region İsimleri kullanıcıdan alınacak olan 10 kişilik bir sınıf dizisi oluşturulacak.Önce bu dizinin orjinal sırası isimler yan yana gözükecek şekilde gösterilecek, sonra ters sırayla gösterilecek, sonrra da sıralı bir array olarak gösterilecek.










            #endregion

















        }
    }
}