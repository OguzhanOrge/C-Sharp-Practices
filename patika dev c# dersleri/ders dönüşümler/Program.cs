﻿using System;
namespace dönüşümler
{
    class program
    {
        static void Main (string[] args)
        {
            //implicit dönüşüm(Bilincsiz)
            
            byte a=5;
            sbyte b=10;
            short c=30;

            int d=a+b+c;
            Console.WriteLine("d:"+d);

            long h =d;
            Console.WriteLine("h:"+h);

            float i=h;
            Console.WriteLine("i:"+i);

            string e=". . .";
            char f='k';
            object g =d+f+e;
            Console.WriteLine("g:"+g);

            //excplicit dönüşüm ( Bilicli)

            Console.WriteLine("*******excplicit dönüşüm********");
            int x=4;
            decimal y=(decimal)x;
            Console.WriteLine("y"+y);

            float w =10.3f;
            byte v=(byte)w;
            Console.WriteLine("v"+w);

            //******* ToString Metodu*********
            Console.WriteLine("*******ToString*********");
            int xx=6;
            string yy=xx.ToString();
            Console.WriteLine("yy",yy);
            string zz=12.5f.ToString();
            Console.WriteLine("zz",zz);

            //sysytem.Convert
            string s1="10",s2="20";
            int sayi1,sayi2;
            int Toplam;

            sayi1=Convert.ToInt32(s1);
            sayi2=Convert.ToInt32(s2);

            Toplam =sayi1+sayi2;
            Console.WriteLine("toplam"+Toplam);

            //parse

            Console.WriteLine("***parse metodu****");
            ParseMethod();
        }
        public static void ParseMethod()
        {
        string metin1="10";
        string metin2="10.25";
        int rakam1;
        double double1;

        rakam1=Int32.Parse(metin1);
        double1=double.Parse(metin2);

        Console.WriteLine("rakam1"+rakam1);
        Console.WriteLine("double1"+double1);
        }
    }
}