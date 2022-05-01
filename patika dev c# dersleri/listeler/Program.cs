using System;
namespace list
{
    class program
    {
        static void Main(string [] args)
        {
            //list<T> class
            //System.Collection.Generic
            //T--> object  türündedir

            List<int> sayılistesi = new List<int>();
            sayılistesi.Add(31);
            sayılistesi.Add(71);
            sayılistesi.Add(61);
            sayılistesi.Add(51);
            sayılistesi.Add(41);
            sayılistesi.Add(21);

            List<string> renklistesi =new List<string>();
            renklistesi.Add("mavi");
            renklistesi.Add("siyah");
            renklistesi.Add("pembe");
            renklistesi.Add("yeşil");
            renklistesi.Add("mor");

            //Count
            Console.WriteLine(renklistesi.Count);
            Console.WriteLine(sayılistesi.Count);

            foreach (var sayi in sayılistesi)
              Console.WriteLine(sayi);
            foreach (var renk in renklistesi)
            Console.WriteLine(renk);

            sayılistesi.ForEach(sayi=>Console.WriteLine(sayi));
            renklistesi.ForEach(renk=>Console.WriteLine(renk));

            //Listeden eleman cıkarma
            sayılistesi.Remove(4);
            renklistesi.Remove("mavi");

            sayılistesi.RemoveAt(0);
            renklistesi.RemoveAt(1);

            sayılistesi.ForEach(sayi=>Console.WriteLine(sayi));
            renklistesi.ForEach(renk=>Console.WriteLine(renk));

            
            //liste icerisinde arama 

            if (sayılistesi.Contains(31))
            {
                Console.WriteLine("sayı listesi icerisinde 31 var");
            }   
                
            //eleman ile index e erişme
            Console.WriteLine(renklistesi.BinarySearch("mavi"));

            //diziyi liste cevirme
            string[] hayvanlar ={"kedi","kopek","kuala"};
            List<string> hayvanlistesi=new List<string>(hayvanlar);

            //listeyi nasıl temizleriz
            hayvanlistesi.Clear();

            //liste icerisinde nesne tutmak
            List<kullanıcılar> kullanıcıListesi= new List<kullanıcılar>();

            kullanıcılar kullanıcı1 =new kullanıcılar();
            kullanıcı1.Isım="ahmet";
            kullanıcı1.Soyisim="özer";
            kullanıcı1.Yas=20;

             kullanıcılar kullanıcı2 =new kullanıcılar();
            kullanıcı2.Isım="samet";
            kullanıcı2.Soyisim="pala";
            kullanıcı2.Yas=26;

            kullanıcıListesi.Add(kullanıcı1);
            kullanıcıListesi.Add(kullanıcı2);

            List<kullanıcılar> yeniListe=new List<kullanıcılar>();

            yeniListe.Add(new kullanıcılar(){
                Isım="yunus",Soyisim="dayan",Yas=21 
            });

        }
    }
    public class kullanıcılar
    {
        private string isim;
        private string soyisim;
        private int yas;

        public string Isım{ get => isim;set=>isim = value;}
        public string Soyisim{ get => soyisim;set=>soyisim = value;}
        public int Yas{ get => yas;set=>yas = value;}

    }
}