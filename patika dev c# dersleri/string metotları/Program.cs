using System;
namespace stringmetot
{
    class program
    {
        static void Main(string[]args)
        {
            string degişken=" Dersimiz Cshrap, Hoşgeldiniz";
            string degişken2="Hoşgeldiniz";
            //lenght kac karakter olduğunu yazar
            Console.WriteLine(degişken.Length);

            //Toupper buyuharf yapar Tolower kücük harf yapar
            Console.WriteLine(degişken.ToUpper());
            Console.WriteLine(degişken.ToLower());

            //Concat birleştirme yapar
            Console.WriteLine(string.Concat(degişken,"yazı","...."));

            //Compare,CompareTo
            Console.WriteLine(degişken.CompareTo(degişken2));//karakter uzunluğuklarını karşılaştırı
            Console.WriteLine(string.Compare(degişken,degişken2,true));//1,0,-1 değerlik alır buyuk kücük harf uyumuna bakmadan karşılaştırı
            Console.WriteLine(string.Compare(degişken,degişken2,false));//1,0,-1 değerlik alır

            //contains
            Console.WriteLine(degişken.Contains(degişken2));//degişken1 in icerisinde degişken 2 varmı
            Console.WriteLine(degişken.EndsWith("Hoşgeldiniz"));//degiken hoşgeldiniz ile başlıyormu
            Console.WriteLine(degişken.StartsWith("Csharp"));//değşken csharp ile bitiyormu

            //ındexof
            Console.WriteLine(degişken.IndexOf("CS"));// CS nin değiken icinde kacınca karakte olduğunu yazar bulamassa -1 yazar
            Console.WriteLine(degişken.LastIndexOf("i"));// istenilen karakterin en sondaki yerini yazar

            //ınsert
            Console.WriteLine(degişken.Insert(0,"merhaba"));//belli indeşten itibaren yazı ekler

            //padleft padright istenilen sayıda karaktere tamamlıcak kadar istenilen karakterden ekler
            Console.WriteLine(degişken+degişken2.PadLeft(30));//toplam karakter uzunluğu 30 olacak şekilde boşluk ekler
            Console.WriteLine(degişken+degişken2.PadLeft(30,'*'));//toplam karakter uzunluğu 30 olacak şekilde * ekler
            Console.WriteLine(degişken.PadRight(50)+degişken2);
            Console.WriteLine(degişken.PadRight(50,'-')+degişken2);

            //Remove
            Console.WriteLine(degişken.Remove(10));//10. karakterden sonuna kadar siler
            Console.WriteLine(degişken.Remove(5,3));//5. karakterden başlayarak 3 karakter sil

            //Replace   
            Console.WriteLine(degişken.Replace("csharp","c#")); //charp yerine c# yazar

            //split 
            Console.WriteLine(degişken.Split(" "));//istenilen karaktere göre değikeni bölüp dizye atar
            Console.WriteLine(degişken.Split(" ")[1]);//bölünen değikenin 1. indexdeki kısmını yazar

            //substring
            Console.WriteLine(degişken.Substring(4));//4. karaterden itibaren yaz
            Console.WriteLine(degişken.Substring(4,3));//4. karakterden itibare 3karakter yaz

            
            
        }
    }
}