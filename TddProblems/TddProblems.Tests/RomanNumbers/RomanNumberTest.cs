using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TddProblems.Implementations.RomanNumbers;

namespace TddProblems.Tests.RomanNumbers
{
    /*
    * List of goals:
    * 1 - Given that send a Simple number (I, V, X, L, C, D, M) 
    *     should be return literal number (1, 5, 10, 50, 100, 500, 1000)
    * 2 - Given that send a Simple Combined number (II, III, VI, VII, XX, XX, XXX) 
    *     should be return literal number (2, 3, 6, 7, 10, 20)
    * 3 - Given that send a Complex Combined of short number (IV, IX, XIX, XXIX, XXXIX) 
    *     should be return literal number (4, 9, 19, 29, 39, 49)
    * 4 - Given that send a Invalid number should return ArgumentException
    * 
    */
    [TestFixture(Category = "Simple Roman Number", Description = "Simple and Complex Conversions of roman number for literal numbers")]
    public class RomanNumberTest
    {
        [Test]
        public void Given_Roman_Number_I_When_Call_Conversion_ToInt_Should_Return_1()
        {
            // Arrange 

            // Act
            int actual = RomanNumber.ToInt("I");

            // Assert
            Assert.AreEqual(1, actual);
        }

        [Test]
        public void Given_Roman_Number_V_When_Call_Conversion_ToInt_Should_Return_5()
        {
            // Arrange 

            // Act
            int actual = RomanNumber.ToInt("V");

            // Assert
            Assert.AreEqual(5, actual);
        }

        [Test]
        public void Given_Roman_Number_X_When_Call_Conversion_ToInt_Should_Return_10()
        {
            // Arrange 

            // Act
            int actual = RomanNumber.ToInt("X");

            // Assert
            Assert.AreEqual(10, actual);
        }

        [Test]
        public void Given_Roman_Number_L_When_Call_Conversion_ToInt_Should_Return_50()
        {
            // Arrange 

            // Act
            int actual = RomanNumber.ToInt("L");

            // Assert
            Assert.AreEqual(50, actual);
        }

        [Test]
        public void Given_Roman_Number_C_When_Call_Conversion_ToInt_Should_Return_100()
        {
            // Arrange

            // Act
            int actual = RomanNumber.ToInt("C");

            // Assert
            Assert.AreEqual(100, actual);
        }

        [Test]
        public void Given_Roman_Number_D_When_Call_Conversion_ToInt_Should_Return_500()
        {
            // Arrrange

            // Act
            int actual = RomanNumber.ToInt("D");

            // Assert
            Assert.AreEqual(500, actual);
        }

        [Test]
        public void Given_Roman_Number_M_When_Call_Conversion_ToInt_Should_Return_1000()
        {
            // Arrange 

            // Act
            int actual = RomanNumber.ToInt("M");

            // Assert
            Assert.AreEqual(1000, actual);
        }


        [Test]
        public void Given_Roman_Number_II_When_Call_Conversion_ToInt_Should_Return_2()
        {
            // Arrange 

            // Act
            int actual = RomanNumber.ToInt("II");

            // Assert
            Assert.AreEqual(2, actual);
        }

        [Test]
        public void Given_Roman_Number_III_When_Call_Conversion_ToInt_Should_Return_3()
        {
            // Arrange 

            // Act
            int actual = RomanNumber.ToInt("III");

            // Assert
            Assert.AreEqual(3, actual);
        }

        [Test]
        public void Given_Roman_Number_VI_When_Call_Conversion_ToInt_Should_Return_6()
        {
            // Arrange 

            // Act
            int actual = RomanNumber.ToInt("VI");

            // Assert
            Assert.AreEqual(6, actual);
        }

        [Test]
        public void Given_Roman_Number_VII_When_Call_Conversion_ToInt_Should_Return_7()
        {
            // Arrange 

            // Act
            int actual = RomanNumber.ToInt("VII");

            // Assert
            Assert.AreEqual(7, actual);
        }

        [Test]
        public void Given_Roman_Number_IV_When_Call_Conversion_ToInt_Should_Return_4()
        {
            // Arrange 

            // Act
            int actual = RomanNumber.ToInt("IV");

            // Assert
            Assert.AreEqual(4, actual);
        }


        [Test]
        public void Given_Roman_Number_Null_When_Call_Conversion_ToInt_Should_Return_ArgumentException()
        {
            //Arrange 

            // Act

            // Assert
            Assert.Throws(Is.InstanceOf<ArgumentException>().And.Message
                .EqualTo("The parameter null isn't a valid Romain Number"), () => { RomanNumber.ToInt(null); });
        }
    }
}
