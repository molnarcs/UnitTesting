using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLibrary
{
    public class Calculator
    {
        public decimal CalculateTotalPrice(decimal price, decimal quantity)
        {
            decimal totalPrice = price * quantity;

            if (totalPrice < 0)
            {
                throw new CalculatorException("The total is less than zero!");
            }

            return totalPrice;
        }

        //[ExcludeFromCodeCoverage]
        public void GetTotalPrice()
        {
            int quantity = 10;
            int price = 42;

            var totalPrice = CalculateTotalPrice(price, quantity);
            Console.WriteLine("Total price: " + totalPrice);
        }
    }
}
