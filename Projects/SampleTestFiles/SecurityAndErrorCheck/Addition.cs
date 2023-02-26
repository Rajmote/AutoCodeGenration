

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorConsoleApp
{
    public class Addition
    {
        public int Add(int Num1, int Num2) 
        {
            try
            {
                int a=10/0;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Error dividing by 0: {ex}");
            }
            return Num1 + Num2;
        }
    }
}