using System;

internal class Program
{
    private static void Main(string[] args)
    {
        //string name;
        //string nameDesc;

        //string Name;
        //string NameDesc;

        //name = "Ümit Karaçivi....."; // Değişgene değer Atama işlemi
        //nameDesc = "Benim adım : ";
        //NameDesc = "Kızımın adı : ";

        //Name = "Doğa Bengi Karaçivi";


        //Console.WriteLine(nameDesc + name);

        //Console.WriteLine(NameDesc + "-------> " + Name);



        byte a = 5;
        byte a1 = 255;

        int toplam = a + a1;



        Console.WriteLine("Toplama işleminin sonucu = " + toplam.ToString());

        //byte b = 5;
        //byte c = 8;
        //Console.WriteLine(a + b);

        //string str1 = "Viki", str2 = "kitap";
        //Console.WriteLine(str1 + str2);

        string name;
        Console.WriteLine("Lütfen adınızı giriniz : ");

        name = Console.ReadLine(); // string türünden değer girilmesi bekleniyor..

        Console.WriteLine("Adınız : " + name);






        //Console.WriteLine("Hello, World!");



        Console.ReadKey(); // tuşa basılması beklemek için kondu.



        // Sık yapılan hatalar
        //
        // - Aynı satırda farklı türden değişkenler tanımlamaya çalışma.
        // int m, b;
        //
        // - Değişkene uygunsuz değer vermeye çalışma
        //int n;
        //n = "metin";
        //
        // - Değişkeni tanımlamadan ve/veya değişkene ilk değer vermeden değişkeni kullanmaya çalışma
        //int b=5;
        //Console.WriteLine(a);

        //Console.WriteLine(b);
        // 
        // - Değişken tanımlaması ve/veya değer vermeyi yanlış yerde yapma
        //int a = 5;

        //static void Main()
        //{
        //    Console.WriteLine(a);
        //}
        // değişken tanım ve değer verilmeleri Main bloğu içinde yapılmalıdır.
        //
        // - Bazı değişken türlerindeki değişkenlere değer verirken eklenmesi gereken karakteri eklememek
        float e = 12.5f;
        Console.WriteLine(e);
        //
        // - Ondalık sayıların ondalık kısmını ayırırken nokta (.) yerine virgül (,) kullanmak
        // float a=12,5f;
        // Console.WriteLine(a);
        //
        // - Metinsel değişkenlerle matematiksel işlem yapmaya çalışmak.
        //string a5 = "13456", b5 = "2";
        //int c5 = Convert.ToInt32(a5) + Convert.ToInt32(b5);
        //Console.WriteLine(c5);
        ////
        // Bir değişkeni birden fazla kez tanımlamak
        // string a;
        // string a = "deneme";
        // Console.WriteLine(a);
        //
        // - Değişkenlere değer verirken yanlış şekilde değer vermek
        // string a=deneme;
        // Console.WriteLine(a);
    }
}