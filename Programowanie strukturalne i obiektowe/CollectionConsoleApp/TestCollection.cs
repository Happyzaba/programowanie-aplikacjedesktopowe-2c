using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CollectionConsoleApp
{

    class TestCollection
    {
        public void TestArrayCollection()
        {
            int[] arrayOfNumbers = new int[10];
            arrayOfNumbers[5] = 2137;

            Random random = new Random();
            for (int i = 0; i < arrayOfNumbers.Length; i++)
            {
                arrayOfNumbers[i] = random.Next() % 100;
            }
            Console.WriteLine("Liczby w tablicy:");

            foreach (int item in arrayOfNumbers)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine();

            int max = arrayOfNumbers[0];
            foreach (int number in arrayOfNumbers)
            {
                if (number > max)
                    max = number;
            }
            Console.WriteLine("Max w tablicy to :" + max);
        }

        public void TestObjectArrayCollection()
        {
            Number[] arrayWidthObjectNumbers = new Number[5];
            //arrayWidthObjectNumbers[2].ourNumber = 7;

            Random random = new Random();
            for (int i = 0; i < arrayWidthObjectNumbers.Length; i++)
            {
                arrayWidthObjectNumbers[i] = new Number();
                arrayWidthObjectNumbers[i].ourNumber = random.Next() % 100;
            }
            foreach (Number number in arrayWidthObjectNumbers)
            {
                Console.Write($"{number.ourNumber}, ");
            }
            int max = arrayWidthObjectNumbers[0].ourNumber;
            foreach (Number number in arrayWidthObjectNumbers)
            {
                if (number.ourNumber > max)
                    max = number.ourNumber;
            }
            Console.WriteLine("najwieszka liczba to: " + max);
        }

        public void TestGeneric()
        {
            NumberGeneric<int>[] intGenericNumbers = new NumberGeneric<int>[5];
            NumberGeneric<float>[] floatGenericNumbers = new NumberGeneric<float>[5];
            NumberGeneric<double>[] doubleGenericNumbers = new NumberGeneric<double>[5];
            NumberGeneric<byte>[] byteGenericNumbers = new NumberGeneric<byte>[5];

            byteGenericNumbers[2].ourNumber = 7;

        }
        
        public void ListCollection() 
        {
            int[] tab = new int[10];
            List<int> ListOfInts = new List<int>();
            Console.WriteLine("Kolecja ma elementów:" + ListOfInts.Count);
            ListOfInts.Add(5);
            Console.WriteLine("Kolekcja ma elementów:" + ListOfInts.Count);
            Console.WriteLine("Zerowy element kolekcji:" + ListOfInts[0]);
        }

    }

    class Number
    {
        public int ourNumber;
    }
    class NumberFloat 
    {
        public float ourNumber;
    }
    class NumberDouble 
    {
        public double ourNumber;
    }
    class NumberGeneric<T>
    {
        public T ourNumber;
    }
}
