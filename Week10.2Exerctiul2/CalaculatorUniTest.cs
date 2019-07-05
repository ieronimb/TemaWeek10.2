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

        //Substract test 3 -> substract decimal number with double number
        [Test]
        public void SubstractDifNum()
        {
            GenericCalculator sumTest1 = new GenericCalculator();
            dynamic num1 = 10.0001;
            dynamic num2 = 6.89;

            //Act
            dynamic total = sumTest1.Subtract(num1, num2);

            //Assert
            Assert.AreEqual(3.1101, total);
        }

        //Substract test 4 -> substact 2 negative numbers
        [Test]
        public void Substract2Neg()
        {
            GenericCalculator sumTest1 = new GenericCalculator();
            dynamic num1 = -19;
            dynamic num2 = -6;

            //Act
            dynamic total = sumTest1.Subtract(num1, num2);

            //Assert
            Assert.AreEqual(-25, total);
        }

        //Multiply test 1 
        [Test]
        public void Multyply()
        {
            GenericCalculator sumTest1 = new GenericCalculator();
            dynamic num1 = 6;
            dynamic num2 = 5;

            //Act
            dynamic total = sumTest1.Multiply(num1, num2);

            //Assert
            Assert.AreEqual(30, total);
        }

        //Multiply test 2 -> float num and int number
        [Test]
        public void MultyplyFloatInt()
        {
            GenericCalculator sumTest1 = new GenericCalculator();
            dynamic num1 = 6.04f;
            dynamic num2 = 5;

            //Act
            dynamic total = sumTest1.Multiply(num1, num2);

            //Assert
            Assert.AreEqual(30.2, total);
        }


        //Multiply test 3 -> 0 and int number
        [Test]
        public void MultyplyZeroInt()
        {
            GenericCalculator sumTest1 = new GenericCalculator();
            dynamic num1 = 0;
            dynamic num2 = 5;

            //Act
            dynamic total = sumTest1.Multiply(num1, num2);

            //Assert
            Assert.AreEqual(0, total);
        }

        //Multiply test 3 -> neg numb and int number
        [Test]
        public void MultyplyNegPos()
        {
            GenericCalculator sumTest1 = new GenericCalculator();
            dynamic num1 = -5;
            dynamic num2 = 5;

            //Act
            dynamic total = sumTest1.Multiply(num1, num2);

            //Assert
            Assert.AreEqual(-25, total);
        }

        //Divide test 1 
        [Test]
        public void Divide()
        {
            GenericCalculator sumTest1 = new GenericCalculator();
            dynamic num1 = 30;
            dynamic num2 = 5;

            //Act
            dynamic total = sumTest1.Divide(num1, num2);

            //Assert
            Assert.AreEqual(6, total);
        }

        //Divide test 2 -> Int to 0
        [Test]
        public void DivideIntToZero()
        {
            GenericCalculator sumTest1 = new GenericCalculator();
            dynamic num1 = 30;
            dynamic num2 = 0;

            //Act
            dynamic total = sumTest1.Divide(num1, num2);

            //Assert            
            Assert.AreEqual(0, total);
            Assert.Throws<DivideByZeroException>(() => sumTest1.Divide(num1, num2));
        }

        //Divide test 3 -> 0 to int
        [Test]
        public void DivideZeroToInt()
        {
            GenericCalculator sumTest1 = new GenericCalculator();
            dynamic num1 = 0;
            dynamic num2 = 10;

            //Act
            dynamic total = sumTest1.Divide(num1, num2);

            //Assert            
            Assert.AreEqual(0, total);
            Assert.Throws<DivideByZeroException>(() => sumTest1.Divide(num1, num2));
        }

        //Divide test 3 -> 2 doubles
        [Test]
        public void DivideDoubles()
        {
            GenericCalculator sumTest1 = new GenericCalculator();
            dynamic num1 = 15.55;
            dynamic num2 = 3.33;

            //Act
            dynamic total = sumTest1.Divide(num1, num2);

            //Assert            
            Assert.AreEqual(4.66966966966967, total);            
        }
    }
}
