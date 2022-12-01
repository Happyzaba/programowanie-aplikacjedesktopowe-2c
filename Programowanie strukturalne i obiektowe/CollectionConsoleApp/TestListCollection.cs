using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CollectionConsoleApp
{
    class TestListCollection
    {
        public void FirstTest()
        {
            Random random = new Random();

            List<int> ListOfInts = new List<int>();
            for (int i = 0; i < 5; i++)
            {
                ListOfInts.Add(random.Next(1, 11));
            }
            Console.WriteLine("Lista int'ów:");
            foreach (int element in ListOfInts)
            {
                Console.Write(element + "\n");
            }
            Console.WriteLine();

            List<double> ListOfDoubles = new List<double>();
            for (int i = 0; i < 5; i++)
            {
                double number = random.NextDouble() * 10 + 1;
                number = Math.Round(number, 4);


                ListOfDoubles.Add(number);
            }
            Console.WriteLine("Lista double'ów:");
            foreach (double element in ListOfDoubles)
            {
                Console.Write(element + "\n");
            }

            Console.WriteLine();

            //int MaxInt = MaxFromInts(ListOfInts);
            int MaxInt = MaxFromAllTypes<int>(ListOfInts, CheckInt);
            Console.WriteLine("Max w liście int'ów to: " + MaxInt);

            //double MaxDouble = MaxFromDoubles(ListOfDoubles);
            double MaxDouble = MaxFromAllTypes<double>(ListOfDoubles, CheckDouble);
            Console.WriteLine("Max w liscie double'ów to: "+ MaxDouble);
        }

        private int MaxFromInts(List<int> list)
        {
            int max = list[0];
            foreach (int item in list)
	        {
            if(item > max)
                max = item;
	        }
            return max;
        } 

        private double MaxFromDoubles(List<double> list)
        {
            double max = list[0];
            foreach (int item in list)
            {
                if (item > max)
                    max = item;
            }
            return max;
        }

        private T MaxFromAllTypes<T>(List<T> list, Func<T,T,bool> check)
        {
            T max = list[0];
            foreach (T item in list)
            {
                /*if (item is int)
                {
                    if (CheckInt(int.Parse(item.ToString()), int.Parse(max.ToString())))
                        max = item;
                }

                if (item is double)
                {
                    if (CheckDouble(double.Parse(item.ToString()), double.Parse(max.ToString())))
                        max = item;
                }

                if (item is Person)
                {
                    if (CheckPerson(item as Person, max as Person)
                        max = item;
                }*/

                /*if (item > max)
                    max = item;*/

                if (check(item, max))
                    max = item;
            }
            return max;
        }

        private bool CheckInt(int FirstNumber, int SecondNumber)
        {
            return FirstNumber > SecondNumber;

        }

        private bool CheckDouble(double FirstNumber, double SecondNumber)
        {
            return FirstNumber > SecondNumber;

        }
        /*private Person CheckPerson(Perrson firstPerosn,Person secondPerson)
        {
            return firstPerson.age > secondPerson.age;
        }*/
    }
}
