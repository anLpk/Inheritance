using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            TohumluBitkiler tohumluBitkiler = new TohumluBitkiler();
            tohumluBitkiler.Beslenme();
            tohumluBitkiler.Solunum();
            tohumluBitkiler.Bosaltim();
            tohumluBitkiler.TohumlaCogalma();

            Kuslar marti = new Kuslar();
            marti.Solunum();
            marti.Beslenme();
            marti.Bosaltim();
            marti.Adaptasyon();
            marti.Ucmak();
        }
    }
}
