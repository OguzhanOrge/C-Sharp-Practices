using System;
namespace üc
{
    class program
    {
        static void Main(string [] args)
        {
            Console.WriteLine("bir sayı girin");
            int n=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(n +"adet kelime girin");
            String[] dizi=new string[n];
            for (int i = 0; i < n; i++)
            {
                dizi[i]=Console.ReadLine();
            }
            Array.Reverse(dizi);
            Console.WriteLine("tersten");
            foreach (var item in dizi)
            {
                Console.WriteLine(item);
            }
            
        }
    }
}