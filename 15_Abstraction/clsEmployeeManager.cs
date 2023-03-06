using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Abstraction
{
    // İşletme içerisinde beden işçisi statüsünde çalışan kişiler için EmployeManager isminde bir sınıf
    // oluşturarak bu sınıfı kalıtım yolu ile üst sınıfını clsEmployeeBaseManager seçerek gerekli kodları yazalım…
    internal class clsEmployeeManager : clsEmployeeBaseManager
    {
        public clsEmployeeManager() // bu class/nesne ilk oluştuğunda default en taban Title tanımını oluşturmak için
        {
            setTitle("Beden İşçisi");
        }

        public override void doRaise() // Çalışana zam yapan metot
        {
            double salary = getSalary(); // yani oluşturulmuş olan çalışanın o anki maaşını öğreniyorum.
            double raise = salary + 500; // raise --> zamlı maaşım olmuş oluyor...

            setSalary(raise); // Çalışanın yeni zamlı maaşı işlendi.

        }

        public override void doRaise(double prmRaiseRate) // Çalışana zam yapma (+prim) metot
        {
            double salary=getSalary();

            double raise = salary + (salary * prmRaiseRate);

            setSalary(raise); // Yeni güncellenmiş maaş...
        }
    }
}
