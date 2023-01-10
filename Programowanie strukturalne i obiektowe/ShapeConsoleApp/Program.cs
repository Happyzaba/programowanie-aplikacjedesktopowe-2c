using ShapeConsoleApp.Shapes;
using System;

namespace ShapeConsoleApp
{
    class Program
    {
        static void Main()
        {
            Rectangle firstRectangle = new Rectangle("Prostokąt 1");
            double area = firstRectangle.Area();                          

            Rectangle secondRectangle = new Rectangle("Prostokąt 2",54, 29);
            secondRectangle.ShowInfo();

            Square firstSquare = new Square("Kwadrat Marcin");
            firstSquare.ShowInfo();

        }
    }
}
