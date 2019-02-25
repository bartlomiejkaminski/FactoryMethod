using System;

namespace FactoryMethod
{
    class BalconyType1 : IBalcony
    {
        public void GetName()
        {
            Console.WriteLine("Balcony 1");
        }
    }
}
