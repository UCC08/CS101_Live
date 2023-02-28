
using System.ComponentModel;

internal class Program
{
    private static void Main(string[] args)
    {

        #region 1. if - else
        //// if else deyimi sayesinde belli bir koşul sağlandığında söz konusu komutlar çalıştırılır, o belli koşullar sağlanmadığında çalıştırılmaz ya da başka komutlar çalıştırılır.
        ////
        //// Syntax :

        //// if (koşul)
        ////    komut1;
        //// else
        ////    komut2;
        ////
        //// veya
        ////
        //// if (koşul)
        ////  {
        ////    komutlar1
        ////  }
        //// else
        ////  {
        ////    komutlar2
        ////  }

        //int a = 5, b = 7;


        //if (a < b)
        //    Console.WriteLine("a b'den küçük");
        //else
        //    Console.WriteLine("a b'den küçük değil");

        //// Diğer bir örnek

        //int c = 5, d = 7;

        //if (c < d)
        //{
        //    Console.WriteLine("c d'den küçük");
        //    Console.WriteLine(c);
        //}
        //else
        //{
        //    Console.WriteLine("c d'den küçük değil");
        //    Console.WriteLine(d);
        //}

        //// if else yapılarında else kısmının bulunması zorunlu değildir. Bu durumda sadece koşul sağlandığında bir şeyler yapılacak, koşul sağlanmadığında bir şeyler yapılmayacaktır. 

        //int e = 5, f = 7;

        //if (e > f)
        //    Console.WriteLine("e f'den küçük");

        //// Şöyle de bir kullanım mümkündür

        //Console.Write("Cinsiyetinizi girin (e, k): ");

        //char cins = Convert.ToChar(Console.ReadLine());

        //if (cins == 'e')
        //    Console.Write("Erkeksiniz....");
        //else if (cins == 'k')
        //    Console.Write("Kadınsınız....");
        //else
        //    Console.Write("Lütfen cinsiyetinizi doğru giriniz!");

        // normal if-else
        //string parola = Console.ReadLine();

        //if (parola == "1234")
        //{
        //    Console.WriteLine("Parola doğru");
        //}
        //else
        //{
        //    Console.WriteLine("Girilen parola doğru değil");
        //}

        // ikili kontrol =========
        //string kullaniciAdi = Console.ReadLine();
        //string parola = Console.ReadLine();

        //if (kullaniciAdi == "admin" && parola == "1234")
        //{
        //    Console.WriteLine("Kullanıcı Adı ve Parola Doğru");
        //}
        //else
        //{
        //    Console.WriteLine(" Kullanıcı Adı ve Parola Yanlış!");
        //}

        // Biraz daha gelişmiş kontrol =========
        //string kullaniciAdi = Console.ReadLine();
        //string parola = Console.ReadLine();

        //if (kullaniciAdi == "admin")
        //{
        //    if (parola == "123456")
        //    {
        //        Console.WriteLine("Kullanıcı Adı ve Parola Doğru");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Girilen Parola Doğru Değil!");
        //    }
        //}
        //else
        //{
        //    Console.WriteLine("Girilen Kullanıcı Adı Doğru Değil!");
        //}

        #endregion

        #region 2. switch -case
        //// switch deyimi bazı if else deyimlerinin yaptığı işi daha az kodla yapar. Genellikle bazı karmaşık if else bloklarını kurmaktansa switch'i kullanmak programın anlaşılırlığını artırır. Ancak tabii ki basit if else bloklarında bu komutun kullanılması gereksizdir.
        ////
        //// Syntax :

        ////switch (ifade)
        ////{
        ////    case sabit1:
        ////        komut1;
        ////        break;
        ////    case sabit2:
        ////        komut2;
        ////        break;
        ////    default:
        ////        komut3;
        ////        break;
        ////}
        //// Bazı bilinmesi gerekenler
        ////
        //// *) İfadenin ürettiği değer hangi case sabitinde varsa o "case"deki komutlar işletilir. Eğer ifadenin ürettiği değer hiçbir case sabitinde yoksa default casedeki komutlar işletilir.
        //// *) Aynı birden fazla case sabiti olamaz
        ////
        ////int g = 4;

        ////switch (g)
        ////{
        ////    case 4:
        ////        Console.Write("deneme1");
        ////        break;
        ////    case 4:
        ////        Console.Write("deneme2");
        ////        break;
        ////    case 5:
        ////        Console.Write("deneme3");
        ////        break;
        ////    default:
        ////        Console.Write("deneme4");
        ////        break;
        ////}
        ////
        //// *) herhangi bir case'e ait komutların "break;" satırı ile sonlandırılması gerekmektedir. Eğer sonlandırılmazsa program hata verir.
        //// doğru kullanım
        //int h = 4;

        //switch (h)
        //{
        //    case 4:
        //        string i4 = Console.ReadLine(); // Ekran okuması
        //        Console.Write(i4);
        //        break;
        //    default:
        //        Console.Write("deneme4");
        //        break;
        //}
        //// *) Eğer programımızın bir case'deyken farklı bir case'e gitmesini istiyorsak "goto" anahtar sözcüğünü kullanırız
        //int j = 5;

        //switch (j)
        //{
        //    case 4:
        //        string k1 = Console.ReadLine();
        //        Console.Write(k1);
        //        break;
        //    case 5:
        //        Console.Write("Şimdi case 4'e gideceksiniz.");
        //        goto case 4;
        //    default:
        //        Console.Write("deneme4");
        //        break;
        //}

        //// *) goto satırı kullanılmışsa break; satırının kullanılmasına gerek yoktur.

        //// *) Eğer farklı case sabitlerinin aynı komutları çalıştırmasını istiyorsak şöyle bir program yazılabilir

        //int k = 7;

        //switch (k)
        //{
        //    case 4:
        //    case 5:
        //        string l = Console.ReadLine(); // ekrandan okuma yapar..
        //        Console.Write(l);
        //        break;
        //    default:
        //        Console.Write("deneme4");
        //        break;
        //}

        #endregion

        #region 3. for
        //

        //int toplam = 0;

        //for (int i1 = 1; i1 <= 3; i1++)
        //{
        //    toplam += i1; // toplam= toplam + i1

        //}

        //
        // girdiğimiz herhangi bir sayının faktöriyelini bulma

        //float s;
        //int si, f1; // f1 sonuç 
        //bool a1 = false; // pozitiflik/negatiflik belirleyen bir mantıksal değişken

        //for (; a1;) // arkadaş esas döngü olayı bloğun içinde ben sadece başlamasını sağlıyorum.
        //{
        //    Console.Write("Lütfen faktoriyelinin alınmasını istediğiniz sayıyı girin: ");

        //    s = Convert.ToSingle(Console.ReadLine());

        //    si = (int)s;

        //    if (si != s || s < 1)
        //    {
        //        Console.WriteLine("Lütfen pozitif tam sayı girin.");
        //        a1 = false;
        //    }
        //    else // pozitif bir değer girmişse
        //    {
        //        a1 = true;

        //        for (f1 = 1; si > 1; si--)
        //            f1 *= si;

        //        Console.WriteLine("Faktöriyeli={0}", f1);
        //    }
        //}

        //
        //int a2;
        //for (int i = 0; i < 1; i++)
        //    a2 = 5;
        //Console.Write(a2); //Bu program çalışmaz, çünkü a değişkeni döngüden önce tanımlanmasına rağmen ilk değer verilmiyor.


        //1'den 1000'e (sınırlar dâhil) kadar olan sayılar içerisinde 5'e tam bölünen, ancak 7'ye tam bölünemeyen sayıları alt alta listeleyen, bu sayıların kaç tane olduğunu ve toplamını yazan bir program yazınız.

        //int toplam1 = 0, sayi = 0;int i;
        //for (i=1; i < 1001; i += 5)
        //{
        //    if (i % 35 ==0) // (i % 5 == 0 && i % 7 != 1)
        //        continue;
        //    sayi++;
        //    toplam1 += i;
        //    Console.WriteLine(i);
        //}
        //Console.WriteLine("Sayısı: " + sayi);
        //Console.WriteLine("Toplam: " + toplam1);

        //// Konsol ekranına girilen 0 ile 100 (sınırlar dâhil) arasındaki 10 notun en büyüğünü, en küçüğünü ve ortalamasını yazan programı yazınız.

        //int bnot = 0, toplam2 = 0, knot = 0;

        //for (int sayac = 0, not; sayac < 3; sayac++)
        //{
        //    Console.Write(sayac + 1 + ". notu giriniz: "); // dinamik olarak mesaj oluşturuyor
        //    not = Convert.ToInt32(Console.ReadLine());
        //    if (not > 100 || not < 0)
        //    {
        //        Console.Write("Yanlış not girdiniz. Lütfen tekrar ");
        //        sayac--;
        //        continue;
        //    }
        //    if (sayac == 0)
        //    {
        //        bnot = not;
        //        knot = not;
        //    }
        //    else
        //    {
        //        if (not > bnot)
        //            bnot = not;
        //        if (not < knot)
        //            knot = not;
        //    }
        //    toplam2 += not;
        //}
        //Console.Write("En büyük: {0}\nEn küçük: {1}\nOrtalama: " + toplam2 / 3, bnot, knot);


        #endregion

        #region 4. while
        //// 0-100 arasındaki sayıların toplamı.

        //int toplam = 0;

        //int i = 0; // ilk değer

        //while (i < 100) // i < 100 olduğu sürece aşağıdaki bloğu çalıştır.
        //{
        //    toplam += i; // toplama işlemini gerçekleştir.

        //    i++;
        //}

        //Console.WriteLine(toplam);

        //        Aşağıdaki işlemde int sayi isimli bir değişken oluşturulup
        //içine Console.ReadLine() metodundan gelen string değer dönüştürülerek atılmıştır.
        //Çünkü while döngüsünde büyüktür(>) operatörünü kullanmak için bir sayıya ihtiyacımız
        //vardır ve int değişkenler büyüktür operatörünü kullanabileceğimiz sayıyı tutmaktadır:
        // 
        // Ekrandan girilen sayının basamaklarını bulan program parçası

        //Console.WriteLine(  "Sayınızı giriniz : ");

        //int sayi = Convert.ToInt32(Console.ReadLine());

        //int basamak = 0;

        //while (sayi > 0)
        //{
        //    basamak++;

        //    sayi = sayi / 10;
        //}

        //Console.WriteLine("Girdiğiniz sayı " + basamak.ToString() + " basamaklıdır.");

        //// Nested While Loop 1
        //Console.Write("ENTER  A NUMBER ");
        //int sayi1 = Convert.ToInt32(Console.ReadLine());
        //int index = 1;
        //while (index <= sayi1)
        //{
        //    Console.WriteLine();
        //    int j = 1;
        //    while (j <= index)
        //    {
        //        Console.Write(j + " ");
        //        j++;
        //    }
        //    index++;
        //}

        //// Nested while loop 2
        //int a = 1;
        //while (a <= 5)
        //{
        //    int b = 1;
        //    while (b <= 5)
        //    {
        //        Console.Write(b + " ");
        //        b++;
        //    }
        //    Console.WriteLine();
        //    a++;
        //}


        #endregion

        #region 5. do while

        int toplam1 = 0;

        int sayac = 0;
        
        do
        {
            sayac++;

            toplam1 += sayac;

        }
        while (sayac < 100);
        
        Console.WriteLine("Toplam: " + toplam1.ToString() + ",Sayaç: " + sayac.ToString());





        //// nested do while
        //char Choice;
        //int MenuOption;
        //int Number1, Number2;
        //do
        //{
        //    Console.WriteLine("Press 1 for Addition, 2 for Subtraction, 3 for Multiplication, 4 for Division");
        //    MenuOption = Convert.ToInt32(Console.ReadLine());
        //    switch (MenuOption)
        //    {
        //        case 1:
        //            Console.WriteLine("Enter the value of two numbers");
        //            Number1 = Convert.ToInt32(Console.ReadLine());
        //            Number2 = Convert.ToInt32(Console.ReadLine());
        //            Console.WriteLine($"Sum Is {Number1 + Number2}");
        //            break;
        //        case 2:
        //            Console.WriteLine("Enter the value of two numbers");
        //            Number1 = Convert.ToInt32(Console.ReadLine());
        //            Number2 = Convert.ToInt32(Console.ReadLine());
        //            Console.WriteLine($"Difference Is {Number1 - Number2}");
        //            break;
        //        case 3:
        //            Console.WriteLine("Enter the value of two numbers");
        //            Number1 = Convert.ToInt32(Console.ReadLine());
        //            Number2 = Convert.ToInt32(Console.ReadLine());
        //            Console.WriteLine($"Multiplication Is {Number1 * Number2}");
        //            break;
        //        case 4:
        //            Console.WriteLine("Enter the value of two numbers");
        //            Number1 = Convert.ToInt32(Console.ReadLine());
        //            Number2 = Convert.ToInt32(Console.ReadLine());
        //            Console.WriteLine($"Division Is {Number1 / Number2}");
        //            break;
        //        default:
        //            Console.WriteLine("Invalid choice");
        //            break;
        //    }
        //    Console.WriteLine("Please Enter Y to continue, any keys to terminate");
        //    Choice = Convert.ToChar(Console.ReadLine());
        //}
        //while (Char.ToUpper(Choice) == 'Y');

        #endregion


        Console.ReadKey();
    }

}
