using NUnit.Framework;

namespace NUnitScaffold
{
    public class Problem2
    {
        [SetUp]
        public void SetUp()
        {}

        [Test]
        public void ItIsAlwaysTrue()
        {
            var currentNumber = 1;
            var lastNumber = 0;
            var evenSum = 0;
            for (int i = 1; i < 10; i = currentNumber + lastNumber)
            {
                lastNumber = currentNumber;
                currentNumber = i; 
                    if (currentNumber % 2 == 0)
                        {
                            evenSum = evenSum + currentNumber;
                        }

                System.Console.WriteLine(string.Format ("I {0} CN {1} LN {2} sum {3}", i ,currentNumber, lastNumber, evenSum));
                
            }
            Assert.That(evenSum ,Is.EqualTo(10));
        }
        [Test]
        public void fourMillionTest()
        {
            var currentNumber = 1;
            var lastNumber = 0;
            var evenSum = 0;
            for (int i = 1; i < 4000000; i = currentNumber + lastNumber)
            {
                lastNumber = currentNumber;
                currentNumber = i; 
                    if (currentNumber % 2 == 0)
                        {
                            evenSum = evenSum + currentNumber;
                        }

                //System.Console.WriteLine(string.Format ("I {0} CN {1} LN {2} sum {3}", i ,currentNumber, lastNumber, evenSum));
                
            }
            Assert.That(evenSum ,Is.EqualTo(10));
        }
    }
}
