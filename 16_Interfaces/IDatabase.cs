using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Interfaces
{
    internal interface IDatabase
    {
        // Bu Interface'de sadece metot yapılarını kodsuz olarak tanımlıyoruz. Yani şablonu/yapıyı oluşturuyoruz

        int login(string userName, string password); // db mize giriş yapan metot

        void close(); // dbmizi kapatacak

        void addvalue(string value); // dbmize bir değer ekliyor

        void deletevalue(); // dbmizden değer siler

        void updatevalue(string value); // dbmizde güncelleme yapar

        void getValue(); // dbmizden değer getirir.
    }
}
