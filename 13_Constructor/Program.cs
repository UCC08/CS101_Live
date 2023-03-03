using _13_Constructor;

internal class Program
{
    private static void Main(string[] args)
    {

        // Bir sınıfın içinde bulunan, o sınıfın değişkenlerini başlatmaktan sorumlu özel bir yöntemdir. Yapıcı yöntemin adı,
        // içinde bulunduğu sınıfla tamamen aynı addır. Adı değiştiremezsiniz. Sınıf adınız "clsEmployee" , yapıcı yöntemin adı da
        // "clsEmployee" olacaktır. Yapıcı yöntem herhangi bir değer döndürmez. Bu, değer döndürmeyen bir metot olduğu anlamına gelir.
        // Genel olarak, metotlar iki türdendir, yani değer döndüren ve değer döndürmeyen ve yapıcılar tamamen değer döndürmeyen
        // yöntemlerdir.
        // 
        // Bir sınıfta kaç tane Constructor metot olabilir?
        //
        // C#'ta bir sınıf içinde istediğimiz sayıda kurucu tanımlayabiliriz. Ancak unutmamamız gereken en önemli nokta,
        // her kurucunun farklı bir imzası olması gerektiğidir. Farklı bir imza, sayı, tür ve parametre sırasının farklı olması
        // gerektiği anlamına gelir.


        #region Standart yapı

        //clsTest test =new clsTest();

        //Console.WriteLine($"i değeri {test.i} - s değeri {test.s} - b değeri {test.b} ");

        #endregion


        // Constructor Tipleri

        //Default or Parameterless Constructor --standart/parametresiz
        //Parameterized Constructor --parametreli
        //Copy Constructor -- copy constructor
        //Static Constructor -- static >
        //Private Constructor -- private >

        #region DEfault/Parametresiz
        // Bu kurucular, bir programcı tarafından açıkça tanımlanabilir veya sınıf altında açık(explicitly) bir kurucu olmaması nedeniyle
        // örtük(implicit) olarak tanımlanacaktır.
        // Böylece, Varsayılan veya Parametresiz Oluşturucular yine iki tipte sınıflandırılır.
        // 1.System-Defined Default Constructor
        // 2.User - Defined Default Constructor

        // Eğer programımızda açıkça herhangi bir kurucu tanımlanmamışsak, varsayılan olarak derleyici derleme sırasında
        // bir kurucu sağlayacaktır. Bu yapıcıya "varsayılan(default) kurucu" denir ve varsayılan kurucu parametresizdir.
        // Varsayılan kurucu-yapıcı, veri üyelerine (statik olmayan değişkenler) varsayılan değerler atayacaktır.
        // Bu oluşturucu sistem tarafından oluşturulduğundan buna sistem tanımlı varsayılan oluşturucu da denir.

        //clsEmployee emp1= new clsEmployee(); // Kullanıcı tanımlı ctor örneği

        //emp1.DisplayEmployee();

        //clsEmployee emp2= new clsEmployee();

        //emp2.DisplayEmployee();


        #endregion


        #region Parametreli ctor lar
        // Nesneyi kullanıcı tarafından verilen değerlerle dinamik olarak başlatmak istiyorsak veya bir sınıfın her bir örneğini
        // farklı bir değerler kümesiyle başlatmak istiyorsak, C#'ta Parameterized Constructor'ı kullanmamız gerekir.
        // Bu oluşturucular yalnızca programcılar tarafından tanımlanır. Yani, basit bir ifadeyle, geliştirici tarafından verilen
        // parametrelere sahip kurucu C#'ta Parametreli Yapıcı olarak tanımlanır.
        //
        // Yararı Nedir?
        // 
        // Parametreli bir kurucunun yardımıyla, sınıfın her bir örneğini farklı bir değerler kümesiyle başlatabiliriz.
        // Bu, parametreli yapıcı kullanarak, sınıfta oluşturulan farklı örneklerde farklı bir değer kümesi depolayabileceğimiz
        // anlamına gelir. Yani her nesneyi farklı değerlerle başlatabilme imkanı vermesidir.

        //clsParametized prm1 = new clsParametized(10);

        //prm1.Display();

        //clsParametized prm2= new clsParametized(20);

        //prm2.Display();

        //clsParametized prm3 = new clsParametized(30);

        //prm3.Display();

        #endregion

        #region Copy ctor
        // aynı değerlere sahip birden fazla örnek/nesne oluşturulması istendiği durumlarda kullanılmalıdır (Copy ctor) 
        // bu durumda copy ctor yapıcısı aynı sınıfı üzerine parametre olarak alır.

        clsCopy obj1 = new clsCopy(10);
        obj1.Display();

        clsCopy obj2 = new clsCopy(obj1);
        obj2.Display();

         #endregion

        Console.ReadKey();
    }
}