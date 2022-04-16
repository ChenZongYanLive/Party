using System.Collections.Generic;
using NUnit.Framework;

namespace UnitTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Input_1_return_1()
        {
            //Arrange
            var converter = new NumberConverter();

            //Act
            const int replaceNumber = 1;
            var actual = converter.Replace(replaceNumber);

            //Assert
            const string expected = "1";
            Assert.AreEqual(expected, actual);
        }
        
        [Test]
        public void Input_2_return_2()
        {
            //Arrange
            var converter = new NumberConverter();

            //Act
            const int replaceNumber = 2;
            var actual = converter.Replace(replaceNumber);

            //Assert
            const string expected = "2";
            Assert.AreEqual(expected, actual);
        }
        
        [Test]
        public void Input_3_return_Fizz()
        {
            //Arrange
            var converter = new NumberConverter();

            //Act
            const int replaceNumber = 3;
            var actual = converter.Replace(replaceNumber);

            //Assert
            const string expected = "Fizz";
            Assert.AreEqual(expected, actual);
        }
        
        [Test]
        public void Input_6_return_Fizz()
        {
            //Arrange
            var converter = new NumberConverter();

            //Act
            const int replaceNumber = 6;
            var actual = converter.Replace(replaceNumber);

            //Assert
            const string expected = "Fizz";
            Assert.AreEqual(expected, actual);
        }
        
        [Test]
        public void Input_5_return_Buzz()
        {
            //Arrange
            var converter = new NumberConverter();

            //Act
            const int replaceNumber = 5;
            var actual = converter.Replace(replaceNumber);

            //Assert
            const string expected = "Buzz";
            Assert.AreEqual(expected, actual);
        }
        
        [Test]
        public void Input_10_return_Buzz()
        {
            //Arrange
            var converter = new NumberConverter();

            //Act
            const int replaceNumber = 10;
            var actual = converter.Replace(replaceNumber);

            //Assert
            const string expected = "Buzz";
            Assert.AreEqual(expected, actual);
        }
        
        [Test]
        public void Input_15_return_FizzBuzz()
        {
            //Arrange
            var converter = new NumberConverter();

            //Act
            const int replaceNumber = 15;
            var actual = converter.Replace(replaceNumber);

            //Assert
            const string expected = "FizzBuzz";
            Assert.AreEqual(expected, actual);
        }
        
        [Test]
        public void Input_30_return_FizzBuzz()
        {
            //Arrange
            var converter = new NumberConverter();

            //Act
            const int replaceNumber = 30;
            var actual = converter.Replace(replaceNumber);

            //Assert
            const string expected = "FizzBuzz";
            Assert.AreEqual(expected, actual);
        }
        
        [Test]
        public void Input_13_return_Fizz()
        {
            //Arrange
            var converter = new NumberConverter();

            //Act
            const int replaceNumber = 13;
            var actual = converter.Replace(replaceNumber);

            //Assert
            const string expected = "Fizz";
            Assert.AreEqual(expected, actual);
        }
        
        [Test]
        public void Input_27_return_Fizz()
        {
            //Arrange
            var converter = new NumberConverter();

            //Act
            const int replaceNumber = 27;
            var actual = converter.Replace(replaceNumber);

            //Assert
            const string expected = "Fizz";
            Assert.AreEqual(expected, actual);
        }
        
        [Test]
        public void Input_52_return_Buzz()
        {
            //Arrange
            var converter = new NumberConverter();

            //Act
            const int replaceNumber = 52;
            var actual = converter.Replace(replaceNumber);

            //Assert
            const string expected = "Buzz";
            Assert.AreEqual(expected, actual);
        }
        
        [Test]
        public void Input_20_return_Buzz()
        {
            //Arrange
            var converter = new NumberConverter();

            //Act
            const int replaceNumber = 20;
            var actual = converter.Replace(replaceNumber);

            //Assert
            const string expected = "Buzz";
            Assert.AreEqual(expected, actual);
        }
        
        [Test]
        public void Input_35_return_FizzBuzz()
        {
            //Arrange
            var converter = new NumberConverter();

            //Act
            const int replaceNumber = 35;
            var actual = converter.Replace(replaceNumber);

            //Assert
            const string expected = "FizzBuzz";
            Assert.AreEqual(expected, actual);
        }
        
        [Test]
        public void Input_7_return_Whizz()
        {
            //Arrange
            var converter = new NumberConverter();

            //Act
            const int replaceNumber = 7;
            var actual = converter.Replace(replaceNumber);

            //Assert
            const string expected = "Whizz";
            Assert.AreEqual(expected, actual);
        }
        
        [Test]
        public void Input_53_return_FizzBuzz()
        {
            //Arrange
            var converter = new NumberConverter();

            //Act
            const int replaceNumber = 53;
            var actual = converter.Replace(replaceNumber);

            //Assert
            const string expected = "FizzBuzz";
            Assert.AreEqual(expected, actual);
        }
    }

    public class NumberConverter
    {
        private Dictionary<int, string> _replaceDictionary = new Dictionary<int, string>
        {
            { 3, "Fizz"},
            { 5, "Buzz"},
            { 7, "Whizz"}
        };
        
        public string Replace(int replaceNumber)
        {
            var result = "";

            foreach (var divisorNumber in new int[]{ 3, 5, 7 })
            {
                if (IsDivide(replaceNumber, divisorNumber) || HasNumber(replaceNumber, divisorNumber))
                {
                    result +=  _replaceDictionary[divisorNumber];
                }
            }

            return string.IsNullOrEmpty(result) ? replaceNumber.ToString() : result;
        }

        private static bool HasNumber(int replaceNumber, int divisorNumber)
        {
            return replaceNumber.ToString().Contains(divisorNumber.ToString());
        }

        private static bool IsDivide(int replaceNumber, int divisorNumber)
        {
            return replaceNumber % divisorNumber == 0;
        }
    }
}