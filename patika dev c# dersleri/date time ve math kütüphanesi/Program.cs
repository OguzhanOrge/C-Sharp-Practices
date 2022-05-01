using System;

namespace datemath
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);//şu anın zamanını yazar 
            Console.WriteLine(DateTime.Now.Date);//şu anın tarihini yazar
            Console.WriteLine(DateTime.Now.Day);//şu anın gününü yazar
            Console.WriteLine(DateTime.Now.Month);//şu anın ayını yazar
            Console.WriteLine(DateTime.Now.Year);//şu anın yılını yazar
            Console.WriteLine(DateTime.Now.Hour);//şu anın saatini yazar
            Console.WriteLine(DateTime.Now.Minute);//şu anın dakikasını yazar
            Console.WriteLine(DateTime.Now.Second);//şu anın saniyesini yazar

            Console.WriteLine(DateTime.Now.ToLongDateString());
            Console.WriteLine(DateTime.Now.ToShortDateString());
            Console.WriteLine(DateTime.Now.ToLongTimeString());
            Console.WriteLine(DateTime.Now.ToShortTimeString());

            Console.WriteLine(DateTime.Now.AddDays(2));
            Console.WriteLine(DateTime.Now.AddHours(3));
            Console.WriteLine(DateTime.Now.AddSeconds(30));
            Console.WriteLine(DateTime.Now.AddMonths(5));
            Console.WriteLine(DateTime.Now.AddYears(10));
            Console.WriteLine(DateTime.Now.AddMilliseconds(50));

            //dateTime format
            
            Console.WriteLine(DateTime.Now.ToString("dd"));
            Console.WriteLine(DateTime.Now.ToString("ddd"));
            Console.WriteLine(DateTime.Now.ToString("dddd"));

            Console.WriteLine(DateTime.Now.ToString("M"));
            Console.WriteLine(DateTime.Now.ToString("MMM"));
            Console.WriteLine(DateTime.Now.ToString("MMMM"));

            Console.WriteLine(DateTime.Now.ToString("yy"));
            Console.WriteLine(DateTime.Now.ToString("yyyy"));

            //math kütüphanesi
            Console.WriteLine("math kütüphanesi");
            Console.WriteLine(Math.Abs(-25));
            Console.WriteLine(Math.Sin(10));
            Console.WriteLine(Math.Cos(10));
            Console.WriteLine(Math.Tan(10));

            Console.WriteLine(Math.Ceiling(22.3));
            Console.WriteLine(Math.Round(22.3));
            Console.WriteLine(Math.Round(22.7));
            Console.WriteLine(Math.Floor(22.7));

            Console.WriteLine(Math.Max(2,6));
            Console.WriteLine(Math.Min(2,6));

            Console.WriteLine(Math.Pow(3,4));//3 üzeri 4 ü verir
            Console.WriteLine(Math.Sqrt(9));//karekök alır
            Console.WriteLine(Math.Log(9));//9 un e tabanındaki logaritmik karşılığı
            Console.WriteLine(Math.Exp(3));//e üzeri 3 ü verir
            Console.WriteLine(Math.Log10(10));//10 sayısının logaritma  10 tabanındaki  karşılığı
        }
        
    }
}