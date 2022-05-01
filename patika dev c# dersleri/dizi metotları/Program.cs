using System;
namespace dizimetot
{
    class program
    {
        static void Main(string []args)
        {
            //Short
            int[] sayıdizisi ={1,43,56,87,453,23};
            Console.WriteLine("*****sırasız dizi*****");
            foreach(var sayi in sayıdizisi)
            {
                Console.WriteLine(sayi);
            }
            Array.Sort(sayıdizisi);
            Console.WriteLine("*****sıralı dizi*****");
            foreach(var sayi in sayıdizisi)
            {
                Console.WriteLine(sayi);
            }
            //clear
            Console.WriteLine("****clear****");
            //sayı dizisinin elemanlarını kullanarak 2. index den itibaren 2 elemanı sıfırlar
            Array.Clear(sayıdizisi,2,2);
            foreach(var sayi in sayıdizisi)
            {
                Console.WriteLine(sayi);
            }
            //reverse
            Console.WriteLine("*****Array reverse*****");
            Array.Reverse(sayıdizisi);
            foreach(var sayi in sayıdizisi)
            {
                Console.WriteLine(sayi);
            }
            //ındexof
            Console.WriteLine("*********indexof*********");
            Console.WriteLine(Array.IndexOf(sayıdizisi,23));
            //resize
            Console.WriteLine("*****array resize*****");
            Array.Resize<int>(ref sayıdizisi,9);
            sayıdizisi[8]=99;
            foreach(var sayi in sayıdizisi)
            {
                Console.WriteLine(sayi);
            }




            
        }
    }
}