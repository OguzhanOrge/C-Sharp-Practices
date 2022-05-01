using System;
namespace ifelse
{
    class program
    {
        static void Main(string[]args)
        {
            int time =DateTime.Now.Hour;
            if(6<time &&time<11)
            {
            Console.WriteLine("günaydın");
            }
            else if(time<=18)
            {
            Console.WriteLine("iyi günler");
            }
            else
            {
            Console.WriteLine("iyi geceler");    
            }
            string sonuc = time<=18 ? "iyi günler ":"iyi geceler";
            sonuc = time>=6 && time<11 ? "Günaydın ":time<=18 ? "İyi günler":"iyi geceler";
            Console.WriteLine(sonuc);


        }
    }
}