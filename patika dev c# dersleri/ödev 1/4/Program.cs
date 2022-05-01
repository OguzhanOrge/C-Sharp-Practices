using System;
namespace dört
{
    class program
    {
        static void Main (string[] args)
        {
            int sayı=0,sayı2=0;
            Console.WriteLine("bir cümle yazın");
            string cümle=Console.ReadLine();
            string[] dizi=cümle.Split(" ");
            foreach (var item in dizi)
            {
                sayı++;
            }
            Console.WriteLine(sayı+ "cümle ");
             foreach (char c in cümle.ToCharArray())
            {
                sayı2++;
            }
            Console.WriteLine(sayı2-(sayı-1)+ "harf ");
        }
    }
    
}