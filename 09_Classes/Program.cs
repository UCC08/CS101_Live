using _09_Classes;

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

        //clsOgrenci ogr1 = new clsOgrenci();

        //ogr1.OgrNo = 1;
        //ogr1.OgrAdSoyad = "Ümit Karaçivi";
        //ogr1.Ders = "Astroloji";
        //ogr1.DersNot = 35;

        //ogr1.OgrenciYaz();

        //ogr1.NotKontrol(ogr1.DersNot);


        //clsOgrenci ogr2 = new clsOgrenci();

        //ogr2.OgrNo = 2;
        //ogr2.OgrAdSoyad = "Bill Gates";
        //ogr2.Ders = "Girişimcilik";
        //ogr2.DersNot = 75;

        //ogr2.OgrenciYaz();

        //ogr2.NotKontrol(ogr2.DersNot);

        #endregion

        #region Personel örneği 2
        // bu örneğin amacı class yapısının bu source dosyasından farklı bir yerde tanımlanması ve kullanılması üzerine

        // Bir şirket var
        // 5 elemanı var...Ad, soyad,ünvan,maas ve izingünü
        // bir tane metodum olacak class içinde
        // mu metotda öncelikle adsoyad bilgisinin dolu olduğu durumda
        // maasının miktarına göre o perselin kaç gün izin hakkı olacağı belirlenecek
        // kriterler
        // maas < 2500 ise personelin ünvanının oluşturulamadığını belirten bir mesaj olabilir
        // maas 2500 - 10000 kina arasındaysa junior personel ve izin gün 14
        // maas 10001 - 14000 arasındaysa Kıdemli Personel ve izin günü 20 gün
        // maas 14001 - 15500 arasındaysa Kıdemli+ Personel (sınırlar dahil) ve izin günü 24 gün
        // maas 15500 üstündeyse Uzman Personel ve izin gün sayısı 30
        // olarak çıkış veren şekilde olacak

        // not : personelin maas bilgisinin belirlenmesi bilgisayara bırakılacak ...random...aralık 1000-20000 aralığı olsun..


        // Not : eğer ad ve soyad bilgileri boş gelirse bir uyarı mesajı verilebilir

        // nesnelerimizi sınıftan clsPersonel2 sınıfından oluşturuyoruz
        clsPersonel2 ozcan = new clsPersonel2();
        clsPersonel2 ertugrul = new clsPersonel2();
        clsPersonel2 helin = new clsPersonel2();
        clsPersonel2 berna = new clsPersonel2();
        clsPersonel2 nergis = new clsPersonel2();
        clsPersonel2 snur = new clsPersonel2();
        clsPersonel2 mferit = new clsPersonel2();
        clsPersonel2 nesibe = new clsPersonel2();
        clsPersonel2 ozdenur = new clsPersonel2();
        clsPersonel2 aleyna = new clsPersonel2();
        clsPersonel2 ilker = new clsPersonel2();
        clsPersonel2 busra = new clsPersonel2();
        clsPersonel2 burak = new clsPersonel2();
        clsPersonel2 mdogan = new clsPersonel2();
        clsPersonel2 umit = new clsPersonel2();

        // Bilgi doldurulması
        int maasilk = 1000;
        int maasson = 20000;

        ozcan.setPersonelBilgileri("Özcan", "KARA", new Random().Next(maasilk, maasson));
        ertugrul.setPersonelBilgileri("Ertuğrul", "DAĞLI", new Random().Next(maasilk, maasson));
        helin.setPersonelBilgileri("Helin", "AYDIN", new Random().Next(maasilk, maasson));
        berna.setPersonelBilgileri("Berna", "ELKOVAN", new Random().Next(maasilk, maasson));
        nergis.setPersonelBilgileri("Nergis", "KETENCİ", new Random().Next(maasilk, maasson));
        snur.setPersonelBilgileri("Saadet Nur", "KARAKAŞ", new Random().Next(maasilk, maasson));
        mferit.setPersonelBilgileri("Muhammet Ferit", "ŞİMŞEK", new Random().Next(maasilk, maasson));
        nesibe.setPersonelBilgileri("Nesibe", "KOSANOĞLU", new Random().Next(maasilk, maasson));
        ozdenur.setPersonelBilgileri("Özdenur", "KOYUNCU", new Random().Next(maasilk, maasson));
        aleyna.setPersonelBilgileri("Aleyna", "ÖZ", new Random().Next(maasilk, maasson));
        ilker.setPersonelBilgileri("İlker", "KAPLAN", new Random().Next(maasilk, maasson));
        busra.setPersonelBilgileri("Büşra", "KÖSE", new Random().Next(maasilk, maasson));
        burak.setPersonelBilgileri("Burak", "ACAR", new Random().Next(maasilk, maasson));
        mdogan.setPersonelBilgileri("Mehmet Doğan", "ERBAY", new Random().Next(maasilk, maasson));
        umit.setPersonelBilgileri("Ümit", "KARAÇİVİ", new Random().Next(maasilk, maasson));

        // Bilgilerin okunması
        Console.WriteLine(ozcan.getPersonelBilgileri());
        Console.WriteLine(ertugrul.getPersonelBilgileri());
        Console.WriteLine(helin.getPersonelBilgileri());
        Console.WriteLine(berna.getPersonelBilgileri());
        Console.WriteLine(nergis.getPersonelBilgileri());
        Console.WriteLine(snur.getPersonelBilgileri());
        Console.WriteLine(mferit.getPersonelBilgileri());
        Console.WriteLine(nesibe.getPersonelBilgileri());
        Console.WriteLine(ozdenur.getPersonelBilgileri());
        Console.WriteLine(aleyna.getPersonelBilgileri());
        Console.WriteLine(ilker.getPersonelBilgileri());
        Console.WriteLine(busra.getPersonelBilgileri());
        Console.WriteLine(burak.getPersonelBilgileri());
        Console.WriteLine(mdogan.getPersonelBilgileri());
        Console.WriteLine(umit.getPersonelBilgileri());



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