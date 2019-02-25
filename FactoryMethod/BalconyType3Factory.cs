using System;

namespace FactoryMethod
{
    class BalconyType3Factory : IBalconyFactory
    {
        public IBalcony CreateBalcony()
        {
            return new BalconyType3();
        }
    }
}
