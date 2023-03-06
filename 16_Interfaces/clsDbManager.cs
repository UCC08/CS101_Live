using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Interfaces
{
    // Dblerimi yönetecek
    internal class clsDbManager
    {
        private IDatabase database; // Interfaceden bir değişgen tanımlıyorum.

        public clsDbManager() // Default Constructor
        {

        }

        public clsDbManager(IDatabase database) // Parametrik constructor.. Ben buraya o anki db classının kendisini göndercem
        {
            this.database = database; // O anki gelen db parametresine göre içsel değeri değiştiriyorum.

        }

        public void loginDB() // Sistem giriş
        {
            string userName, password;

            Console.WriteLine("< Veri Tabanı Bağlantısı >\n\n-> Kullanıcı Adı : ");
            userName=Console.ReadLine();

            Console.WriteLine("-> Kullanıcı Şifresi : ");
            password = Console.ReadLine();


            if (true)
            {

            }
        }

    }
}
