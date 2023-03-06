using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Interfaces
{
    internal class clsMongoDbManager : IDatabase
    {
        private string value; // db deki değer
        private string userName = "mongo";
        private string password = "admin";


        public void addvalue(string value)
        {
            this.value = value;
        }

        public void close()
        {
            Console.WriteLine("-> Mongo DB bağlantısı başarılı şekilde sonlandırıldı...\n");
        }



        public void deletevalue()
        {
            this.value = null;

            Console.WriteLine("-> Veritabanı üzerindeki bilgiler silindi...\n");
        }

        public void getValue()
        {
            if (value != null)
            {
                Console.WriteLine($"-> İstediğiniz doğrultuda [{value}] verisi başarılı bir şekilde getirildi...\n");

            }
            else
                Console.WriteLine($"-> Veritabanı içinde herhangi bir değer yoktur...Daha sonra tekrar deneyiniz...\n");

        }

        public int login(string userName, string password)
        {
            if (userName == this.userName && password == this.password)
            {
                return 1; // return true;
            }
            else
                return 0; // return false
        }

        public void updatevalue(string value)
        {
            this.value = value;

            Console.WriteLine("-> Veritabanı üzerindeki bilgiler güncellendi...\n");
        }
    }
}
