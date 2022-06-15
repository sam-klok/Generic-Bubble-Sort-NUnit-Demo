using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericBubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {

            //var test = new List<int> { 1, 3, 98, 34, 2 };
            var arrayInt = new int[] { 1, 3, 98, 34, 2 };

            Print(arrayInt);
            Sorting.BubbleSort(arrayInt);
            Print(arrayInt);

            Console.WriteLine("Dogs: ");
            var dogs = new Dog[] { new Dog("big"), new Dog("small"), new Dog("medium"), };
            Print(dogs);
            var dogComparer = new DogComparer();
            Sorting.BubbleSort(dogs, dogComparer);
            Print(dogs);

            Console.WriteLine("Press any key..");
            Console.ReadKey();
        }

        static void Print<T>(T[] list)
        {
            foreach (var x in list)
                Console.Write($"{x} ");

            Console.WriteLine();
        }
    }
}
