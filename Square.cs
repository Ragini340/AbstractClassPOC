using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassPOC
{
    class Square : AreaClass
    {
        int side = 0;
        //Constructor
        public Square(int n)
        {
            side = n;
        }
        public override int Area()
        {
            return side * side;
        }
    }
}
