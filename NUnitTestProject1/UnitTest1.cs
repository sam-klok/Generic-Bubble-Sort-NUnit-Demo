using NUnit.Framework;
using GenericBubbleSort;

namespace NUnitTestProject1
{
    public class Tests
    {
        //[SetUp]
        //public void Setup()
        //{
        //}

        [Test]
        public void TestIntegers()
        {
            var a = new int[] { 1, 7, 3, 9 };
            Sorting.BubbleSort(a);
            var dolgno = new int[] { 1,3,7,9 };
            Assert.AreEqual(dolgno, a);
        }

        [Test]
        public void TestDogs()
        {
            var dogs = new Dog[] { new Dog("big"), new Dog("small"), new Dog("medium"), };
            var dogComparer = new DogComparer();
            Sorting.BubbleSort(dogs, dogComparer);

            var dolgno = new Dog[] { new Dog("small"), new Dog("medium"), new Dog("big"), };

            Assert.AreEqual(dolgno[0].ToString(), dogs[0].ToString());
            Assert.AreEqual(dolgno[1].ToString(), dogs[1].ToString());
            Assert.AreEqual(dolgno[2].ToString(), dogs[2].ToString());
        }

    }
}