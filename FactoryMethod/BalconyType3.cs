using System;

namespace FactoryMethod
{
    class BalconyType3 : IBalcony
    {
        public void GetName()
        {
            Console.WriteLine("Balcony 3");
        }
    }
}
