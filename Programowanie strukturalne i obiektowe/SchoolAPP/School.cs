using System;
using SchoolApp.Database;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAPP
{
    class School
    {
        private SchoolDatabase schoolDatabase = new SchoolDatabase(); 

        public void Run()
        {
            while (true)
            {
                ShowMenu();

                Console.WriteLine("Wybierz:");
                if(!int.TryParse(Console.ReadLine(), out int option))
                    continue;

                switch (option)
                {
                    case 1:
                        //uzupełnić metode
                        break;
                    case 2:
                        //uzupełnic metode
                        break;
                    case 3:
                        //uzepełnij
                        break;
                    case 4:
                        //uzupełnij 
                        break;
                    case 0:
                        return;

                }
            }
        }

        public void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("Lista dostępnych opcji");
            Console.WriteLine("1. Dodanie nowej klasy");//C-create
            Console.WriteLine("2. Usunięcie klasy");    //D-Delete
            Console.WriteLine("3. Modyfikacja klasy");//U-update
            Console.WriteLine("4. Wyświetlenie wszystkich klas");   //R-read

            Console.WriteLine("0. Koniec programu");
        }

    }
}
