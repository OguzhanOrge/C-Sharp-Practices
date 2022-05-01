using System;
using System.Collections;
namespace soru1
{
    class program
    {
        static void Main (string [] args)
        {
            ArrayList liste=new ArrayList();
            
            int sayi;
            Console.WriteLine("20 sayı girin");
            for (int i = 0; i < 20; i++)
            {
            Console.WriteLine(i+". sayıyı giriniz");
            sayi=Convert.ToInt32(Console.ReadLine()); 
            liste.Add(sayi);
            }
            liste.Sort();
            int sayi1,sayi2,sayi3;
            sayi1=Convert.ToInt32(liste[0]);
            sayi2=Convert.ToInt32(liste[1]);
            sayi3=Convert.ToInt32(liste[2]);
            Console.WriteLine((sayi1+sayi2+sayi3)/3+"=ilk 3 sayı ortalaması");
            Console.WriteLine(sayi1+sayi2+sayi3+"=ilk 3 sayı toplamı");
            liste.Reverse();            
            sayi1=Convert.ToInt32(liste[0]);
            sayi2=Convert.ToInt32(liste[1]);
            sayi3=Convert.ToInt32(liste[2]);
            Console.WriteLine((sayi1+sayi2+sayi3)/3+"=son 3 sayı ortalaması");
            Console.WriteLine(sayi1+sayi2+sayi3+"=son 3 sayı toplamı");
        }
    }
}