using System;

namespace PropertiesApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();

            person.SetAge(68);

            int age = person.GetAge(); 
        }
    }
}
