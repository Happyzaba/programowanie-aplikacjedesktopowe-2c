using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Geometry_ConsoleApp
{
    public class Point
    {
        private int x, y;
        public int Y 
        {
            get
            {
                return y;
            }
            set
            {
                if (value > 0)
                    y = value;
                else
                    throw new ArgumentException("nie mozna ustawic wartosci ujemnych");
            }
        }
        public double DistanceFromCenter
        {
            get
            {
                return Math.Sqrt(x * x + y * y);
            }
        }
        public void DIsplay()
        {
            Console.WriteLine(x.ToString() + "," + y.ToString());

        }

        //w jezyku c++
        public void SetX(int a) {
            if (a > 0) {
                x = a; 
            }
            else
                throw new ArgumentException("Nie mozna ustwaic wartosi ujemnych");
        }
        public int GetX() {
            return x;
        }
       
    }
}
