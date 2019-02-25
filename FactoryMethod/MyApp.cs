using System;

namespace FactoryMethod
{
    class MyApp
    {
        public MyApp()
        {
            IBalconyFactory balconyFactory1 = new BalconyType1Factory();

            IBalcony balcony1 = balconyFactory1.CreateBalcony();
            balcony1.GetName();


            IBalconyFactory balconyFactory3 = new BalconyType3Factory();

            IBalcony balcony3 = balconyFactory3.CreateBalcony();
            balcony3.GetName();
        }
    }
}
