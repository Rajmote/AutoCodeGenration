

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorConsoleApp
{
    public class Substraction
    {
        public int Substract(int Num1, int Num2) 
        {
            if (Num1 > Num2) {
                return Num1 - Num2;
            } 
            return Num2 - Num1;
        }
    }
}