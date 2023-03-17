using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorphismApp
{
    class Animal
    {
        public  virtual void ShowInfo()
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Obiekt klasy Animal.");
            Console.WriteLine("--------------------------------");

        }
    }
}
