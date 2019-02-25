using System;

namespace FactoryMethod
{
    class BalconyType2Factory : IBalconyFactory
    {
        public IBalcony CreateBalcony()
        {
            return new BalconyType2();
        }
    }
}
