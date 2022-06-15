using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericBubbleSort
{
    public static class Sorting
    {
        // https://stackoverflow.com/questions/3953359/how-to-create-a-generic-bubble-sorting-in-c-sharp

        public static void BubbleSort<T>(T[] list)
        {
            BubbleSort<T>(list, Comparer<T>.Default);
        }

        public static void BubbleSort<T>(T[] list, IComparer<T> comparer)
        {
            bool KeepIterating = true;
            while (KeepIterating)
            {
                KeepIterating = false;
                for (int i = 0; i < list.Length - 1; i++)
                {
                    T x = list[i];
                    T y = list[i + 1];
                    if (comparer.Compare(x, y) > 0)
                    {
                        list[i] = y;
                        list[i + 1] = x;
                        KeepIterating = true;

                        //for (int j = 0; j < list.Length; j++)
                        //{
                        //    Console.WriteLine("{0} {1}", j, list[j]);
                        //}
                    }
                }
            }
        }
    }
}
