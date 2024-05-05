
using System;
using Entities.Concrete;

using Business.Concrete;



namespace Workaround
{
    public class Program
    {
        Person person1 = new Person();
        static void Main(string[] args)
        {


            SelamVer("Engin");
            SelamVer("Ahmet");
            SelamVer("Musti ");
            SelamVer();
            int sonuc= Topla(3,5);
            int deger= Topla();

            //Diziler /arrays
            String [] ogrenciler = new string[3];
            ogrenciler[0] = "Ahmet";
            ogrenciler[1] = "Musti";
            ogrenciler[2] = "Fatih";

            String[] sehirler = new[] {"Antalya",
                "Ankara","Kars" };

            String[] sehirler2 = new[] {"Adana",
                "Bursa","Mersin" };

        
            
            

            foreach(string sehir in sehirler)
            {
                Console.WriteLine(sehir);
            }
            //Burada ben PTT_Manager sınıfını buraya çağıramıyorum.Neden??



            PTT_Manager pTT_Manager = new PTT_Manager(new ForeignerManager());

            pTT_Manager.GiveMask(person1);
           
           
            Console.ReadLine();

        }

        static void SelamVer(String isim="Noname")
        {
            Console.WriteLine("Merhaba "+isim);
        }
        static int Topla(int sayi1=5,int sayi2=1)
        { 
            int sonuc= sayi1+sayi2;
             Console.WriteLine("Toplam "+sonuc);
            return sonuc;
            
        }
    }
}