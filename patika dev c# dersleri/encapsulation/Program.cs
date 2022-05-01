using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capsulleme
{
    class program
    {
        static void Main(string[] args)
        {
        Ogrenci ogrenci =new Ogrenci();
         ogrenci.Isim="samet";
         ogrenci.Soyisim="pala";
         ogrenci.OgrenciNo=213123;
         ogrenci.Sinif=2;
         ogrenci.bilgiler();
         Ogrenci ogrenci1 =new Ogrenci("ahmet","özer",232,1);
         ogrenci1.bilgiler();

        }
    }
    class Ogrenci
    {
        private string isim;
        private string soyisim;
        private int sinif ;
        private int öğrencino;
        public string Isim
        {
            get{ return isim;}
            set{isim=value;}
        }

        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int OgrenciNo { get => öğrencino; set => öğrencino = value; }
        public int Sinif 
        {
            get=> sinif;
            set
            {
                if(value<=1)
                {
                    Console.WriteLine("sınıf 1 den kucuk olamamaz");
                    sinif=1;
                }
                else
                {
                    sinif=value;
                }
            }
        }

        public Ogrenci(string ısim, string soyisim, int ogrenciNo, int sinif)
        {
            Isim = ısim;
            Soyisim = soyisim;
            OgrenciNo = ogrenciNo;
            Sinif = sinif;
        }
        public Ogrenci(){}
        public void bilgiler()
        {
            Console.WriteLine("bilgi "+this.Isim);
            Console.WriteLine("bilgi "+this.Soyisim);
            Console.WriteLine("bilgi "+this.Sinif);
            Console.WriteLine("bilgi "+this.OgrenciNo);
        }
        public  void sınıfatlat()
        {
                this.Sinif=this.Sinif+1;
        }
        public  void sınıfdüşür()
        {
                this.Sinif=this.Sinif-1;
        }
    }
}