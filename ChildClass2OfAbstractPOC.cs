using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassPOC
{
    public class ChildClass2OfAbstractPOC : AbstractPOC
    {
        public override void test()
        {
            Console.WriteLine("I am in ChildClass2OfAbstractPOC");
        }
    }
}
