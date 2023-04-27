using System;
using SchoolApp.Database;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolApp.Database.Entities;
using Microsoft.EntityFrameworkCore;

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
                if (!int.TryParse(Console.ReadLine(), out int option))
                    continue;

                switch (option)
                {
                    case 1:
                        AddNewSchoolClasses();
                        break;
                    case 2:
                        DeleteSchoolClass();
                        break;
                    case 3:
                        ModifySchoolClass();
                        break;
                    case 4:
                        ShowAllSchoolClasses();
                        break;
                    case 5:
                        AddNewStudent();
                        break;
                    case 6:
                        DeleteSchoolClass();
                        break;
                    case 7:
                        ModifyStudent();
                        break;
                    case 8:
                        ShowAllStudents();
                        break;
                    case 9:
                        ShowStudentWithClass();
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
            
            Console.WriteLine("5. Dodanie nowego ucznia");
            Console.WriteLine("6. Usunięcie ucznia");
            Console.WriteLine("7. Modyfikacja ucznia");
            Console.WriteLine("8. Wyświetl wszystkich uczniow");
            Console.WriteLine("9. Wyświetlenie wszystkich uczniow z informacja o klasie ");
            Console.WriteLine("0. Koniec programu");
        }

        #region Metody do pracy na tabeli SchoolClasses

        private void AddNewSchoolClasses()
        {
            Console.WriteLine("Podaj nazwę klasy");
            string className = Console.ReadLine();

            SchoolClass schoolClass = new SchoolClass()
            {
                Name = className
            };
            schoolDatabase.SchoolClasses.Add(schoolClass);
            schoolDatabase.SaveChanges();

        }

        private void ShowAllSchoolClasses()
        {
            Console.WriteLine("Wszystkie klasy:");
            foreach (SchoolClass schoolClass in schoolDatabase.SchoolClasses)
            {
                Console.WriteLine(schoolClass.Id + " " + schoolClass.Name);
            }
            Console.ReadKey();
        }

        private void DeleteSchoolClass()
        {
            Console.WriteLine("Podaj id klasy do usunięcia");
            if(int.TryParse(Console.ReadLine(),out int idToDelete))
            {
                SchoolClass schoolClassToDeleted = schoolDatabase.SchoolClasses.FirstOrDefault(sc => sc.Id == idToDelete);
                if(schoolClassToDeleted != null)
                {
                    schoolDatabase.SchoolClasses.Remove(schoolClassToDeleted);
                    schoolDatabase.SaveChanges();
                    Console.WriteLine("Kasowanie zkonczone sukcesem");
                }
                else
                {
                    Console.WriteLine("Brak klasy w bazie");
                }
            }
            else
            {
                Console.WriteLine("Pajacu nie podales prawidlowej liczby sproboj jescze raz");
            }
            Console.ReadKey();
        }

        private void ModifySchoolClass()
        {
            Console.WriteLine("Podaj id klasy do modyfikacji");
            if (int.TryParse(Console.ReadLine(), out int idToModify))
            {
                SchoolClass schoolClassModify = schoolDatabase.SchoolClasses.FirstOrDefault(sc => sc.Id == idToModify);
                if (schoolClassModify != null)
                {
                    Console.WriteLine("Podaj nowa nazwe klasy");
                    string newName = Console.ReadLine();

                    schoolClassModify.Name = newName;
                    schoolDatabase.SaveChanges();
                    Console.WriteLine("Modyfikacja zakonczona sukcesem");
                }
                else
                {
                    Console.WriteLine("Brak klasy z takimn id w bazie");
                }
            }
            else
            {
                Console.WriteLine("Pajacu nie podales prawidlowej liczby sproboj jescze raz");
            }
            Console.ReadKey();
        }

        #endregion

        #region Metody do pracy na tabeli Students 
        
        private void AddNewStudent()
        {
            Console.WriteLine("Podaj imie:");
            string name = Console.ReadLine();
            Console.WriteLine("Podaj nazwisko");
            string surname = Console.ReadLine();
            Console.WriteLine("Podaj id klasy");
            int schoolClassId = int.Parse(Console.ReadLine());

            Student student = new Student()
            {
                Name = name,
                Surname = surname,
                SchoolClassId = schoolClassId,
            };
            schoolDatabase.Students.Add(student);
            schoolDatabase.SaveChanges();
            Console.WriteLine("Dodano studenta");
            Console.ReadKey();
        }

        private void ShowAllStudents()
        {
            Console.WriteLine("Lista uczniow");
            foreach (Student student in schoolDatabase.Students)
            {
                Console.WriteLine("Id: " + student.Id);
                Console.WriteLine("Imię: " + student.Name);
                Console.WriteLine("Nazwisko: " + student.Surname);
            }
            Console.ReadKey();
        }
          
        private void ShowStudentWithClass()
        {
            Console.WriteLine("Lista uczniow");
            foreach (Student student in schoolDatabase.Students.Include( s => s.SchoolClass))
            {
                Console.WriteLine("Id: " + student.Id);
                Console.WriteLine("Imię: " + student.Name);
                Console.WriteLine("Nazwisko: " + student.Surname);
                Console.WriteLine("Nazwa klasy: " + student.SchoolClass.Name);
            }
            Console.ReadKey();
        }

        private void DeleteStudent()
        {
            Console.WriteLine("Podaj id ucznia do usunięcia");
            int studentId = int.Parse(Console.ReadLine());

            Student studentToDelete = schoolDatabase.Students.FirstOrDefault(s => s.Id == studentId);

            if(studentToDelete != null)
            {
                schoolDatabase.Students.Remove(studentToDelete);
                schoolDatabase.SaveChanges();
            }
            else
            {
                Console.WriteLine("Brak ucznia w bazie");
            }
            Console.ReadKey();
        }

        private void ModifyStudent()
        {
            Console.WriteLine("Podaj id student do modyfikacji");
            int studentId = int.Parse(Console.ReadLine());

            Student studentToModify = schoolDatabase.Students.FirstOrDefault(s => s.Id == studentId);

            if (studentToModify != null)
            {
                Console.WriteLine("Podaj nowe imie:");
                studentToModify.Name = Console.ReadLine();
                Console.WriteLine("Podaj nowe nazwisko:");
                studentToModify.Surname = Console.ReadLine();

                schoolDatabase.SaveChanges();
            }
            else
            {
                Console.WriteLine("Brak ucznia w bazie");
            }
            Console.ReadKey();
        }

        #endregion
    }
}
