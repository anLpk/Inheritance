using System;
namespace Inheritance
{
    public class Hayvanlar : Canlilar
    {
        public void Adaptasyon()
        {
            Console.WriteLine("Hayvanlar adaptan kurabilir.");
        }
    }

    public class Surungenler : Hayvanlar
    {
        public void SurunerekHareketEderler()
        {
            Console.WriteLine("Surungenler surunurek hareket ederler.");
        }
    }

    public class Kuslar : Hayvanlar
    {
        public void Ucmak()
        {
            Console.WriteLine("Kuslar ucarlar.");
        }
    }
}
