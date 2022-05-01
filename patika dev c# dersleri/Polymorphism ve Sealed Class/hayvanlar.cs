using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
   public class Hayvanlar : Canlılar
    {
        public void Adaptosyon()
        {
            Console.WriteLine("Havanlar Adaptosyon yapar");
        }
        public override void uyaranlaratepki(){
                base.uyaranlaratepki();
                Console.WriteLine("hayvanlar temasa tepki verir");
        }
    }

    public class Surungenler : Hayvanlar
    {
        public void SurunerekHareketEderler()
        {
            Console.WriteLine("Surungenler Surunerek Hareket Ederler");
            base.uyaranlaratepki();
            base.Bosaltım();
            base.Beslenme();
            base.Solunum();
            base.Adaptosyon();
        }

    }

    public class Kuslar : Hayvanlar
    {
        public void Ucmak()
        {
            Console.WriteLine("kuslar uçarlar");
            base.uyaranlaratepki();
            base.Bosaltım();
            base.Beslenme();
            base.Solunum();
            base.Adaptosyon();
        }

    }

}