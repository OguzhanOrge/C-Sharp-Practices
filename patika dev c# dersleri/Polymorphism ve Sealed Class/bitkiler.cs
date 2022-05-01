using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
   public class Bitkiler :Canlılar
    {

        public void Fotosentez()
        {
            Console.WriteLine("Bitkiler fotosentez yapar");
        }
        public override void uyaranlaratepki()
        {
            //base.uyaranlaratepki();
            Console.WriteLine("bitkiler güneşe tepki verir");
        }

    }

    public class TohumluBitkiler : Bitkiler
    {
        public void TohumlaCogalır()
        {
            Console.WriteLine(" Tohumlu Bitkiler Tohumla cagalır");
            base.uyaranlaratepki();
            base.Bosaltım();
            base.Beslenme();
            base.Solunum();
            base.Fotosentez();
        } 

    }

    public class TohumsuzBitkiler : Bitkiler
    {
        public void SporlaCogalır()
        {
            Console.WriteLine("Tohumsuz Bitkiler Sporla cagalır");
            base.uyaranlaratepki();
            base.Bosaltım();
            base.Beslenme();
            base.Solunum();
            base.Fotosentez();
        }

    }
}