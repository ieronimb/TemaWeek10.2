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
        public void CheckTest1()
        {
            ReverseString str = new ReverseString();
            string input = "ab-cd";

            //Act
            string output = ReverseString.ReverseLettersOnly(input);

            //Asert
            Assert.AreEqual("dc-ba", output);
        }        
        public void CheckTest2()
        {
            ReverseString str = new ReverseString();
            string input = "a-bC-dEf-ghIj";

            //Act
            string output = ReverseString.ReverseLettersOnly(input);

            //Asert
            Assert.AreEqual("j-Ih-gfE-dCba", output);
        }

        public void CheckTest3Null()
        {
            ReverseString str = new ReverseString();
            string input = "";

            //Act
            string output = ReverseString.ReverseLettersOnly(input);

            //Asert
            Assert.Throws<ArgumentNullException>(() => ReverseString.ReverseLettersOnly(output));
        }

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
