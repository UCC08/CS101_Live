internal class Program
{
    private static void Main(string[] args)
    {
        // Tür dönüşüm örnekleri - Bilinçsiz

        byte a = 10;

        short b = 20;

        sbyte c = 30;

        int d = a + b + c; // Örnek bir tür dönüşümü( bilinçsiz)

        string e = "İBB Project 100 KY";

        char f = 'A';

        object g = e + " " + f + " " + d; // farklı tiplerin object tipine atanması

        long h = d;

        float i = h;

        double j = i;

        double k = 21.6;

        Console.WriteLine("1.durum : " + d.ToString());
        Console.WriteLine("2.durum : " + g.ToString());
        Console.WriteLine("3.durum :" + h + k);

        // Bilinçsiz dönüşüm olayında ilginç bir durum

        char l = 'H';

        int m = l;

        Console.WriteLine("4.durum :" + m);

        Console.WriteLine(""); // Bir satır boşluk bırakma.
        Console.WriteLine("\n\t"); // Bir satır boşluk bırakma.

        // Tür dönüşüm örnekleri - Bilinçsiz

        int r = 15;

        byte s = (byte)r;

        Console.WriteLine("5.durum :" + (s + r));

        Console.WriteLine("6.durum : " + r.ToString());

        Console.ReadKey();


    }
}