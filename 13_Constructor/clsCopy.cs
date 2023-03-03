using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Constructor
{
    internal class clsCopy
    {
        int x;

        string mesaj = "Parametre geliyor olay değişiyor";
        public clsCopy(int i)
        {
            x = i;

//            Console.WriteLine($"Parametreli ctor/yapıcı çağrıldı...Parametre değeri : {i}");

        }

        public clsCopy(clsCopy obj)
        {
            x= obj.x;
        }

        public void Display()
        {
            Console.WriteLine($"X değişgeninin değeri : {x}");
            //Console.WriteLine($"{mesaj}");

        }


    }
}
