using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLibrary
{
    class PrivateCalculator
    {
        private int Multiplication(int a, int b)
        {
            var result = a * b;
            return result;
        }

        public void GetMultiplication(int a, int b)
        {
            Console.WriteLine(Multiplication(a,b));
        }
    }
}
