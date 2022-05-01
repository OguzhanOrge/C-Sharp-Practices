using System;
namespace kurucuS
{
    class program
    {
        static void Main(string []args)
        {
            //Söz dizimi
            // class sınıfismi
            //{
            //     [erişim belirleyici] [veri tipi]  özellik adı
            //     [erişim belirleyici] [geri dönüş tipi] Metotadi [Parametre Listesi]}  
            //      {
            //          Metot komutları
            //      }
            //}


            //Erişim belirleyiciler
            //private
            //public
            //Internal
            //protected
            calısan cal1=new calısan();
            cal1.Ad="ahmet";
            cal1.No=111131111;
            cal1.Soyad="örge";
            cal1.Departman="web deveploment";
            cal1.calışanbilgisi();
            calısan cal2 =new calısan("samet","pala",231123,"yabancı dil");
            cal2.calışanbilgisi();
            calısan cal3 =new calısan("samet","pala");
            cal3.calışanbilgisi();
        }
    }
    class calısan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;
        public calısan(string ad,string soyad ,int no,string departman)
        {
            this.Ad=ad;
            this.Soyad=soyad;
            this.No=no;
            this.Departman=departman;
            
        }
        public calısan(string ad,string soyad)
        {
            this.Ad=ad;
            this.Soyad=soyad;
        }
        public calısan(){}
        public void calışanbilgisi()
        {
            Console.WriteLine("Calışan "+Ad);
            Console.WriteLine("Calışan "+Soyad);
            Console.WriteLine("Calışan "+No);
            Console.WriteLine("Calışan "+Departman);
        }
    }
}