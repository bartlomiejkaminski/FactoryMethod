using System;

namespace FactoryMethod
{
    class BalconyType2 : IBalcony
    {
        public void GetName()
        {
            Console.WriteLine("Balcony 2");
        }
    }
}
