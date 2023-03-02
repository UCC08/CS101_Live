using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Inheritance
{
    internal class clsSubTutorials : clsTutorials 
        // Alt sınıf olan clsSubTutorials da olmayan bir metodu-daha önceden yazılmış aama faklı bir sınıfta- durumlarında kullanabilmek için 
        // Üst sınıf olan clsTutorials'dan miras aldırttım
    {

        public void DersAdiBelirle(string pNewName)
        {
            TutorialName= pNewName;
        }
    }
}
