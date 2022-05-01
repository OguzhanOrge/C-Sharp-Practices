using System;
namespace enu
{
    class program
    {
        static void Main (string[]args)
        {
            Console.WriteLine(günler.pazar);
            int sıcaklık1=2;
            if (sıcaklık1<=(int)sıcaklık.normal)
            {
                    Console.WriteLine("hava soğuk");
            }
            else if(sıcaklık1>=(int)sıcaklık.sıcak)
            {
                Console.WriteLine("hava sıcak");
            }
            else if(sıcaklık1>=(int)sıcaklık.normal &&sıcaklık1<=(int)sıcaklık.coksıcak)
            {
                Console.WriteLine("sıcaklık normal");
            }
        }
    }
    enum günler
    {
        pazartesi,
        salı,
        carşamba,
        perşembe,
        cuma,
        cumartesi,
        pazar=8,
    }
    enum sıcaklık
    {
        soğuk=5,
        normal=20,
        sıcak =25,
        coksıcak=39,
    }
}