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
    }

    public class NumberConverter
    {
        private Dictionary<int, string> _replaceDictionary = new Dictionary<int, string>
        {
            { 3, "Fizz"},
            { 5, "Buzz"}
        };
        
        public string Replace(int replaceNumber)
        {
            if (replaceNumber % 3 == 0) return _replaceDictionary[3];
            if (replaceNumber % 5 == 0) return _replaceDictionary[5];
            
            return replaceNumber.ToString();
        }
    }
}