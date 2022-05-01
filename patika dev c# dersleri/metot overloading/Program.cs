using System;
namespace overloading
{
    class program
    {
        static void Main(string []args)
        {
            //out parametreler
            string sayi ="999";
            bool sonuc =int.TryParse(sayi,out int outsayi);
            if(sonuc)
            {
                Console.WriteLine("başarılı");
                Console.WriteLine(outsayi);
            }
            else
            {
                Console.WriteLine("başarısız");
            }
            Metotlar instance = new Metotlar();
            instance.Topla(4,5,out int toplamSonucu);
            Console.WriteLine(toplamSonucu);

            int ifade=999;
            instance.EkranaYazdir(Convert.ToString(ifade));
            instance.EkranaYazdir(ifade);
            instance.EkranaYazdir("oğuz","örge");

            //metot imzası
            //metotadı + parametre sayısı + parametre
        }
    }
    class Metotlar
    {
        public void Topla(int a,int b,out int toplam)
        {
            toplam =a+b;
        }
         public void EkranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }

        public void EkranaYazdir(int veri)
        {
            Console.WriteLine(veri);
        }
        public void EkranaYazdir(string veri1, string veri2)
        {
            Console.WriteLine(veri1 + veri2);
        }
        
    }
}