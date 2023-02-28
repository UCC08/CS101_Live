internal class Program
{        
    static int pdayCount;
    
    private static void Main(string[] args)
    {
        // Erkeklerin 25 yıl
        // Kadınların 20 yıl da emekli olacağı bir ortamda
        // klavyeden cinsiyet ve sigorta prim gün sayısı girilecek
        // Emekliliğe ne kadar kaldı aceb...

        // Bazı kabuller var
        // 1 yıl = 360 gün
        // 1 ay = 30 gün

        // Erkek / 6643 => Emekliliğe 6 yıl 6 ay 17 gün kalmıştır.

        // Initial values  
        int YEAR = 360;
        int MONTH = 30;


        string gender;

        Console.WriteLine("Lütfen cinsiyet bilgisini giriniz (E/K) : ");
        
        gender = Console.ReadLine().ToUpper(); // Hazır fonksiyon. string bilgiyi büyük harfe cevirir.

        Console.WriteLine("\n\nLütfen prim gün sayısını giriniz : ");

        pdayCount = Convert.ToInt32(Console.ReadLine()); // prim gün sayısı
        int year = retirementCalc(gender, pdayCount) / YEAR;
        pdayCount %= YEAR;

        int month = retirementCalc(gender, pdayCount) / MONTH;
        pdayCount %= MONTH;

        int day = pdayCount;

        Console.WriteLine($"\n\nEmekliliğinize {year} yıl {month} ay {day} gün kalmıştır... ");

        Console.ReadLine();
    }

    private static int retirementCalc(string prmGender,int day)
    {
        int DAYFORWOMAN = 7200; // sabit değerler
        int DAYFORMAN = 9000;

        switch (prmGender)
        {
            case "E":
                day = DAYFORMAN - pdayCount;
                break;

            case "K":
                day = DAYFORWOMAN - pdayCount;
                break;

            default:
                break;
        }


        return day;
    }
}