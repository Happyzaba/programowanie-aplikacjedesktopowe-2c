using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ShapeConsoleApp.Shapes
{
    class Square : Rectangle
    {
        public Square(string name) : base(name,10, 10)
        {
        }

        public Square(string name, double sideA) :base(name, sideA, sideA)
        {
        }

        public override double Area()
        {
            return sideA * sideB;
        }
    }
}
