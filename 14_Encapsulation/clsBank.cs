using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Encapsulation
{
    internal class clsBank
    {
        #region Normal Durum
        public long AccountNumber; // Hesap No
        public string Name;
        public int Balance; // Miktar

        public void GetBalance()
        {

        }

        public void WithdrawAccount()
        {

        }

        public void Deposit()
        {

        }
        #endregion


        #region getter/setter
        //private double balance; // yani burada dışarıya kapalı bir değişgen tanımı var

        //// set (setter) / get (getter) metotlarının tanımlanması


        //// Public getter metod
        //// bu metot balance değişgeninizde tutulan değeri almak için
        //public double GetBalanceCaps()
        //{
        //    // burada farklı işlemler var...

        //    return balance;
        //}

        //// Public setter method
        //// bu metot balance değişgeninizde tutulan değeri set/değiştirmek/güncelleöek için
        //public void SetBalanceCaps(double balance) // geriye değer döndürmeyen metot
        //{
        //    // burada farklı işlemler var...

        //    this.balance = balance; // sen benim kendi değişgenimi güncelleyceksin(this)

        //}

        #endregion

        #region Eğer sınıfı tasarlarken Kapsülleme(encapsulation) prensibine uymazsak ne olur?

        //public int Amount;

        //Daha sonra, gelecekte, müşteri uygulamanın negatif bir değere izin vermemesini istiyor.Ardından, miktar değişkeninde
        //saklamadan önce kullanıcı tarafından verilen değerleri doğrulamalıyız.Bu nedenle, kapsülleme ilkesini aşağıdaki
        //gibi izleyerek uygulamayı geliştirmemiz gerekir:

        //public int GetAmount() // get metodu
        //{
        //    return Amount;
        //}

        //public void SetAmount(int Amount) //set metodu
        //{
        //    if (Amount > 0)
        //    {
        //        this.Amount=Amount;
        //    }
        //    else
        //    {
        //        throw new Exception("Lütfen pozitif bir sayı girin...");
        //    }

        //}



        #endregion


        #region Properties/değişgenlere de uygulanabilir...
        // Özellikler C#'da tanıtılan yeni bir dil özelliğidir. C# 'daki özellikler, değerleri okuyarak ve yazarak bir sınıfın
        // bir alanının veya değişkeninin korunmasına yardımcı olur. İlk yaklaşım, yani ayarlayıcı ve alıcının kendisi iyidir,
        // ancak C# 'daki veri kapsülleme özelliklerle çok daha pürüzsüz olarak gerçekleştirilebilir.

        private int _Amount1;

        public int Amount1
        {
            get
            {
                return _Amount1;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Lütfen pozitif nir değer giriniz....");
                }
                else
                {
                    _Amount1 = value;
                }
            }

        }


        public int _Amount2 { get; set; } // en sade - kontrolsuz felan kullanım



        #endregion
    }
}
