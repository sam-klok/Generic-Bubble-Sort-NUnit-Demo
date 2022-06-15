using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericBubbleSort
{
    public class Dog
    {
        public Dog(string size) 
        {
            Size = size;
        }

        public string Size { get; set; }

        public override string ToString() {
            return Size;
        }
    }

    public class DogComparer : IComparer<Dog>
    {
        public int Compare(Dog x, Dog y)
        {
            if (x.Size == "big")
                return 1;

            if (x.Size == "small")
                return -1;

            return 0;
        }
    }
}
