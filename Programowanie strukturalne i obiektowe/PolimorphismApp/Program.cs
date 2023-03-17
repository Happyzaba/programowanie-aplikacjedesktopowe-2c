using System;

namespace PolimorphismApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("Burek");
            Dog secondDog = new Dog("Maksiu");
            Cat cat = new Cat("Puszek");

            Animal animal = new Animal();   

            dog.Bark();
            cat.Meow();

            InfoAboutDog(dog);
            InfoAboutDog(secondDog);

            InfoAbout(dog);
            InfoAbout(cat);

            Point point = new Point(4, 9);

        }

        static void InfoAboutDog(Dog d)
        {
            d.ShowInfo();
        }

        static void InfoAbout(Animal a)
        {
            a.ShowInfo();
        }

    }
}
