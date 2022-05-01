using System;
using System.Collections.Generic;
namespace Dictionary
{
    class program
    {
        static void Main(string[]args)
         {
             //System.collection.generic
             Dictionary<int,string> kullanıcılar= new Dictionary<int, string>();

             kullanıcılar.Add(62,"ahmet");
             kullanıcılar.Add(124,"oguz");
             kullanıcılar.Add(31,"samet");

             //dizinin eleman erişim
             Console.WriteLine("***** Elemanlara Erişim");
             Console.WriteLine(kullanıcılar[31]);
             foreach (var item in kullanıcılar)
             Console.WriteLine(item);

             //count
             Console.WriteLine("********Count******");
             Console.WriteLine(kullanıcılar.Count);

             //Contains
             Console.WriteLine("********Contains******");
             Console.WriteLine(kullanıcılar.ContainsKey(31));
             Console.WriteLine(kullanıcılar.ContainsValue("yunus"));

            //remove
            Console.WriteLine("*****Remove*******");
            kullanıcılar.Remove(31);
            foreach (var item in kullanıcılar)
            Console.WriteLine(item);


            //Key
            Console.WriteLine("*****Key*******");
            foreach (var item in kullanıcılar.Keys)
            Console.WriteLine(item);


            //remove
            Console.WriteLine("*****Value*******");
            foreach (var item in kullanıcılar.Values)
            Console.WriteLine(item);
         }
    }
}