using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
   public class Canlılar
    {
        public void Beslenme()
        {
            Console.WriteLine("Beslenme yapar");
        }
        public void Solunum()
        {
            Console.WriteLine("Solunum yapar");
        }
        public void Bosaltım()
        {
            Console.WriteLine("Bosaltım yapar");
        }
        public virtual void uyaranlaratepki (){
            Console.WriteLine("canlılar uyaranlara tepki verir");
        }
    }
}