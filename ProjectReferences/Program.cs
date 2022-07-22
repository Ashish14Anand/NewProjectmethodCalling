using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Math;

namespace ProjectReferences
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int result;
            int Sub;
            int sum;
            double divide;

            Console.Write("Enter the value of a:- ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the value of b:- ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("****************************Result******************************");
            // When the method is non-static
            Calculation calculation = new Calculation();
            result = calculation.Mult(a, b);
            sum = calculation.Add(a, b);
            divide = calculation.Divide(a, b);

            Console.WriteLine("Sum:- {0}", sum);
            Console.WriteLine("Multiplication:- {0}", result);
            Console.WriteLine("Divide Value:- {0}", divide);

            // When the method is static
            Sub = Calculation.Subtract(a, b);

            Console.WriteLine("Subtraction Is:- {0}", Sub);



            Console.ReadLine();
        }
    }
}
