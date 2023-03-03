using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Constructor
{
    internal class clsTest
    {
        public int i; // default =0
        public string s;// default = ""
        public bool b; // default= false

        // Kural : class ismiyle aynı olacak bir metot aslında.
        // ctor class devreye girdiğinde otomatik çalışan bir metotdur
        // değişik durumlarda initial işlemler yapmak için kullanılır.

        // parametreli de kullanımı olabilir.
        public clsTest()
        {
            i = 5;
            s = "Merhaba";
            b = true; ;
        }
    }
}
