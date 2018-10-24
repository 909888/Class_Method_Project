using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Class_Project
{
    public class Math
    {
        
        //method 1. 
        public static int MathMult(int mult1)
        {
            int multiply = mult1 * 10;
            //Console.WriteLine(multiply);
            return multiply;
            
        }

        //method 2.
        public int MathAdd(int mult1, int mult2)
        {
            int multiply = mult1 * mult2;
            //Console.WriteLine(multiply);
            return multiply;

        }

        //method 3.
        public int MathSub(int mult1, int mult2, int mult3)
        {
            int multiply = mult1 * mult2 - mult3;
            return multiply;

        }

    }
}
