using System;
using System.Collections.Generic;
using System.Text;

namespace caculator.calc
{
    class operation
    {
        public static int Add(int x, int y)
        {
            int Num1 = x;
            int Num2 = y;
            int Answer = Num1 + Num2;
            return Answer;
        }
        public static int Minus(int x, int y)
        {
            int Num1 = x;
            int Num2 = y;
            int Answer = Num1 - Num2;
            return Answer;
        }
        public static int Divide(int x, int y)
        {
            int Num1 = x;
            int Num2 = y;
            int Answer = Num1/Num2;
            return Answer;
        }
        public static int Times(int x, int y)
        {
            int Num1 = x;
            int Num2 = y;
            int Answer = Num1 * Num2;
            return Answer;
        }
    }
}
