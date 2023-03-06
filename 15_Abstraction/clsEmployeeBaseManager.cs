using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Abstraction
{
    internal abstract class clsEmployeeBaseManager
    {
        // Çalışanlar için temel bilgilerin tutulacağı değişgenler

        private string name, surName, title; // özlük bilgileri
        private double salary; // maaş bilgisi
        private int annualLeave; // Yıllık izin

        // Çalışan kişilerin bilgilerini yazdıracağımız metotlar

        public void getInfo()
        {
            if (annualLeave > 0)
            {
                // Eğer çalışan herhangi bir şekilde oluşturulmadıysa uyarı vermek için
                Console.WriteLine($"< Abstract Company Employee >\n\n-> İsim : {name}\n-> Soyisim : {surName}\n-> Ünvan : {title}\n-> Maaş : {salary} PNG Kina\n-> Yıllık İzin : {annualLeave}\n");

            }
            else
            {
                Console.WriteLine($"< Employee Bulunamadı >\n\n");
            }
        }

        // Çalışan kişilerin bilgilerini set edeceğimiz metot

        public void setInfo(string pName,string pSurname,double pSalary)
        {
            if (pName.Length >= 3 && pSurname.Length >=2)
            {



                if (pSalary >= 8500)
                {
                    this.name = pName;
                    this.surName = pSurname;
                    this.salary = pSalary;

                    if (pSalary >= 8500 && pSalary <= 12000)
                    {
                        this.title = "Deneyimli " + title;
                        this.annualLeave = 20;

                    }
                    else if (pSalary > 12001 && pSalary <= 15000)
                    {
                        this.title = "Kıdemli " + title;
                        this.annualLeave = 24;
                    }
                    else if (pSalary >= 15001)
                    {
                        this.title = "Uzman " + title;
                        this.annualLeave = 30;
                    }
                    else
                        this.annualLeave = 14;

                }
                else
                    Console.WriteLine("<ERROR>\n\n-> Çalışanınıza minimum 8500 vermeniz gerekmektedir. O yüzden çalışan kaydı oluşturulamamıştır..\n");

            }
            else
                Console.WriteLine("<ERROR>\n\n-> Çalışan isim/soyisim uzunluğu gerekli kriterler uymuyor...Kontrol ediniz....\n");

        }

        // Maaş bilgilerine erişim sağlacak Getter/Setter metotları

        public double getSalary() // maaşı öğrenme kısmı
        {
            return salary;
        }

        public void setSalary(double pSalary)
        {
            this.salary = pSalary;
        }
        // Ünvan bilgilerine erişim sağlacak Getter/Setter metotları
        public void setTitle(string pTitle)
        {
            this.title = pTitle;
        }


        // Her nesne için Özel Zam seçenekleri olabileceği için Abstract Metotlar tanımlanıyor + polymorphism kullanılıyor

        public abstract void doRaise(); // düz zam
        public abstract void doRaise(double prmRaiseRate); // zam + prim

    }
}
