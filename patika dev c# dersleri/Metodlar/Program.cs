using System;
namespace metodlar
{
    class program
    {
        static void Main(string[] args)
        {
            //eişim_belirteci geri_dönüşüm_tipi metot_adı(parametreListesi/arguman)
            //{
                //komutlar:
                //return:
            //}
            int a=2;
            int b=3;
            Console.WriteLine(a+b);
            int sonuc=topla(a,b);
            Console.WriteLine(sonuc);
            Metotlar örnek=new Metotlar{};
            örnek.ekrana_yazdır(Convert.ToString(sonuc));
            
            int sonuc2 =örnek.arttırvetopla(ref a,ref b);
            örnek.ekrana_yazdır(Convert.ToString(sonuc2));
            örnek.ekrana_yazdır(Convert.ToString(a+b));

        }
        static int topla(int sayi1,int sayi2)
        {
            return (sayi1+sayi2);
        }
    }
    class Metotlar
    {
        public void ekrana_yazdır(string yazı)
        {
            Console.WriteLine(yazı);
        }

        public int arttırvetopla(ref int deger1,ref int deger2)
        {
            deger1+=1;
            deger2+=1;
            return deger1+deger2;
        }
    }
}