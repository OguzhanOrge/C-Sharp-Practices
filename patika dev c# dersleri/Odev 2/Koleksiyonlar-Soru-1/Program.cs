using System;
namespace soru1
{
    class program
    {
        static void Main (string [] args)
        {
            List<int> Asalsayılistesi = new List<int>();
            List<int> sayılistesi = new List<int>();
            int sayi;
            Console.WriteLine("odev 1 20 ader sayıyı asal ve asal deil olarak ayırma");
            for (int i = 0; i < 20; i++)
            {
                int kontrol=0;
            Console.WriteLine("sayı giriniz");
            sayi=Convert.ToInt32(Console.ReadLine()); 
             for (int j = 2; j < sayi/2; j++)
                {
                    if (sayi % j == 0) //Kalansız bölünüyormu?
                    {
                        kontrol++;
                        break; //Diğer sayılara bakmaya gerek duymuyoruz.
                    }  
                }
                if (kontrol != 0)
                {
                    Console.WriteLine("Girdiğiniz sayı asal değildir.");
                    sayılistesi.Add(sayi);
                }
 
                else
                {
                    Console.WriteLine("Girdiğiniz sayı asaldır.");
                    Asalsayılistesi.Add(sayi);
                }   
            }
            Console.WriteLine("asal olmayanlar");
            foreach (var item in sayılistesi)
            Console.WriteLine(item);
            Console.WriteLine("asal sayılar");
            foreach (var item in Asalsayılistesi)
            Console.WriteLine(item);
            
        }
    }
}