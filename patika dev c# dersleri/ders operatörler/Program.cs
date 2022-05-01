using System;
namespace operatörler
{
    class program
    {
        static void Main(string[] args)
        {
            // atama ve işlemli atama
            int x=3;
            int y=3;
            y=y+2;

            Console.WriteLine(y);
            y+=2;
            Console.WriteLine(y);
            y/=1;
            Console.WriteLine(y);
            x*=2;
            Console.WriteLine(y);
            
            //Mantıksal Operatörler
            //!!,&&,!

            bool isSucces= true;
            bool isComleted= false;
            if(isSucces&&isComleted)
            Console.WriteLine("pefect");
            if(isComleted||isSucces)
            Console.WriteLine("greath");
            if(isSucces&&!isComleted)
            Console.WriteLine("fine");

            Console.WriteLine("************ilişkisel operatörler**************");
            //İlisşkisel operatörler
            //<,>,>=,<=,==,!=

            int a= 3;
            int b= 4;
            bool sonuc =a<b;

            Console.WriteLine(sonuc);
            sonuc=a>b;
            Console.WriteLine(sonuc);
            sonuc=a>=b;
            Console.WriteLine(sonuc);
            sonuc=a<b;
            Console.WriteLine(sonuc);
            sonuc=a==b;
            Console.WriteLine(sonuc);
            sonuc=a!=b;
            Console.WriteLine(sonuc);
            
            Console.WriteLine("**********aritmatik öperatörler********");
            // /,+,-,*

            int sayi1=10;
            int sayi2=5;
            int sonuc1 =sayi1/sayi2;
            Console.WriteLine(sonuc1);
            sonuc1 =sayi1*sayi2;
            Console.WriteLine(sonuc1);
            sonuc1 =sayi1+sayi2;
            Console.WriteLine(sonuc1);
            sayi1+=1;
            Console.WriteLine(sayi1);

            // % mod alma
            int sonuc2=20%3;
            Console.WriteLine(sonuc2);
       
        }
    }
}
