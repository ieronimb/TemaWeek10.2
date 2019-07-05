using NUnit.Framework;
using StringExercitiul1.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace StringExercitiul1
{
    [TestFixture]
    class ReverseStringUniTest
    {  
        [Test]
        public void CheckTest1()
        {
            ReverseString str = new ReverseString();
            string input = "ab-cd";

            //Act
            string output = ReverseString.ReverseLettersOnly(input);

            //Asert
            Assert.AreEqual("dc-ba", output);
        }

        [Test]
        public void CheckTest2()
        {
            ReverseString str = new ReverseString();
            string input = "a-bC-dEf-ghIj";

            //Act
            string output = ReverseString.ReverseLettersOnly(input);

            //Asert
            Assert.AreEqual("j-Ih-gfE-dCba", output);
        }

        [Test]
        public void CheckTest3Null()
        {
            ReverseString str = new ReverseString();
            string input = null;

            //Act
            string output = ReverseString.ReverseLettersOnly(input);

            //Asert
            Assert.AreEqual(null, output);
            Assert.Throws<ArgumentNullException>(() => ReverseString.ReverseLettersOnly(output));
        }

        [Test]
        public void CheckTest4()
        {
            ReverseString str = new ReverseString();
            string input = "Test1ng-Leet=code-Q!";

            //Act
            string output = ReverseString.ReverseLettersOnly(input);

            //Asert
            Assert.AreEqual("Qedo1ct-eeLg=ntse-T!", output);
        }
    }
}
