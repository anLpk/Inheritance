using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            TohumluBitkiler tohumluBitkiler = new TohumluBitkiler();

            tohumluBitkiler.Bosaltim();
            tohumluBitkiler.TohumlaCogalma();

            Kuslar marti = new Kuslar();
            marti.Ucmak();
        }
    }
}
