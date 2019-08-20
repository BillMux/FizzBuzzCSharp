using FizzBuzzCSharp;
using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            var fb = new FizzBuzz();
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}