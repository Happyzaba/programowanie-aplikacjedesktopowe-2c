using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CollectionConsoleApp
{
    class TestListOfObject
    {
        public void Test()
        {
            List<Person> listOfPeople = new List<Person>();

            Person person = new Person("Jan", "Kowalski", 13, 172);
            listOfPeople.Add(person);

            listOfPeople.Add(new Person("Ewa", "Nowak", 15, 112));
            listOfPeople.Add(new Person("Paweł", "Nieznanya", 15, 233));
            listOfPeople.Add(new Person("Bezi", "Mienny", 17, 195));

            Console.WriteLine("Lista wszystkich osób:" + "\n");
            foreach (Person p in listOfPeople)
            {
                p.Info();
                Console.WriteLine("-------------------------");
            }

            List<Person> listofPeaoplePegi18;

            listofPeaoplePegi18 = listOfPeople.Where(x => x.age >= 18).ToList();
            Console.WriteLine("Lista osób pełnoletnich:" + "\n");
            foreach (Person p in listofPeaoplePegi18)
            {
                p.Info();
                Console.WriteLine("-------------------------");
            }
            Console.WriteLine();
            List<Person> sortedListByAge = listOfPeople.OrderByDescending(x => x.age).
                ThenBy(x => x.height).ToList();
            Console.WriteLine("Lista osób według wieku malejąco:" + "\n");
            foreach (Person p in sortedListByAge)
            {
                p.Info();
                Console.WriteLine("-------------------------");
            }
            Console.WriteLine();

            List<Person> sortedListByName = listOfPeople.OrderBy(x => x.name).ToList();
            Console.WriteLine("List osób posortowana według imienia" + "\n"); 
            foreach (Person p in sortedListByName)
            {
                p.Info();
                Console.WriteLine("-------------------------");
            }        
            Console.WriteLine();
            
            int age = listOfPeople.Min(x => x.age);
            Console.WriteLine("Najmłodsza osoba ma wiek: " + age);

            bool isLegalAge = listOfPeople.All(x => x.age < 18);
            Console.WriteLine("Czy wszystkie osoby są pełnoletnie " + isLegalAge);
        
        }
    }
}
