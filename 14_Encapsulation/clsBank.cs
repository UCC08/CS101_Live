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
        private double balance; // yani burada dışarıya kapalı bir değişgen tanımı var

        // set (setter) / get (getter) metotlarının tanımlanması


        // Public getter metod
        // bu metot balance değişgeninizde tutulan değeri almak için
        public double GetBalanceCaps()
        {
            // burada farklı işlemler var...

            return balance;
        }

        // Public setter method
        // bu metot balance değişgeninizde tutulan değeri set/değiştirmek/güncelleöek için
        public void SetBalanceCaps(double balance) // geriye değer döndürmeyen metot
        {
            // burada farklı işlemler var...

            this.balance = balance; // sen benim kendi değişgenimi güncelleyceksin(this)

        }










        #endregion

    }
}
