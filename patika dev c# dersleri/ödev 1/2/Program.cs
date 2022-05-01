using System;
namespace iki
{
    class program
    {
        static void Main(string[]args)
        {
            Console.WriteLine("2 adet sayı giriniz (n,m)");
            Console.WriteLine("ilk n");
            int n=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("şimdi m");
            int m=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(n+ "adet sayı girin");
            int[] dizi= new int[n];
            for (int i = 0; i < n; i++)
            {
             dizi[i]=Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("sonuc");
            foreach (var item in dizi)
            {
                if(m%item==0 && m==item)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}