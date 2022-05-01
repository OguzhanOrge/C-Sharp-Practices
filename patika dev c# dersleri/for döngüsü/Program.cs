using System;
namespace fordöngüsü
{
    class program
    {
        static void Main(string[]args)
        {
            // ekrana girilen sayıya kadar olan tek sayıyı yazdır
            Console.WriteLine("bir sayı giriniz");
            int sayac=Convert.ToInt32(Console.ReadLine());
            for(int i=1;i<sayac;i++)
            {
                if(i%2==1)
                Console.WriteLine("i");
            }
            // 1 ila 1000 arasındaki tek ve cift sayıların toplamını yazdır
            int tektoplam=0;
            int cifttoplam=0;
            for(int i=1;i<1000;i++)
            {
                if(i%2==1)
                tektoplam+=i;
                else
                cifttoplam+=i;
            }

            Console.WriteLine("tektoplam"+tektoplam);
            Console.WriteLine("cifttoplam"+cifttoplam);

            //break,continue
            for (int i = 1; i < 10; i++)
            {
                if(i==4)
                break;
                Console.WriteLine(i);
            }
            for (int i = 1; i < 10; i++)
            {
                if(i==4)
                continue;
                Console.WriteLine(i);
            }
        }
    }
    
}