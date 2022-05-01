using System;
namespace whıle
{
    class program
    {
        static void Main(string[]args)
        {
            //while
            //1den başlayarak  console dan girilen sayıya kadar oratalama hesaplayıp yazdıran program
            Console.WriteLine("lütfen bir sayı giriniz");
            int sayı= int.Parse(Console.ReadLine());
            int sayac=1;
            int toplam=0;
            while (sayac<=sayı)
            {
                toplam+= sayac;
                sayac ++;
            }
            Console.WriteLine(toplam/sayı);

            //a dan z ye kadar harfleri yazdır
            char character='a';
            while (character <='z')
            {
                Console.WriteLine(character);
                character++;
            } 

            Console.WriteLine("********** foreach***********");
            string [] arabalar= {"bmw","toyota","mersedes","nissan"};
            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba);
            }
        }
    }
}