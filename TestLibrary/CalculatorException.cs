using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLibrary
{
    public class CalculatorException: ApplicationException
    {
        public string CustomMessage { get; set; }

        public CalculatorException(string message)
        {
            CustomMessage = message;
        }
    }
}
