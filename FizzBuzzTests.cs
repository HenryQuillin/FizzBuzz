using NUnit.Framework;
using FizzBuzz;

namespace FizzBuzzTests
{
    public class FizzBuzzTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void FizzBuzz_NumbersDivisibleBy3_ReturnsFizz()
        {
            fizzBuzz FizzBuzzObject = new fizzBuzz();
            string[] fizzBuzzArray = fizzBuzz.FizzBuzz();

            for (int i = 1; i < 101; i++)
            {
                if(i%3 == 0 && !(i%5==0))
                {
                    Assert.That(fizzBuzzArray[i-1] == "Fizz");
                }
            }
                
        }        
        [Test]
        public void FizzBuzz_NumbersDivisibleBy5_ReturnsBuzz()
        {
            fizzBuzz FizzBuzzObject = new fizzBuzz();
            string[] fizzBuzzArray = fizzBuzz.FizzBuzz();

            for (int i = 1; i < 101; i++)
            {
                if(i%5 == 0 && !(i%3==0))
                {
                    Assert.That(fizzBuzzArray[i-1] == "Buzz");
                }
            }
                
        }
        [Test]
        public void FizzBuzz_NumbersDivisibleBy5and3_ReturnsFizzBuzz()
        { 
            fizzBuzz FizzBuzzObject = new fizzBuzz();
            string[] fizzBuzzArray = fizzBuzz.FizzBuzz();

            for (int i = 1; i < 101; i++)
            {
                if (i % 5 == 0 && (i % 3 == 0))
                {
                    Assert.That(fizzBuzzArray[i - 1] == "FizzBuzz");
                }
            }

        }
        [Test]
        public void FizzBuzz_NumbersNotDivisibleBy5and3_ReturnsInt()
        {
            fizzBuzz FizzBuzzObject = new fizzBuzz();
            string[] fizzBuzzArray = fizzBuzz.FizzBuzz();

            for (int i = 1; i < 101; i++)
            {
                if (!(i % 5 == 0) && !(i % 3 == 0))
                {
                    string y = i.ToString();
                    Assert.That(fizzBuzzArray[i-1] == y);
                }
            }

        }
    }
}