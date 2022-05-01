using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

namespace Csharpprogramlama
{
    class Program
    {
        static void Main(string[] args)
        {
            byte b= 5; // 1 byte
            byte c =5; //1 byte

            short s= 5; //2byte
            ushort us=5; //2byte

            Int16 i16 =2; // 4byte
            Int32 i32 =2; // 4byte
            Int64 i64 =2; //8byte

            float f=2; // 4byte
            decimal d=2;//16byte
            double dou=2; //8byte
            
            uint ui=2; //4byte
            ulong ul=2;//8byte
            long l=2;//8byte

            char c =2; //2byte
            string str=""; // sınırsız
            
            bool b= true;
            bool b2 =false;
            DateTime dt =DateTime.Now;

            Console.WriteLine(dt);

            object o1="x";
            object o2='y';
            object o3=4;
            object o4=4.3;
            
            // string ifadeler

            string strl="";
            string ad ="";
            string soyad ="";
            string tamad =""+"";

            //integer tanımlama şekilleri

            int integer1=3;
            int integer2=5;
            int integer3=integer1+integer2;

            //boolean

            bool b1=10>2;

            // değişken dönüşümleri
            string  str20 ="20";
            int int20=20 ; 
            string yenideğer=str20 +int20.ToString();
            Console.WriteLine(yenideğer);

            int21 =int20 +int.parse(str20);
            Console.WriteLine(int21); //Cıktısı 40

            int22 =int20 + int.Parse(str20);

            // date time

            string DateTime=DateTime.Now.ToString("dd,mm,yyyy");
            Console.WriteLine(DateTime);
             
            string2 DateTime=DateTime.Now.ToString("dd/mm/yyyy");
            Console.WriteLine(DateTime2);

            //saat
            string hour =DateTime.Now.ToString("hh:mm");
            Console.WriteLine(hour); 
        }


    }


}