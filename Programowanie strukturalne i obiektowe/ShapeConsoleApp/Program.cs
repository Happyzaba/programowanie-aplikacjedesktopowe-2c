using ShapeConsoleApp.Shapes;
using System;

namespace ShapeConsoleApp
{
    class Program
    {
        static void Main()
        {
            Rectangle firstRectangle = new Rectangle();
            firstRectangle.ShowInfo();

            Rectangle secondRectangle = new Rectangle(54, 29);
            secondRectangle.ShowInfo();
        }
    }
}
