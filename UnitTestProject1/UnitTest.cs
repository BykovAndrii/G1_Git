using NUnit.Framework;
using System;

namespace UnitTestProject
{
    public class UnitTest
    {
        public int result = 0;

        [OneTimeSetUp]
        public void BeforeAllTest()
        {
            System.Console.WriteLine("Before all tests");
        }

        [OneTimeTearDown]
        public void AfterAllTest()
        {
            System.Console.WriteLine("After all tests");
        }

        [SetUp]
        public void BeforeTest()
        {
            System.Console.WriteLine("Before test");
            this.result = 55;
        }

        [TearDown]
        public void AfterTest()
        {
            System.Console.WriteLine("After test");
        }

        [Test]
        public void AddTwoNumbers_PositiveData_ReturnCorrectResult()
        {
            System.Console.WriteLine("Test");

            // Arrange
            int firstNumber = 4;
            int secondNumber = 7;
            int expectedResult = 11;
            ClassForUnitTesting classForUnitTesting = new ClassForUnitTesting();

            // Act
            int result = classForUnitTesting.AddTwoNumbers(firstNumber, secondNumber);

            // Assert
            Assert.True(result == expectedResult,
                $"Sum of numbers { firstNumber} and { secondNumber} is " +
                result + $". Expected result is {expectedResult}");
        }

        [Test]
        public void Test1()
        {
            System.Console.WriteLine("Test 1");
            int a = 5;
            int b = 0;
            // TestDelegate testDelegate = new TestDelegate(Divide(a, b));

            Assert.Throws<DivideByZeroException>(() => Divide(a, b));
        }

        [Test]
        public void Test2()
        {
            System.Console.WriteLine("Test 2");
        }

        public void Divide(int a, int b)
        {
            var result = a / b;
        }
    }
}
