using System;
namespace bir
{
    class program

    {
        static void Main(string[] args)
        {
            Console.WriteLine("bir sayı girin");
            int n=Convert.ToInt32(Console.ReadLine());
            int[] dizi=new int[n];
            Console.WriteLine("diziye sayılar girin");
            for (int i = 0; i < n; i++)
            {
                dizi[i]=Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("cift olanlar");
            foreach(int sayı in dizi)
            {
                if (sayı%2==0)
                {
                    Console.WriteLine(sayı);
                }
            }
        }
    }
}