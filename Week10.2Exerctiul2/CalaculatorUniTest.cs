using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Tema10._2
{
    [TestFixture]
    class CalculatorUniTest
    {
        //Add Test 1: add 2 positive numbers
        [Test]
        public void Add()
        {
            GenericCalculator sumTest1 = new GenericCalculator();
            dynamic num1 = 4;
            dynamic num2 = 6;

            //Act
            dynamic total = sumTest1.Add(num1, num2);

            //Assert
            Assert.AreEqual(10, total);
        }

        //Add test 2 -> add one negative number with a positive number 
        [Test]
        public void AddNegative()
        {
            GenericCalculator sumTest1 = new GenericCalculator();
            dynamic num1 = -5;
            dynamic num2 = 6;

            //Act
            dynamic total = sumTest1.Add(num1, num2);

            //Assert
            Assert.AreEqual(1, total);
        }

        //Add test 3 -> add a double with a float 
        [Test]
        public void Add2Types()
        {
            GenericCalculator sumTest1 = new GenericCalculator();
            dynamic num1 = 5.50;
            dynamic num2 = 6.66f;

            //Act
            dynamic total = sumTest1.Add(num1, num2);

            //Assert
            Assert.AreEqual(12.16, total);
        }

        //Add test 4 -> result to be negative
        [Test]
        public void AddResultNegative()
        {
            GenericCalculator sumTest1 = new GenericCalculator();
            dynamic num1 = -10;
            dynamic num2 = 9;

            //Act
            dynamic total = sumTest1.Add(num1, num2);

            //Assert
            Assert.AreEqual(-1, total);
        }

        //Substract test 1 -> substract 2 positive numbers
        [Test]
        public void Substract()
        {
            GenericCalculator sumTest1 = new GenericCalculator();
            dynamic num1 = 8;
            dynamic num2 = 6;

            //Act
            dynamic total = sumTest1.Subtract(num1, num2);

            //Assert
            Assert.AreEqual(2, total);
        }

        //Substract test 2 -> Result to be negative
        [Test]
        public void SubstractNegResult()
        {
            GenericCalculator sumTest1 = new GenericCalculator();
            dynamic num1 = 0;
            dynamic num2 = 6;

            //Act
            dynamic total = sumTest1.Subtract(num1, num2);

            //Assert
            Assert.AreEqual(-6, total);
        }

        //Substract test 3 -> Result to be negative
        [Test]
        public void SubstractNeg()
        {
            GenericCalculator sumTest1 = new GenericCalculator();
            dynamic num1 = 10.0001;
            dynamic num2 = 6.89;

            //Act
            dynamic total = sumTest1.Subtract(num1, num2);

            //Assert
            Assert.AreEqual(3.1101, total);
        }

    }
}
