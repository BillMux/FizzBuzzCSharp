using FizzBuzzCSharp;
using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        [Test]
        public void TestReturnNumber()
        {
            FizzBuzz fizzbuzz = new FizzBuzz();
            Assert.AreEqual(fizzbuzz.Play(1), "1");
        }

        [Test]
        public void TestReturnFizz()
        {
            FizzBuzz fizzbuzz = new FizzBuzz();
            Assert.AreEqual(fizzbuzz.Play(3), "Fizz");
            Assert.AreEqual(fizzbuzz.Play(6), "Fizz");
        }

        [Test]
        public void TestReturnBuzz()
        {
            FizzBuzz fizzbuzz = new FizzBuzz();
            Assert.AreEqual(fizzbuzz.Play(5), "Buzz");
        }
    }
}