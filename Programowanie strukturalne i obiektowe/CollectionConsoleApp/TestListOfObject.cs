using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionConsoleApp
{
    class TestListOfObject
    {
        public void Test()
        {
            List<Person> ListOfPeople = new List<Person>();

            Person person = new Person("Jan", "Kowalski", 43);
            ListOfPeople.Add(person);

            ListOfPeople.Add(new Person("Ewa", "Nowak", 36));
            ListOfPeople.Add(new Person("Paweł", "Nieznanya", 10));
            ListOfPeople.Add(new Person("Bezi", "Mienny", 22));

            Console.WriteLine("Lista wszystkich osób:" + "\n");
            foreach (Person p in ListOfPeople)
            {
                p.Info();
                Console.WriteLine("----------------------------");
            }

            List<Person> listofPeaoplePegi18;

            listofPeaoplePegi18 = ListOfPeople.Where(x => x.age >= 18).ToList();
            Console.WriteLine("Lista osób pełnoletnich:" + "\n");
            foreach (Person p in listofPeaoplePegi18)
            {
                p.Info();
                Console.WriteLine("----------------------------");
            }

        }
    }
}
