using System;
namespace Inheritance
{
    public class Canlilar
    {
        protected void Beslenme()
        {
            Console.WriteLine("Canlilar beslenirler.");
        }

        protected void Solunum()
        {
            Console.WriteLine("Canlilar solunum yaparlar.");
        }

        public void Bosaltim()
        {
            Console.WriteLine("Canlilar bosaltim yaparlar.");
        }

        public virtual void UyaranlaraTepki()
        {
            Console.WriteLine("Canlilar uyaranlara tepki verir.");
        }
    }
}