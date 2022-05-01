using System;
namespace metotlar3
{
    class program
    {
        static void Main(string[]args)
        {
            // rekürsif - öz yinelmemeli
            //3^4 3*3*3*3

            int result =1;
            for(int i=1;i<5;i++)
            {
                result=result*3;    
            }
            Console.WriteLine(result);
            işlemler işlem =new();
            Console.WriteLine(işlem.Expo(3,4));
            //extension metotlar
            string ifade="Oğuzhan Örge";
            Console.WriteLine(ifade);
            Console.WriteLine(ifade.CheckSpace());
            Console.WriteLine(ifade.RemoveWhiteSpaces());
            Console.WriteLine(ifade.büyük());
            Console.WriteLine(ifade.kücük());
        }
    }
    class işlemler
    {
        public int Expo(int sayı,int üs)
        {
            if(üs<2)
            return sayı;
            return Expo(sayı,üs-1)*sayı;
        }
        //expo(3,4)
        //expo(3,3)*3
        //expo(3,2)*3*3
        //expo(3,1)*3*3*3
        //3*3*3*3=3^4
    }
    public static class extension
    {
        public static bool CheckSpace (this string ifade)
        {
            return ifade.Contains(" ");
        }
         public static string RemoveWhiteSpaces (this string ifade)
        {
            string[] dizi =ifade.Split(" ");
            return string.Join("",dizi);
        }
          public static string büyük (this string ifade)
        {
            return ifade.ToUpper();
        }
          public static string kücük (this string ifade)
        {
            return ifade.ToLower();
        }
    }
}