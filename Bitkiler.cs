using System;
namespace Inheritance
{
    public class Bitkiler : Canlilar
    {
        protected void FotosentezYapmak()
        {
            Console.WriteLine("Bitkiler fotosentez yaparlar.");
        }
    }

    public class TohumluBitkiler : Bitkiler
    {
        public TohumluBitkiler()
        {
            base.FotosentezYapmak();
        }
        public void TohumlaCogalma()
        {
            Console.WriteLine("Tohumlu bitkiler, tohumla cogalirlar.");
        }
    }

    public class TohumsuzBitkiler : Bitkiler
    {
        public TohumsuzBitkiler()
        {
            base.FotosentezYapmak();
            base.Beslenme();
        }
        public void SporlaCogalma()
        {
            Console.WriteLine("Tohumsuz bitkiler, sporla cogalirlar.");
        }
    }
}