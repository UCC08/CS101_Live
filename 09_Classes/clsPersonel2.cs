using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Classes
{
    internal class clsPersonel2
    {
        // Değişgenler/Prop ların tanımlanması

        public int PersonelID;
        public string Ad;
        public string Soyad;
        public string Unvan = null;
        public int Maas;
        public int IzinGunu;

        public void setPersonelBilgileri(string pAd,string pSoyad,int pMaas)
        {
            if (pAd.Length > 0 && pSoyad.Length>0) // ad ve soyadın tam girilmesi kontrol edilir
            {
                if (pMaas >= 2500)
                {
                    this.Ad = pAd;
                    this.Soyad= pSoyad;
                    this.Maas= pMaas;
                    this.IzinGunu = 14;


                    if (pMaas >= 10000 && pMaas <= 14000)
                    {
                        this.Unvan = "Kıdemli Personel";
                        this.IzinGunu = 20;
                    }
                    else if (pMaas >= 14001 && pMaas <= 15500)
                    {
                        this.Unvan = "Kıdemli+ Personel";
                        this.IzinGunu = 24;
                    }
                    else if (pMaas > 15500)
                    {
                        this.Unvan = "Uzman Personel";
                        this.IzinGunu = 30;
                    }
                    else
                        this.Unvan = "Junior Personel";
                }
                else
                {
                    Console.WriteLine("\nPersonel oluşturulamadı...");
                }

            }
            else
            {
                Console.WriteLine("\nİsim bilgisi hatalıdır..kontrol ediniz");
            }
        }

        public string getPersonelBilgileri()
        {
            if (Unvan != null)
            {
                return $"Personel Ad : {Ad}\nPersonel Soyad : {Soyad}\nÜnvan : {Unvan}\nMaas : {Maas} PNG Kina\nİzin Günü : {IzinGunu} gün\n";
            }
            else
            {
                return "Lütfen personeli oluşturunuz...";
            }
        }

    }
}
