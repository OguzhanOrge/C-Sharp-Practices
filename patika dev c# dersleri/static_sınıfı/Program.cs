using System;
namespace statik
{
    class program
    {
        static void Main(string[]args)
        {
            Console.WriteLine("calışan sayısı {0}", Calısan.Calısansayısı); 
            Calısan calısan =new Calısan("ahmet","pala","kimya");
            Console.WriteLine("calışan sayısı {0}", Calısan.Calısansayısı);
            Calısan calısan2 =new Calısan("ahmet","pala","kimya");
            Calısan calısan3 =new Calısan("ahmet","pala","kimya");
            Console.WriteLine("calışan sayısı {0}", Calısan.Calısansayısı);
            Console.WriteLine(islem.topla(100,200));
            Console.WriteLine(islem.cıkar(100,200));
        } 
    }
    class Calısan
    {
        private static int calısansayısı;

        public static int Calısansayısı { get => calısansayısı;}

        private string Isim;
        private string Soyisim;
        private string Departman;

        static Calısan ()
        {
            calısansayısı=0;
        }
        public Calısan(string isim,string soyisim,string departman)
        {
            this.Isim=isim;
            this.Soyisim=soyisim;
            this.Departman=departman;
            calısansayısı++;

        }
    } 
    static class islem
    {
        public static int  topla(int sayı,int sayı2)
        {
            return sayı+sayı2;
        }
        public static int  cıkar(int sayı,int sayı2)
        {
            return sayı-sayı2;
        }
    }  
}