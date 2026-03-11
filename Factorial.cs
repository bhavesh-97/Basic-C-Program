using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_C__Program
{
    public class Factorial
    {
        public int FactorialNumber = 1;
        public Factorial(int num)
        {
            
            for (int i = 1; i <= num; i++)
            {
                FactorialNumber *= i;
            }
        }
    } 
}
