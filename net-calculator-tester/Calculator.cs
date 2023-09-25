using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace net_calculator_tester
{
    public static class Calculator
    {
        //Add
        public static float Add(float num1, float num2)
        {
            return num1 + num2;
        }
        //Subtract
        public static float Subtract(float num1, float num2)
        {
            return num1 - num2;
        }
        //Multiply
        public static float Multiply(float num1, float num2)
        {
            return num1 * num2;
        }
        //Division
        public static float Divide(float num1, float num2)
        {
            return num1 / num2;
        }
    }
}
