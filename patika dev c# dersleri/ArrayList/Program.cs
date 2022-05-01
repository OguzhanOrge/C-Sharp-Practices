using System;
using System.Collections;
namespace arraylist
{
    class program
    {
        static void Main(string [] args)
        {
            //System.Collections namespace

            ArrayList liste=new ArrayList();
            liste.Add("oğuz");
            liste.Add(3);
            liste.Add(true);
            liste.Add('a');

            //icerisinde verilere erişim
            Console.WriteLine(liste[1]);
            foreach (var item in liste)
            Console.WriteLine(item);

            //AddRange
            Console.WriteLine("***********add range*********");
            string[] renkler ={"mavi","sarı"};
            List<int> sayılar = new List<int>(){1,2,4,6,3,5};
            liste.AddRange(renkler);
            liste.AddRange(sayılar);

            foreach (var item in liste)
            Console.WriteLine(item);

            //sort
            Console.WriteLine("******sort*******");
            liste.Sort();

            foreach (var item in liste)
            liste.Sort();

            //binary Search
            Console.WriteLine("*********Binary Search*********");
            Console.WriteLine(liste.BinarySearch(9));

            //Reverse
            Console.WriteLine("********Reverse******");
            liste.Reverse();

            foreach (var item in liste)
            Console.WriteLine(item);

            //Clear
            liste.Clear();

            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }
        }
    }
}