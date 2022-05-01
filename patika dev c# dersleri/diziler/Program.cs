using System;
namespace dizi
{
    class program
    {
        static void Main(string[] args)
        {
            //dizi tanımlama
            string[] renkler= new string[5];
            string[] hayvanlar ={"Kedi","Köpek","Kuş","Maymun"};

            int[] dizi ;
            dizi= new int[5];

            //dizilere değer atama ve erişim
            renkler[0]="mavi";
            dizi[3]=10;

            Console.WriteLine(hayvanlar[1]);
            Console.WriteLine(dizi[3]);
            Console.WriteLine(renkler[0]);

            //döngülerle dizi kullanımı
            //klavyeden girilen n tane sayının ortalamasını hesaplayan program
            Console.WriteLine("lütfen dizini eleman sayısını giriniz");
            int diziUzunluğu =Convert.ToInt32(Console.ReadLine());
            int[] sayıDizisi =new int[diziUzunluğu];

            for (int i = 0; i < diziUzunluğu; i++)
            {
                Console.WriteLine("dizinizn {0} elemanını girin",i+1);
                sayıDizisi[i]=Convert.ToInt32(Console.ReadLine());
            }
            int toplam=0;
            foreach (var sayi in sayıDizisi)
            {
                toplam+= sayi;
            }
                Console.WriteLine("ortalama {0}",toplam/diziUzunluğu);
        }
    }
}
    
