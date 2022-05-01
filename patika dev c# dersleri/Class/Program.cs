using System;
namespace CLass
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
            cal1.ad="ahmet";
            cal1.no=111131111;
            cal1.soyad="örge";
            cal1.departman="web deveploment";
            cal1.calışanbilgisi();
        }
    }
    class calısan
    {
        public string ad;
        public string soyad;
        public int no;
        public string departman;
        public void calışanbilgisi()
        {
            Console.WriteLine("Calışan "+ad);
            Console.WriteLine("Calışan "+soyad);
            Console.WriteLine("Calışan "+no);
            Console.WriteLine("Calışan "+departman);
        }
    }
}