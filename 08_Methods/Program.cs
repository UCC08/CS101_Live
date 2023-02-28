internal class Program
{
    private static void Main(string[] args)
    {
        // Dikdörtgen alanını hesaplayan bir metodun 4 farklı şeklinin incelenmesi


        #region 1.Geriye değer döndürmeyen ve parametre almayan

        //Hesapla();

        #endregion

        #region 2.Geriye değer döndürmeyen ve parametre alan

        //// kullanıcı giriş alma burada...
        //// hesap ve ekrana yazma hazırlanacak Hesapla isimli metotda.
        //// Dolayısıyla bu metot parametre alan bir metot olacak...

        //Console.WriteLine("Kısa kenar : ");
        //int kk = Convert.ToInt32(Console.ReadLine());

        //Console.WriteLine("Uzun  kenar : ");
        //int uk = Convert.ToInt32(Console.ReadLine());

        //Hesapla(uk, kk); // Hesapla isimli metoda parametreleri gönderiyorum.

        #endregion

        #region 3.Geriye değer döndüren ve parametre almayan


        //int sonuc = HesaplaPrmsiz(); // sonuc = alan (return den gelen)

        //Console.WriteLine("Alan = {0}",sonuc);


        #endregion


        #region 4. Geriye değer döndüren ve Parametre alan metot

        //Console.WriteLine("Kısa kenar : ");
        //int kk = Convert.ToInt32(Console.ReadLine());

        //Console.WriteLine("Uzun  kenar : ");
        //int uk = Convert.ToInt32(Console.ReadLine());

        ////int sonuc1=HesaplaPrmli(kk,uk);

        //Console.WriteLine("Alan = {0}", HesaplaPrmli(kk, uk));

        #endregion

        // Sınıf içi WO1
        // Uygun metot yapısı kullanarak 4 işlemi gerçekleştiriniz (+,-,*,/).Birden fazla metot tanımlayabilirsiniz....

        // Ek : İşlem tipini de alıp ona göre düşünelim..

        //Console.WriteLine("Lütfen 1.sayınızı giriniz : ");
        //int sayi1 = Convert.ToInt32(Console.ReadLine());

        //Console.WriteLine("Lütfen 2.sayınızı giriniz : ");
        //int sayi2 = Convert.ToInt32(Console.ReadLine());

        //Console.WriteLine("\nİşlem türünü giriniz (+,-,*,/");
        //string secenek = Console.ReadLine();

        //Console.WriteLine("İşlem Türü : " + secenek + "\n");

        //Console.WriteLine("Sonuç : {0}", DortIslem(sayi1, sayi2, secenek));

        // ?? Hangi türü kullanırsınız ilk önce hangisi aklınıza gelir..


        #region Metotlarda aşırı yükleme (method overloading)

        Console.WriteLine("2li toplama : {0}",toplamaIslemi(45,45) + "\n");

        Console.WriteLine("3li toplama : {0}", toplamaIslemi(45, 45,78) + "\n");
        Console.WriteLine("4li toplama : {0}", toplamaIslemi(45, 45,90,102) + "\n");


        #endregion

        //ınıf içi WO2
        #region menülü bişi
        // Ekrana seçenekli bir menü gelecek...
        // seçenekleri 1- Hesap makinesi, 2-Tek/Çift Kontrol
        // buna göre metotları hazırlayınız....(menüyü ekrana getirme,hes.mak,tek-cift)

        // ilk secenekte (1) normal hesmak
        // ikinci secenekte (2) ...girilen sayının te mi/çift mi olduğunu yazacak...





        #endregion



        Console.ReadKey();
    }




    private static void Hesapla()
    {
        Console.WriteLine("Kısa kenar : ");
        int kk = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Uzun  kenar : ");
        int uk = Convert.ToInt32(Console.ReadLine());

        int alan = Convert.ToInt32(kk * uk);

        Console.WriteLine("Alan = {0}", alan);

    }

    private static void Hesapla(int kisa, int uzun)
    {
        int alan = Convert.ToInt32(kisa * uzun);

        Console.WriteLine("Alan = {0}", alan);
    }


    private static int HesaplaPrmsiz()
    {
        // Geriye değer döndüren metotlar/functionlar da mutlaka return tanımı olmalıdır
        Console.WriteLine("Kısa kenar : ");
        int kk = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Uzun  kenar : ");
        int uk = Convert.ToInt32(Console.ReadLine());

        int alan = kk * uk;

        return alan; // geri döndürülen bilgi/veri
    }

    private static int HesaplaPrmli(int kisa, int uzun)
    {

        return kisa * uzun;
    }


    private static int DortIslem(int sayi1, int sayi2, string secenek)
    {
        int sonuc = 0;

        if (secenek == "+")
        {
            sonuc = sayi1 + sayi2;
        }
        else if (secenek == "-")
        {
            sonuc = sayi1 - sayi2;
        }
        else if (secenek == "*")
        {
            sonuc = sayi1 * sayi2;
        }
        else
        {
            try
            {
                sonuc = sayi1 / sayi2;
            }
            catch
            {
                Console.WriteLine("sayi2 değeri 0...değerlerin sırasını değiştiriyorum....");

                sonuc = sayi2 / sayi1;
            }
        }

        return sonuc;

    }

    private static int toplamaIslemi(int a,int b)
    {
        return a + b;
    }

    private static int toplamaIslemi(int a, int b,int c)
    {
        return a + b + c;
    }

    private static int toplamaIslemi(int a, int b, int c,int d)
    {
        return a + b + c+d;
    }



    public static void Menu()
    {
        //


    }

    public static void hesapMakinasi()
    {
        //



    }

    public static string tekCiftKontrol(int a)
    {
        string gdd = "";
        //....


        return gdd;
    }



}
