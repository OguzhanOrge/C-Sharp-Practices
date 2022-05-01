using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace inheritance
{
    class program
    {
        static void Main(string[]args)
        {
            TohumluBitkiler tohumluBitkiler = new TohumluBitkiler();
            tohumluBitkiler.Beslenme();
            tohumluBitkiler.Fotosentez();
            tohumluBitkiler.TohumlaCogalır();


            Kuslar kuslar = new Kuslar();
            kuslar.Beslenme();
            kuslar.Ucmak();
            kuslar.Adaptosyon();


            Hayvanlar hayvanlar = new Hayvanlar();
            hayvanlar.Beslenme();
        }
    }
}