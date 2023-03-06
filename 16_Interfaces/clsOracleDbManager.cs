using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Interfaces
{
    internal class clsOracleDbManager : IDatabase
    {
        private string value; // db deki değer
        private string userName = "oracle";
        private string password = "admin";


        public void addvalue(string value)
        {
            this.value = value;
        }

        public void close()
        {
            Console.WriteLine("-> Oracle DB bağlantısı başarılı şekilde sonlandırıldı...\n");
        }

        public void deletevalue(string value)
        {
            this.value
        }

        public void getValue()
        {
            throw new NotImplementedException();
        }

        public int login(string userName, string password)
        {
            throw new NotImplementedException();
        }

        public void updatevalue(string value)
        {
            throw new NotImplementedException();
        }
    }
}
