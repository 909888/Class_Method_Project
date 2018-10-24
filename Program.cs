using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Class_Project
{
    class Program
    {
        static void Main(string[] args)
        {







            Console.WriteLine("Type a number");
            int num1 = Convert.ToInt32(Console.ReadLine());

            int result =Math.MathMult(num1);
            Console.WriteLine(result);

            Math mathObject = new Math();
            int result2 = mathObject.MathAdd(num1, num1);
            Console.WriteLine(result2);

            Math mathObject2 = new Math();
            int result3 = mathObject.MathSub(num1, num1, num1);
            Console.WriteLine(result2);

            Console.ReadLine();

        }

        
    }
}
