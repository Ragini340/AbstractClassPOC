using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassPOC
{
    public class DriverClass
    {
        public static void Main()
        {
            //Here obj is object of class AbstractPOC. Class AbstractPOC cannot be instantiated
            AbstractPOC obj;

            // Instantiating class ChildClass1OfAbstractPOC
            obj = new ChildClass1OfAbstractPOC();

            //Calling test method of class ChildClass1OfAbstractPOC
            obj.test();

            // Instantiating class ChildClass2OfAbstractPOC
            obj = new ChildClass2OfAbstractPOC();

            //Calling test() of class ChildClass2OfAbstractPOC
            obj.test();

        }
    }
}
