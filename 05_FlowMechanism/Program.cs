internal class Program
{
    private static void Main(string[] args)
    {
        #region if-else
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

        //int c = 5, d = 7;

        //if (c < d)
        //{
        //    Console.WriteLine("c değeri d değerinden küçüktür...");
        //    Console.WriteLine(c);
        //}
        //else
        //{
        //    Console.WriteLine("c degeri d değerinden büyük...");
        //    Console.WriteLine(d);   
        //}

        //// if else yapılarında else kısmının bulunması zorunlu değildir. Bu durumda sadece koşul sağlandığında bir şeyler yapılacak, koşul sağlanmadığında bir şeyler yapılmayacaktır. 
        ///

        //int e = 5, f = 7;

        //if (e > f) 
        //{
        //    Console.WriteLine("e f den küçük...");
        //}

        // Şöyle de bir kullanım olabilir...

        //Console.WriteLine("Lütfen cinsiyet bilgisini giriniz..(e,k) :");

        //char cinsiyet=Convert.ToChar(Console.ReadLine());

        //if (cinsiyet == 'e')
        //{
        //    Console.WriteLine("Erkek");
        //}
        //    else if (cinsiyet == 'k')
        //    {
        //        Console.WriteLine("Kadın");
        //    }
        //else
        //    Console.WriteLine("Lütfen doğru karakter giriniz..");

        // ekrandan alınan parola değerinin doğruluğunu test eden if yazınız. (parola 1234 müş)

        //int parola=Convert.ToInt32(Console.ReadLine());

        //if (parola == 1234)
        //    Console.WriteLine("Parola doğru");
        //else
        //    Console.WriteLine("Parola yanlış");

        // ikli kontrol.
        // ekrandan hem kullanıcı adı hem de şifresi alınacak
        // ve kontrole göre mesajlar verilecek


        //string username;
        //string userpass;
        //const string UN = "admin";
        //const string UP = "Q1W2e3";

        //Console.WriteLine("Kullanıcı adını giriniz...");
        //username=Console.ReadLine();


        //Console.WriteLine("\n\nKullanıcı şifrenizi giriniz...");
        //userpass = Console.ReadLine();

        //if (username == UN && userpass==UP)
        //{
        //    Console.WriteLine("Kullanıcı adınız ve şifreniz doğru");
        //}
        //else
        //    Console.WriteLine("2 sinden birisi yanlış");

        // Biraz daha gelişmiş kontrol
        // detaylı olarak hangi bilginin yanlış olduğu belirtmek için kullanılabilir.

        //string username;
        //string userpass;
        //const string UN = "admin";
        //const string UP = "Q1W2e3";

        //Console.WriteLine("Kullanıcı adını giriniz...");
        //username = Console.ReadLine();




        //if (username == UN)
        //{
        //    Console.WriteLine("\n\nKullanıcı şifrenizi giriniz...");
        //    userpass = Console.ReadLine(); 

        //    if (userpass==UP)
        //    {
        //        Console.WriteLine("Eyvallah...Buyrun geçin");
        //    }
        //    else
        //        Console.WriteLine("Girilen parola yanlış...kontrol et...");

        //}
        //else
        //{
        //    Console.WriteLine("Girilen kullanıcı adı yanlış...");
        //}


        #endregion


        #region switch - case
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
        //// *) herhangi bir case'e ait komutların "break;" satırı ile sonlandırılması gerekmektedir. Eğer sonlandırılmazsa program hata verir.
        //int g = 4;

        //switch (g)
        //{
        //    case 4: 
        //        Console.WriteLine("değer 4");
        //        break;

        //    case 5:
        //        Console.WriteLine("değer 5");
        //        break;

        //    default:
        //        break;
        //}

        // diğer bir örnek
        //string ad,soyad;


        //Console.WriteLine("Lütfen adınızı giriniz");

        //ad = Console.ReadLine();

        //switch (ad)
        //{
        //    case "Ümit":
        //        Console.WriteLine("Lütfen soyadınızı giriniz");

        //        soyad = Console.ReadLine();

        //        Console.WriteLine("Girmiş old. bilgi : " + ad + " " + soyad);
        //        break;

        //    default:
        //        Console.WriteLine("Yanlış format");
        //            break;
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

        #endregion

        #region for

        //int toplam = 0;

        //for (int i = 0; i <= 10; i++)
        //{
        //    toplam=toplam+i;
        //    // toplam += i;

        //}

        //Console.WriteLine(toplam);

        //string deger = "Ümit Karaçivi";

        //for (int i = deger.Length-1; i >=0; i--)
        //{
        //    Console.WriteLine(deger[i]); // karakter katarını dizi gibi algılama ve tek tek elemanlarına erişme
        //}

        //// girdiğimiz herhangi bir sayının faktoriyel hesabı
        //float s;
        //int si, f1; // f1 değişgeni faktoriyel.
        //bool a1 = true; // girilen değerin pozitiflik/negatiflikliğini belirlemek için

        //for (;  a1; ) //esas döngü olayı bloğun içinde ben sadece başlamasını sağlıyorum.
        //{
        //    Console.WriteLine("Lütfen faktöriyelibni almak istediğiniz sayıyı giriniz..");

        //    s=Convert.ToSingle(Console.ReadLine());

        //    si = (int)s; // zorluyorum tip değişimi için...

        //    if (si != s || s<1)
        //    {
        //        Console.WriteLine("Lütfen pozitif bir tamsayı giriniz...");
        //        a1= false;

        //    }
        //    else // eğer pozitif girmişse piroblem yok..
        //    {
        //        a1 = true;

        //        for (f1 = 1; si > 1; si--)
        //        {
        //            f1 *= si;
        //        }

        //        Console.WriteLine("Faktöriyel = {0}",f1);
        //    }

        //}



        //1'den 1000'e (sınırlar dâhil) kadar olan sayılar içerisinde 5'e tam bölünen, ancak 7'ye tam bölünemeyen sayıları alt alta listeleyen, bu sayıların kaç tane olduğunu ve toplamını yazan bir program yazınız.

        //int toplam = 0, adet = 0, sayac;

        //for (sayac=0; sayac <=1000; sayac+=5)
        //{
        //    if (sayac % 5 == 0 && sayac % 7 != 0)
        //    {
        //        adet++; // koşula uyan bir sayi buldum.

        //        Console.WriteLine(sayac);

        //        toplam += sayac; // toplam = toplam + sayac

        //    }

        //}

        //Console.WriteLine("\n\nSayıların adedi : {0} adettir...",adet);

        //Console.WriteLine("\n\nSayıların toplamı : {0}'dir...",toplam);


        //// Konsol ekranına girilen 0 ile 100 (sınırlar dâhil) arasındaki 3 notun en büyüğünü, en küçüğünü ve ortalamasını yazan programı yazınız.
        ///

        int bnot = 0; // en büyük notu belirtsin
        int toplam = 0;
        int knot = 0; // en küçük notu belirtsin
        int not = 0;

        for (int sayac = 0; sayac < 3; sayac++)
        {
            Console.WriteLine(sayac + ". notu giriniz :");

             not = Convert.ToInt32(Console.ReadLine());

            if (not > 100 || not <0) 
            {
                Console.WriteLine("Lütfen pozitif bir not giriniz..");

                sayac--;

                continue;
            }
            
            if (sayac == 0) 
            {
                bnot = not;
                knot = not;
            
            }
            else
            {
                if (not > bnot)
                {
                    bnot = not;
                }

                if (not < knot)
                {
                    knot = not;
                }
            }

            toplam += not;

        }

        Console.WriteLine("En büyük: {0}\nEn küçük: {1}\nOrtalama : {2}",bnot,knot,toplam/3);




        #endregion








        Console.ReadKey();
    }
}