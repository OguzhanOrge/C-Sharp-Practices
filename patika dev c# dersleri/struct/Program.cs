using System;
namespace struck
{
    class program
    {
        static void Main(string []args)
        {
            dikdörgen dikdörgen= new dikdörgen();
            dikdörgen.kısakenar=3;
            dikdörgen.uzunkenar=4;

            Console.WriteLine("Class alan hesaplama{0}",dikdörgen.alanhesaplama());

            dikdörtgen_struct dikdörtgen_Struct;
            dikdörtgen_Struct.kısakenar=4;
            dikdörtgen_Struct.uzunkenar=5;

            Console.WriteLine("struct alan hesabı{0}",dikdörtgen_Struct.alanhesaplama());
        }
    }
    class dikdörgen
    {
        public int uzunkenar;
        public int kısakenar;

        public int alanhesaplama()
        {
            return uzunkenar*kısakenar;
        }
    }
    struct dikdörtgen_struct
    {
        public int uzunkenar;
        public int kısakenar;

        public int alanhesaplama()
        {
            return uzunkenar*kısakenar;
        }
    }
}