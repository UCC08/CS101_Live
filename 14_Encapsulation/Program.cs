using _14_Encapsulation;

internal class Program
{
    private static void Main(string[] args)
    {
        #region Normal durum (herşey açık)

        //clsBank bank = new clsBank();

        //bank.AccountNumber = 12345567890;
        //bank.Name = "Santander Bank";
        //bank.Balance = 500;

        //bank.GetBalance();
        //bank.WithdrawAccount();


        #endregion

        #region get/set

        //clsBank bankgs = new clsBank();

        //bankgs.SetBalanceCaps(500); // set etmek için

        //Console.WriteLine($"Balance miktarı : {bankgs.GetBalanceCaps()}"); // get etmek için


        #endregion

        #region Eğer sınıfı tasarlarken Kapsülleme(encapsulation) prensibine uymazsak ne olur?
        // Sınıfı tasarlarken C# kapsülleme prensibini takip etmezsek, kullanıcı tarafından verilen verileri iş gereksinimlerimize
        // göre doğrulayamayız ve gelecekteki değişiklikleri ele almanın bu durumda çok zor olduğu açıktır.
        // Bunu bir örnekle anlayalım. İlk proje gereksiniminde, müşterinin uygulamanın negatif sayının depolanmasına izin vermemesi
        // gerektiğini belirtmediğini varsayalım. Bu nedenle, değişkene sınıf dışından doğrudan erişim sağlarız ve şimdi kullanıcı
        // aşağıdaki örnekte gösterildiği gibi herhangi bir değeri depolayabilir. Burada, miktar değişkenine doğrudan clsBank sınıfının
        // dışından eriştiğimizi ve hem pozitif hem de negatif değerler ayarladığımızı görebilirsiniz.

        //clsBank bank2= new clsBank();

        //// positif bir değerle Amount değerini güncelliyim

        //bank2.Amount = 100;

        //Console.WriteLine($"Bankadaki miktar : {bank2.Amount} PNG Kina");

        //bank2.Amount = -150; // aslında istenmeyen bir durum

        //Console.WriteLine($"Bankadaki miktar : {bank2.Amount} PNG Kina");

        // hata yakala bölümü
        //try
        //{
        //    int deger;

        //    clsBank bank3= new clsBank();

        //    Console.WriteLine("Lütfen değeri giriniz... :");
        //    deger = Convert.ToInt32(Console.ReadLine());

        //    bank3.SetAmount(deger);

        //    Console.WriteLine($"\n\nDüzgün durum\n\nBankadaki miktar : {bank3.GetAmount()} PNG Kina");

        //    Console.WriteLine("Lütfen değeri giriniz... :");
        //    deger = Convert.ToInt32(Console.ReadLine());

        //    bank3.SetAmount(deger);
        //    Console.WriteLine($"Bankadaki miktar : {bank3.GetAmount()} PNG Kina");


        //}
        //catch (Exception hata)
        //{
        //    Console.WriteLine(hata.Message);
        //}


        #endregion

        #region Properties/değişgenlere de uygulanabilir...
        // Özellikler C#'da tanıtılan yeni bir dil özelliğidir. C# 'daki özellikler, değerleri okuyarak ve yazarak bir sınıfın
        // bir alanının veya değişkeninin korunmasına yardımcı olur. İlk yaklaşım, yani ayarlayıcı ve alıcının kendisi iyidir,
        // ancak C# 'daki veri kapsülleme özelliklerle çok daha pürüzsüz olarak gerçekleştirilebilir.

        try
        {
            clsBank bank4 = new clsBank();
            //We cannot access the _Amount Variable directly
            //bank._Amount = 50; //Compile Time Error
            //Console.WriteLine(bank._Amount); //Compile Time Error
            //Setting Positive Value using public Amount Property
            bank4.Amount1 = 10;

            //Setting the Value using public Amount Property
            Console.WriteLine($"Değer : {bank4.Amount1}");

            //Setting Negative Value
            bank4.Amount1 = -150;
            Console.WriteLine($"Değer : {bank4.Amount1}\n\n");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }



        try
        {
            clsBank bank5= new clsBank();

            bank5._Amount2= 100;

            Console.WriteLine($"Değer : {bank5._Amount2}"); // direk değişgenin/property tanımını yazabiliyorum.kendi anlıyo set e gideceğini

            bank5._Amount2 = -5000;

            Console.WriteLine($"Değer : {bank5._Amount2}"); // direk değişgenin/property tanımını yazabiliyorum. kendi anlıyo get e gideceğini

        }
        catch
        {
            Console.WriteLine("Lütfen pozitif bir sayı girin dedik ya...");

        }


        #endregion

        Console.ReadKey();
    }
}