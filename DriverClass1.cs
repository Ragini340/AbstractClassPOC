using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassPOC
{
    class DriverClass1
    {
        public static void Main()
        {
            Square obj = new Square(6);
            Console.WriteLine("Area  = " + obj.Area());
        }
    }
}