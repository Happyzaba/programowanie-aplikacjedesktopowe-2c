using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorphismApp
{
    class Cat : Animal
    {
        private string name;

        public Cat(string ctName)
        {
            name = ctName;
        }
        public void Meow()
        {
            Console.WriteLine($"Kot o imieniu {name} miauczy.");
        }

        public override void ShowInfo()
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Obiekt klasy Cat.");
            Console.WriteLine($"Kot of imieniu {name}");
            Console.WriteLine("--------------------------------");

        }
    }

}
