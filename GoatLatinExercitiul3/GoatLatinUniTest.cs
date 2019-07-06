using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoatLatinExercitiul3
{
    [TestFixture]
    class GoatLatinUniTest
    {
       [Test]
       public void GoatLatinTest1()
        {
            SpecialString  str = new SpecialString();
            string input = "I speak Goat Latin";
           
            //Act
            string output = SpecialString.GoatLatin(input);

            //Asert
            Assert.AreEqual("Imaa peaksmaaa oatGmaaaa atinLmaaaaa", output);
        }

        [Test]
        public void GoatLatinTest2()
        {
            SpecialString str = new SpecialString();
            string input = "I speak Goat Latin";


            //Act
            string output = SpecialString.GoatLatin(input);

            //Asert
            Assert.AreEqual("Imaa peaksmaaa oatGmaaaa atinLmaaaaa", output);
        }
    }
}
