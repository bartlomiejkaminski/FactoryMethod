using System;

namespace FactoryMethod
{
    class BalconyType4Factory : IBalconyFactory
    {
        public IBalcony CreateBalcony()
        {
            return new BalconyType4();
        }
    }
}
