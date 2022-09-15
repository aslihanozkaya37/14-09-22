//namespace _15_09_22_project
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Hello, World!");


//        }
//    }
//}

//byte minDeger = 8;
//int a;
//int b;
//string name = "aslı";
//string aslınınArkadasi;
//int yasAsli;

//a = 5;
//Console.WriteLine("a'nın değeri:" + a);
//aslınınArkadasi = "gözde";
//yasAsli = 25;
//a = 6;
//b = a;

//Console.WriteLine("b'nin değeri"+b);

//Console.WriteLine("MİN DEĞERİ"+minDeger);
//Console.WriteLine("A'NIN DEĞERİ"+a);
//Console.WriteLine("ADI:"+name);
//Console.WriteLine("ASLININ ARKADAŞI:"+aslınınArkadasi);
//Console.WriteLine("ASLININ YAŞI:"+yasAsli);

//örnek:1:sayı tipinde bir değişken tanımlayın.
//      2:sayı tipinde başlka bir değişken tanımlayın
//      3:bunların isimlerini göstererek konsala yazdırın.
//      4:birinci sayıyı ikinci sayıya;ikinci sayıyı birinci sayının değerine eşitleyin ve konsolda yazdırın.
# region Quiz
// #region endregion kodları saklar.
//
//int x = 5;
//int y = 6;

//Console.WriteLine("x'in değeri" + x);
//Console.WriteLine("y'nin değeri" + y);

//int z = x;
//x = y;

//Console.WriteLine("x'in yeni değeri" + x);


//y = z;
//Console.WriteLine("y'in yeni değeri" + y);

#endregion

//int sayi1 = 22;
//int sayi2 = sayi1 * 2;
//int toplamDeger=sayi1 + sayi2;
//Console.WriteLine(toplamDeger);

#region Quiz2

//Kullanıcıların girdiği değerlerden oluşan ve bu değerleri saklayıp konsola yazdıran bir program olacak.Program içeriğinde başlıklara  aralıklara dikkat edilecek.program ismi çalışan listesi olucak .Toplam 5 adet çalışanın ad,soyad,email,yaş,maaş verilerini alıcak.Ve tüm veriler toplandıktan sonra konsolda alt alta örneğin(
//1. çalışan
//Ad:lşxdg
//Soyad:DSGF
//Email:lövö
//yaş:lnmgflg
//yıllık kazanç
//şeklinde alt alt verileri gösterilecek.ve sonrasında da bir alt satırda çalışanların maaş ortalamasını göstericek.

//#endregion

//Console.WriteLine("*****************Çalışan Formu***********");//Readline komutu içine girilen verileri string türünde tutar.//kullanıcının girdiği veriyi tutabilmemiz için Console.ReadLine() metodunu bir değişkene assign etmemiz yani atmamız lazım.

//#region 1.kişi

//Console.WriteLine("Adınızı giriniz:               ");
//string ad_calisan1 =Console.ReadLine();

//Console.WriteLine("Soyadınızı giriniz:            ");
//string soyad_calisan1=Console.ReadLine();

//Console.WriteLine("Emailinizi giriniz:            ");
//string email_calisan1=Console.ReadLine();

//Console.WriteLine("Yaşınızı giriniz:              ");
//int yas_calisan1=Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Maaşınızı giriniz:             ");
//int maas_calisan1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine($"Yıllık Kazanç:{maas_calisan1*12}");

//#endregion

//#region 2.kişi

//Console.WriteLine("Adınızı giriniz:               ");
//string ad_calisan2 = Console.ReadLine();

//Console.WriteLine("Soyadınızı giriniz:            ");
//string soyad_calisan2 = Console.ReadLine();

//Console.WriteLine("Emailinizi giriniz:            ");
//string email_calisan2 = Console.ReadLine();

//Console.WriteLine("Yaşınızı giriniz:              ");
//int yas_calisan2 = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Maaşınızı giriniz:             ");
//int maas_calisan2 = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine($"Yıllık Kazanç:{maas_calisan2 * 12}");

//#endregion

//#region 3.kişi
//Console.WriteLine("Adınızı giriniz:               ");
//string ad_calisan3= Console.ReadLine();

//Console.WriteLine("Soyadınızı giriniz:            ");
//string soyad_calisan3 = Console.ReadLine();

//Console.WriteLine("Emailinizi giriniz:            ");
//string email_calisan3 = Console.ReadLine();

//Console.WriteLine("Yaşınızı giriniz:              ");
//int yas_calisan3 = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Maaşınızı giriniz:             ");
//int maas_calisan3 = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine($"Yıllık Kazanç:{maas_calisan3 * 12}");

//#endregion

//#region 4.kişi
//Console.WriteLine("Adınızı giriniz:               ");
//string ad_calisan4 = Console.ReadLine();

//Console.WriteLine("Soyadınızı giriniz:            ");
//string soyad_calisan4 = Console.ReadLine();

//Console.WriteLine("Emailinizi giriniz:            ");
//string email_calisan4 = Console.ReadLine();

//Console.WriteLine("Yaşınızı giriniz:              ");
//int yas_calisan4 = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Maaşınızı giriniz:             ");
//int maas_calisan4 = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine($"Yıllık Kazanç:{maas_calisan4 * 12}");

//#endregion

//#region 5. kişi
//Console.WriteLine("Adınızı giriniz:               ");
//string ad_calisan5 = Console.ReadLine();

//Console.WriteLine("Soyadınızı giriniz:            ");
//string soyad_calisan5 = Console.ReadLine();

//Console.WriteLine("Emailinizi giriniz:            ");
//string email_calisan5 = Console.ReadLine();

//Console.WriteLine("Yaşınızı giriniz:              ");
//int yas_calisan5 = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Maaşınızı giriniz:             ");
//int maas_calisan5 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine($"Yıllık Kazanç:{maas_calisan5 * 12}");
//#endregion

//#region 1.kişiyi yazdıran
//Console.WriteLine("1.çalışan");
//Console.WriteLine("Adınız   :     " + ad_calisan1);
//Console.WriteLine("Soyadınız:     " + soyad_calisan1);
//Console.WriteLine("Emailiniz:     " + email_calisan1);
//Console.WriteLine("Yaşınız  :     " + yas_calisan1);
//Console.WriteLine("Maaşınız :     " + maas_calisan1);
//#endregion
//#region 2. kişiyi yazdıran
//Console.WriteLine("2.çalışan");
//Console.WriteLine("Adınız   :     " + ad_calisan2);
//Console.WriteLine("Soyadınız:     " + soyad_calisan2);
//Console.WriteLine("Emailiniz:     " + email_calisan2);
//Console.WriteLine("Yaşınız  :     " + yas_calisan2);
//Console.WriteLine("Maaşınız :     " + maas_calisan2);
//#endregion

//#region 3.kişiyi yazdıran
//Console.WriteLine("3.çalışan");
//Console.WriteLine("Adınız   :     " + ad_calisan3);
//Console.WriteLine("Soyadınız:     " + soyad_calisan3);
//Console.WriteLine("Emailiniz:     " + email_calisan3);
//Console.WriteLine("Yaşınız  :     " + yas_calisan3);
//Console.WriteLine("Maaşınız :     " + maas_calisan3);
//#endregion
//#region 4. kişiyi yazdıran
//Console.WriteLine("4.çalışan");
//Console.WriteLine("Adınız   :     " + ad_calisan4);
//Console.WriteLine("Soyadınız:     " + soyad_calisan4);
//Console.WriteLine("Emailiniz:     " + email_calisan4);
//Console.WriteLine("Yaşınız  :     " + yas_calisan4);
//Console.WriteLine("Maaşınız :     " + maas_calisan4);
//#endregion
//#region 5. kişiyiyazdıran
//Console.WriteLine("5.çalışan");
//Console.WriteLine("Adınız   :     " + ad_calisan5);
//Console.WriteLine("Soyadınız:     " + soyad_calisan5);
//Console.WriteLine("Emailiniz:     " + email_calisan5);
//Console.WriteLine("Yaşınız  :     " + yas_calisan5);
//Console.WriteLine("Maaşınız :     " + maas_calisan5);
//#endregion
//int toplammaas =maas_calisan1+maas_calisan2+maas_calisan3+maas_calisan4+maas_calisan5;
//int ort = toplammaas/5;
//Console.WriteLine($"Maaş ortalaması : {ort}");

















