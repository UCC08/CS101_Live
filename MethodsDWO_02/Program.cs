internal class Program
{
    // Global değişgenler

    // datUsers
    public static string[,] datUsers = new string[,]
    {
        {"K1","K2","K3" },// Kullanıcılar
        {"P1","P2","P3" }, // Şifreler
        {"A","K","K" }, // Kullanıcı tipi
        {"+","+","+" } // Kullanıcının durumu (Active +/Passive-)
    };

    public static string userAuthority; // A / K ??
    public static string userStatus; // kullanıcı aktif/pasif

    public static string[] datLog = new string[100]; // Log dizisi

    public static int indexLog = 0; // Log dizisinin indexi

    private static void Main(string[] args)
    {
        // Daily WO...28.02.2023

        // Kullanıcı adı,şifresi,yetkisi,aktifliğini içeren bir dizi var
        // (User tablom sanki)
        // 4x3 boyutunda manuel (hard coded) yaratılacak
        // K1,K2,K3 -- kullanıcı adları
        // P1,P2,P3 -- kullanıcı şifreleri
        // A,K,K - Yetki derecesi(Admin mi, normal kullanıcı mı
        // +,+,+ - Kullanıcının aktifliği + aktif/- pasif
        //
        // bunun dışında sistem üzerindeki işlemleri izleyebileceğim (Adminin) bir log dizisi var (tek boyutlu)
        //
        // 1. Program ilk çalıştığında kullanıcıyı bir Ana Menü ekranı karşılayacak(metotsal yapı)
        // 2. seçenekler... 1. Sisteme giriş, 2. çıkış
        // 3. 1. seçeneğe basıldığında. kullanıcının karşısına bir login ekranı gelmeli
        // 4.kullanıcıdan username ve userpass alıncak
        // 5. Bir kontrol işlemiyle(datUser) kullanıcının var olup olmadığı kontrol edilecek, yoksa kullanıcı yok mesajı verilecek ve tekrar login ekranına dönülecek
        // 6. eğer varsa kullanıcının diğer bilgileri (yetki ve aktiflik) öğrenilecek...buna göre yetki duruma bağlı olarak farklı ekranlar kullanıcının karsısına gelecek..yani adminse admin paneli, normal kullanıcı ise yapağı işlemler listesi gibi.
        // 7. yapılan işlemler datLog isimli bir diziye işlenecek ...
        // istenildiğinde Admin kullanıcı tarafından listelenecek. bu seçek adminin kendi panelinde bir seçenek olarak buluncak.




        bool showMenu = true;

        while (showMenu)
        {
            showMenu = MainMenu();
        }

        Console.WriteLine("Çıkış için bir tuşa basınız....");
        Console.ReadKey();
    }

    private static bool MainMenu()
    {
        bool showLogin = true;

        Console.Clear();
        Console.WriteLine("----- Ana Menü -----");
        Console.WriteLine("1. Sistem Giriş");
        Console.WriteLine("2. Programdan Çıkış");
        Console.Write("\nSeçeneğiniz : ");

        switch (Console.ReadLine())
        {
            case "1":
                // Login ekranı bölümü......
                while (showLogin)
                {
                    showLogin = Login();
                }
                return true;

            case "2":
                // Programdan çıkış bölümü

                return false;


            default:
                return true;

        }

        //return true;
    }

    private static bool Login()
    {
        // Not : her şifre karakteri girdiğinde şifre bölümünde ***** gibi gözüksün.

        string userID = "", userPass = "";

        Console.Clear();

        Console.WriteLine("----- Login -----");
        Console.WriteLine("Anamenüye dönüş için * 'ı tuşlayınız...\n\n");
        Console.WriteLine("Kullanıcı adınızı giriniz :");
        userID = Console.ReadLine().Trim();

        if (userID == "*")
        {
            return false;
        }

        Console.WriteLine("Şifrenizi giriniz :");
        userPass = Console.ReadLine();

        userPass = userPass.Trim();

        if (UserControl(datUsers,userID,userPass)) 
        {
            // Eğer kullanıcı bulunduysa...
            Console.WriteLine("Heyyyooo....Kullanıcıyı bulduk...\n\n");

            Console.WriteLine($"Kullanıcı yetki seviyesi {userAuthority}\n\n");

            Console.WriteLine($"Kullanıcı durumu {userStatus}\n\n");

            Console.WriteLine("Devam etmek için bir tuşa basınız.....");

            datLog[indexLog] = $"{userID} isimli kullanıcı sisteme giriş yapmıştır...";

            indexLog++;

            for (int i = 0; i < indexLog; i++)
            {

                Console.WriteLine("Log kayıdı : " + datLog[i]);
            }
        }
        else
        {
            Console.WriteLine("Maalesef kullanıcı yok...\n");


        }


        
        Console.ReadKey();

        return true;
    }

    private static bool UserControl(string[,] prmUsers,string prmUser,string prmPass)
    {
        bool found = false; // kullanıcının bulunup bulunmadığını belirten bir değişgen

        // içiçe for döngüleri yardımıyla tüm dizi öğelerini dolaşalım.
        for (int satir = 0; satir < prmUsers.GetLength(0); satir++)
        {
            for (int sutun = 0; sutun  < prmUsers.GetLength(1); sutun ++)
            {
                if (prmUsers[satir,sutun] == prmUser) // eşleşen kullanıcı mı
                {
                    if (prmUsers[satir+1,sutun] == prmPass) // eşleşen şifre mi
                    {
                        userAuthority= prmUsers[satir + 2,sutun];
                        userStatus= prmUsers[satir+3,sutun];

                        found = true; // kullanıcıyı buldum.
                        break; // döngüden sonlandır.
                    }

                }
            }

            if (found) // yani kayıdı bulmuşsam
            {
                break;
            }
        }

        return found;
    }

    private static void PrintLog()
    {
        // 
    }
}