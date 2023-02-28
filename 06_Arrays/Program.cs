
internal class Program
{
    private static void Main(string[] args)
    {
        #region Dizi tanımlama , değer atama, kullanma

        //int[] dizi = new int[20]; // 20 elemanlı dizi isimli bir dizi yaratılıyor

        //dizi[5] = 30; // 5.indexine bir değer atanıyor.

        //Console.WriteLine(dizi[5]); 

        // Şöyle de olabilir...

        //string[] dizi1 = { "Bir", "İki", "Üç" }; // string dizi daha tanımlanırken  ilk değerleride oluşturuluyor.

        //int[] dizi2 = { 2, -4, 6 };

        //float[] dizi3 = { 2f, 1.2f, 7f };

        // Not : Ancak bu şekilde dizi belirtimini sadece dizi tanımlamalarında kullanabiliriz. Örneğin aşağıdaki gibi bir kullanım hatalıdır:

        //int[] dizi;
        //dizi = { 1,2,3};

        //int[] dizi4 = new int[] { 1, 2, 3 };

        //Console.Write("1 ile 10 arasında bir sayı giriniz : ");

        //int boyut = Convert.ToInt32(Console.ReadLine());

        //int[] dizi5 = new int[boyut];

        //dizi5[5] = 30;

        //Console.WriteLine(dizi5[5]);

        // birden fazla dizi tanımlama
        //int[] dizi6 = new int[10], dizi7 = new int[20];


        //// Verilen bir string dizisini, ters sırada (sondan başa doğru) listeleme

        //string[] myUCC08Team = { "Nur", "Nergis", "Büşra", "Helin", "Özcan", "Berna", "Ferit Kaptan", "Nesibe", "Özdenur", "Aleyna", "İlker", "Ertuğrul", "Burak", "Mehmet Doğan", "scrat" };

        //int son = myUCC08Team.Length - 1;

        //for (int i = son; i >= 0; --i)
        //{
        //    Console.WriteLine(myUCC08Team[i]);
        //}


        #endregion

        #region for/foreach döngülerinin kullanımı
        // Verilen bir tamsayı dizisinin elemanlarının toplamını for ve foreach döngülerini kullanarak ayrı ayrı geliştiriniz

        // for
        //int[] sayilar1 = { 5, 6, 7, 8, 78, 45, 0, 30 };

        //int toplam1 = 0;

        //for (int index = 0; index < sayilar1.Length; ++index)
        //{
        //    toplam1 += sayilar1[index];
        //}

        //Console.WriteLine("for çevrimiyle elde edilen sonuç = " + toplam1);

        //// foreach
        //int[] sayilar2 = { 5, 6, 7, 8, 78, 45, 0, 30 };

        //int toplam2 = 0;

        //foreach (int i in sayilar2)
        //{
        //    toplam2 += i;
        //}
        //Console.WriteLine("foreach döngüsüyle elde edilen sonuç = " + toplam2);

        // Tanımlanan sayılar dizisi içerisindeki sayıların negatif, pozitif ve işaretsiz olma durumlarını yanına yazdırma

        //int pozitifadet=0,negatifadet=0,isaretsizadet = 0;

        //int[] sayilar = { 4, 5, -15, 22, -34, 3, 0, -7, 43, 100 };

        //foreach (int sayi in sayilar)
        //{
        //    if (sayi > 0)
        //    {
        //        Console.WriteLine(sayi + " Pozitif");
        //        pozitifadet++;
        //    }

        //    else if (sayi < 0)
        //    {
        //        Console.WriteLine(sayi + " Negatif");
        //        negatifadet++;
        //    }

        //    else
        //    {
        //        Console.WriteLine(sayi + " İşaretsiz");
        //        isaretsizadet++;
        //    }

        //}

        //Console.WriteLine("\n\nPozitif sayı adedi : " + pozitifadet);
        //Console.WriteLine("\n\nNegatif sayı adedi : " + negatifadet);
        //Console.WriteLine("\n\nİşaretsiz sayı adedi : " + isaretsizadet);

        // Kullanıcıdan alınan metin içindeki sesli harf sayısını bulma

        //char[] sesliler = { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü' }; // Daha sonra kullanacağım içinde tüm sesli harfleri içeren bir diziyi öncelikle bir oluşturuyorum.
        //char[] hangileri = new char[20] ; // bulduğum seslileri yerleştireceğim dizi 10 luk yarattım
        //int hindex=0; // hangileri dizisinin indexi

        //string metin=""; // ekrandan alacağım metin bilgisini tutmak için oluşturuyorum.

        //int adet = 0; // benim sesli harf adedini tutacak...

        //Console.WriteLine("Metin giriniz : ");

        //metin = Console.ReadLine().ToLower(); // ekrandan girilen metini okudum ve yerleştirdim ve tüm stringi küçük harfe çevirdim...çünkü elimdeki hazır dizi küçük harfli.

        //// girilen metnin ilk boyunu kullanacağım...

        //// birinci for dögüsü tanımlamış olduğum sesliler dizisi üzerinde dolaşacak.(kontrol amacıyla)
        //for (int i = 0; i < sesliler.Length; i++)
        //{
        //    // ikinci for çevrimi de ekrandan alınan metin için
        //    for (int j = 0; j < metin.Length; j++)
        //    {
        //        if (metin[j] == sesliler[i])  // girilen metini dizi gibi algılatıp benim sesliler dizisindeki bir karaktere uyuyor mu
        //        {
        //            hangileri[hindex] = metin[j]; // bulduğum sesli harfi başka bir diziye koyuorum
        //            hindex++;


        //            adet++; // seslileri tutuyor

        //            // not....indexof()
        //        }
        //    }
        //}

        //Console.WriteLine("Girmiş olduğunuz metinde {0} adet sesli harf vardır...",adet);

        //Console.WriteLine(hangileri);

        //// 10 elemanlı bir dizide bulunan pozitif, sıfır ve negatif değerlerin sayısını bulup yazma
        ///
        //int[] sayilar5 = { 10, -3, 5, 0, 33, -2, -60, 0, -20, -10 };

        //int sifirSay = 0, pozitifSay = 0, negatifSay = 0;

        //for (int x = 0; x < sayilar5.Count(); x++)
        //{
        //    if (sayilar5[x] < 0) // ulaşmış olduğum dizi gözündeki değer negatifse
        //        negatifSay++;
        //    else if (sayilar5[x] > 0) // pozitiflik kontrolu
        //        pozitifSay++;
        //    else
        //        sifirSay++; // ne negatif ne pozitif o zaman 0 dır...
        //}

        //Console.WriteLine("Sıfırların Sayısı : " + sifirSay);
        //Console.WriteLine("Negatiflerin Sayısı : " + negatifSay);
        //Console.WriteLine("Pozitiflerin Sayısı : " + pozitifSay);


        #endregion

        //#region Çok boyutlu diziler

        //int[,] dizi9 = new int[3, 2]; // 2 boyutlu dizi

        //int[,] dizi10 = { { 1, 2 }, { 3, 4 }, { 5, 6 } };

        //int[,,] dizi11 = new int[3, 2, 2]; // 3 boyutlu dizi

        //int[,,] dizi12 = { { { 1, 2 }, { 3, 4 } }, { { 5, 6 }, { 7, 8 } }, { { 9, 10 }, { 11, 12 } } };

        //// Dizi elemanlarını for döngüsü ile değiştirmek

        //for (int i = 0; i < 3; i++)
        //    for (int j = 0; j < 2; j++)
        //        for (int k = 0; k < 2; k++)
        //            dizi12[i, j, k] = 20;

        //// Düzensiz diziler
        //int[][] dizi13 = new int[3][];
        //dizi13[0] = new int[3];
        //dizi13[1] = new int[4];
        //dizi13[2] = new int[2];


        //#endregion

        #region Dizilerde kullanılan bazı metotlar

        // GetLenght ****************
        //int[] dizi14 = { 1, 4, 7, 9 };

        //Console.WriteLine(dizi14.GetLength(0));

        ////----
        //int[,] dizi15 = { { 2, 4, 2,4 }, { 7, 10, 4,5 }, { 7, 12, 6,9 }, { 2, 1, 12,34 } };

        //byte boyut1 = (byte)dizi15.GetLength(1);

        //Console.WriteLine(boyut1);

        ////---
        //int[][] dizi16 = new int[3][];
        //dizi16[0] = new int[] { 1, 2, 3 };
        //dizi16[1] = new int[] { 4, 5, 6, 7 };
        //dizi16[2] = new int[] { 8, 9 };
        //for (int i = 0; i < dizi16.GetLength(0); i++)
        //    for (int j = 0; j < dizi16[i].GetLength(0); j++)
        //        Console.WriteLine("dizi16[{0}][{1}]={2}", i, j, dizi16[i][j]); // dizinin bütün elemanlarını teker teker ekrana yazar.

        //// CreateInstance ***********

        //Array dizi17 = Array.CreateInstance(typeof(int), 5); // int türünden 5 elemanlı dizi17 adında bir dizi tanımlandı ve dizinin her bir elemanına int türünün varsayılan değeri atandı.

        //Array dizi18 = Array.CreateInstance(typeof(int), 3, 2, 5); // Burada 3X2X5 boyutunda int türünden 3 boyutlu bir dizi oluşturuldu.

        //// İlginç bir kullanım
        //int[] dizi19 = new int[5] { 2, 3, 6, 8, 7 }; // diziyi yaratıp anında yaratırken init değerleri de atadı.

        //Array dizi20 = Array.CreateInstance(typeof(int), dizi19); // Burada 2X3X6X8X7 boyutunda beş boyutlu bir dizi oluşturuldu..

        //// Dikkat ! : CreateInstance yöntemiyle oluşturulan dizilere DiziAdi[0,4] gibi bir yöntemle erişilemez. Peki nasıl olcak bu iş...

        //Array dizi21 = Array.CreateInstance(typeof(int), 5, 4, 3);

        //for (int i = 0; i <= dizi21.GetUpperBound(0); i++) // Bir dizinin son indeks numarasını verir.
        //    for (int j = 0; j <= dizi21.GetUpperBound(1); j++)
        //        for (int k = 0; k <= dizi21.GetUpperBound(2); k++)
        //            dizi21.SetValue(i + j + k, i, j, k); // Bir dizinin belirli bir indeksini belirli bir değerle değiştirir.(Özellikle bu iş için norml atama yerine SetValue metodundan yararlanarak yapıyor.

        //for (int i = 0; i <= dizi21.GetUpperBound(0); i++)
        //    for (int j = 0; j <= dizi21.GetUpperBound(1); j++)
        //        for (int k = 0; k <= dizi21.GetUpperBound(2); k++)
        //            Console.WriteLine(dizi21.GetValue(i, j, k)); // Bir dizinin belirli bir indeksini tutar. Bunun için de GetValue metodu kullandı.

        //// Dizi kopyalamak *************

        //int[] dizi22 = { 1, 2, 3, 4 };

        //int[] dizi23 = new int[10];

        //dizi22.CopyTo(dizi23, 3); // Burada dizi22'in tüm elemanları dizi23'e 3. indeksten itibaren kopyalanıyor.

        //
        //int[] dizi24 = { 1, 2, 3, 4 };
        //int[] dizi25 = new int[10];
        //Array.Copy(dizi24, dizi25, 3); // Burada 3 tane eleman dizi24'den dizi25'e kopyalanır. Kopyalama işlemi 0. indeksten itibaren başlar.

        ////
        //int[] dizi26 = { 1, 2, 3, 4, 5, 6, 7 };
        //int[] dizi27 = new int[10];
        //Array.Copy(dizi26, 2, dizi27, 7, 3); // Burada dizi26'nın 2. indeksinden itibaren 3 eleman, dizi27'ye 7. indeksten itibaren kopyalanıyor.

        //// Dizi sıralama ****************

        // diziyi CreateInstance ile yaratıp...İçini doldurup. Sıralamasını hazır metoda yaptırmak...

        //Array metinsel = Array.CreateInstance(typeof(string), 8);

        ////metinsel[0] = "İstanbul";

        //metinsel.SetValue("İstanbul", 0);
        //metinsel.SetValue("Ankara", 1);
        //metinsel.SetValue("İzmir", 2);
        //metinsel.SetValue("Bursa", 3);
        //metinsel.SetValue("Manisa", 4);
        //metinsel.SetValue("Kastamonu", 5);
        //metinsel.SetValue("Muğla", 6);
        //metinsel.SetValue("Bolu", 7);

        //Console.WriteLine("--- Sırasız dizi :");

        //foreach(string sehirisim in metinsel)
        //    Console.Write(sehirisim + " ");

        //Console.WriteLine("\n\n--- Sıralı dizi :");

        //Array.Sort(metinsel);

        //foreach (string sehirisim in metinsel)
        //    Console.Write(sehirisim + " ");

        //// Ters sırada istenirse

        //Array.Reverse(metinsel);

        //Console.WriteLine("");

        //foreach (string sehirisim in metinsel)
        //    Console.Write(sehirisim + " ");

        // Dizilerde arama(searching)

        int[] dizi28 = { 500, 68, 234, 56, 2 };

        Array.Sort(dizi28);

        foreach(int i in dizi28)
            Console.Write(i+ " ");

        Console.Write("dizi28 Index : " + Array.BinarySearch(dizi28, 56));
        // BinarySearch metodu, bir nesneyi dizi içersinde arar,eğer bulursa bulduğu nesnenin indeksini tutar, bulamazsa negatif bir değer tutar.
        // Eğer BS kullanmak istiyorsak önce ve önce diziyi bir Sort ile sıralamak gerekiyor.
        if (Array.BinarySearch(dizi28, 56) < 0)
        {
            Console.WriteLine("Aramış olduğunuz değer dizide yoktur");
        }




        #endregion


        Console.ReadKey();
    }
}