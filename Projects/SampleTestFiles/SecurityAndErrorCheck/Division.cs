

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorConsoleApp
{
    public class Division
    {
        public int Divide(int Num1, int Num2)
        {
            if (Num2 != 0)
            {
                int result = Num1 / Num2;
                return result;
            }
            else
            {
                Console.WriteLine("Cannot divide by zero!");
                return 0;
            }
        }
    }
}