using Generic.Math;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema10._2
{
    public class GenericCalculator
    {

        public T Add<T>(T num1, T num2)
        {
            return GenericMath<T>.Add(num1, num2);
        }

        public T Subtract<T>(T num1, T num2)
        {

            return GenericMath<T>.Subtract(num1, num2);
        }

        public T Multiply<T>(T num1, T num2)
        {
            return GenericMath<T>.Multiply(num1, num2);
        }

        public T Divide<T>(T num1, T num2)
        {
            if (num1.Equals(0) || num2.Equals(0))
            {
                throw new DivideByZeroException("You cannot divide by 0");
            }
            return GenericMath<T>.Divide(num1, num2);
        }        
    }
}
