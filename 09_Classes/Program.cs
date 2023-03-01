internal class Program
{
    private static void Main(string[] args)
    {
        #region Personel Örneği 1
        // Personel Bilgileri 1

        Console.WriteLine("Unitum Cerebris Communitas Personel Listesi");
        Console.WriteLine("-------------------------------------------");

        // şimdi nesnemizi yaratalım
        // manuel/method yoluyla olarak dolduralım

        //clsPersonel1 per1 = new clsPersonel1();
        //per1.setPersonelData(1, "Ümit", "KARAÇİVİ", "12345678901", "IT", 1);
        //per1.getPersonelData();

        //clsPersonel1 per2 = new clsPersonel1(); // başka bir nesne oluşturuyorum
        //per2.setPersonelData(2, "Nurgül", "KARAÇİVİ", "12345678901", "HR", 1000);
        //per2.getPersonelData();

        //clsPersonel1 per3 = new clsPersonel1(); // başka bir nesne oluşturuyorum
        //per3.setPersonelData(3, "Doğa Bengi", "KARAÇİVİ", "12345678901", "UCC Museum", 100000);
        //per3.getPersonelData();

        #endregion 

        #region Öğrenci örneği
        // bir class yaratılacak ismi clsOgrenci olsun
        // tutulacak bilgiler öğr no,adsoyad,ders ve ders notu olacak
        // 2 tane metodumuz olcak
        // bir tanesi öğrencinin verilerini ekrana döksün
        // bir tanesi de öğrencinin aldığı nota göre 50 kontrol değeri...geçti kaldı desin

        clsOgrenci ogr1 = new clsOgrenci();

        ogr1.OgrNo = 1;
        ogr1.OgrAdSoyad = "Ümit Karaçivi";
        ogr1.Ders = "Astroloji";
        ogr1.DersNot = 35;

        ogr1.OgrenciYaz();

        ogr1.NotKontrol(ogr1.DersNot);


        clsOgrenci ogr2 = new clsOgrenci();

        ogr2.OgrNo = 2;
        ogr2.OgrAdSoyad = "Bill Gates";
        ogr2.Ders = "Girişimcilik";
        ogr2.DersNot = 75;

        ogr2.OgrenciYaz();

        ogr2.NotKontrol(ogr2.DersNot);

        #endregion



        Console.ReadKey();
    }

    #region class and Methods
    class clsPersonel1
    {
        // Şimdi sıra geldi sınıfımın özelliklerini (properties) tanımlama

        // Properties
        public int PersonelID;
        public string Ad;
        public string Soyad;
        public string TCKNo;
        public string Bolum;
        public int Maas;

        public void setPersonelData(int pID,string pAd,string pSoyad,string pTCKNo,string pBolum,int pMaas)
        {
            // Bu metot class/object bilgilerini set etmek için kullanılacak
            PersonelID = pID;
            Ad = pAd;
            Soyad = pSoyad;
            TCKNo = pTCKNo;
            Bolum = pBolum;
            Maas = pMaas;
        }

        public void getPersonelData()
        {
            // Bu metot class/object bilgileri get etmek için kullanılacak

            Console.WriteLine($"\n\nPersonel No : {PersonelID}\nAdı ve Soyadı : {Ad} {Soyad}\nTCKNo : {TCKNo}\nBolum : {Bolum}\nMaaş : {Maas} PNG Kina");
        }



    }

    class clsOgrenci
    {
        public int OgrNo;
        public string OgrAdSoyad;
        public string Ders;
        public int DersNot;

        public void OgrenciYaz()
        {
            Console.WriteLine("Öğrenci AdSoyad {0} Ders {1}",OgrAdSoyad,Ders);
        }

        public void NotKontrol(int pNot)
        {
            if (pNot < 50)
            {
                Console.WriteLine("Dersten mealesef çaktınız....\n\n");

            }
            else
            {
                Console.WriteLine("Dersten geçtiniz...Hayatta başarılar...");
            }
        }

    }

    #endregion

}