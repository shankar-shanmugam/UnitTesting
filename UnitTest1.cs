using NUnit.Framework;
using UnittestingDemo;
using System;

namespace TestProject1
{
    [TestFixture]
    public class NunitDemoTests
    {
        private NunitDemo demo;

        [SetUp]
        public void Setup()
        {
            demo = new NunitDemo();
        }

        [TestCase]
        public void Add_ShouldReturnSumOfTwoIntegers()
        {
            int result = demo.Add(4, 5);
            Assert.AreEqual(9, result);
        }

        [Test]
        public void Sub_ShouldReturnDifferenceOfTwoIntegers()
        {
            int result = demo.Sub(10, 5);
            Assert.AreEqual(5, result);
        }

        [Test]
        public void IsEven_ShouldReturnTrueForEvenNumber()
        {
            bool result = demo.IsEven(68);
            Assert.IsTrue(result);
        }

        [Test]
        public void Multiply_ShouldReturnProductOfTwoIntegers()
        {
            int result = demo.Multiply(3, 5);
            Assert.AreEqual(15, result);
        }

        [Test]
        public void Divide_ShouldReturnQuotientOfTwoIntegers()
        {
            int result = demo.Divide(10, 2);
            Assert.AreEqual(5, result);
        }


        [Test]
        public void Factorial_ShouldReturnFactorialOfNonNegativeInteger()
        {
            int result = demo.Factorial(5);
            Assert.AreEqual(120, result);
        }


        [Test]
        public void IsPalindrome_ShouldReturnTrueForPalindromeString()
        {
            bool result = demo.IsPalindrome("Madam");
            Assert.IsTrue(result);
        }

        [Test]
        public void IsPalindrome_ShouldReturnFalseForNonPalindromeString()
        {
            bool result = demo.IsPalindrome("Hello");
            Assert.IsFalse(result);
        }

        [Test]
        public void FindMax_ShouldReturnMaximumValueInArray()
        {
            int[] numbers = { 1, 3, 5, 7, 9 };
            int result = demo.FindMax(numbers);
            Assert.AreEqual(9, result);
        }

        [Test]
        public void Power_ShouldReturnCorrectPower()
        {
            double result = demo.Power(2, 3);
            Assert.AreEqual(8, result);
        }

        [Test]
        public void IsPrime_ShouldReturnTrueForPrimeNumber()
        {
            bool result = demo.IsPrime(7);
            Assert.IsTrue(result);
        }

        [Test]
        public void IsPrime_ShouldReturnFalseForNonPrimeNumber()
        {
            bool result = demo.IsPrime(4);
            Assert.IsFalse(result);
        }
    }
}
