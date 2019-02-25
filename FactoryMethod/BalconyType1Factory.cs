using System;

namespace FactoryMethod
{
    class BalconyType1Factory : IBalconyFactory
    {
        public IBalcony CreateBalcony()
        {
            return new BalconyType1();
        }
    }
}
