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
    }

    public class NumberConverter
    {
        public string Replace(int replaceNumber)
        {
            if (replaceNumber % 3 == 0) return "Fizz";
            
            return replaceNumber.ToString();
        }
    }
}