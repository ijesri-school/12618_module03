using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod3_Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            //----------------Part One
            ////Sum(20, 40);
            //----------------Part Two
            int result = Sum(20, 40);
            Console.WriteLine($"The sum of 20 and 40 is: {result}");
            //----------------Part Three
            int result3 = Sum(10, 50, 80);
            Console.WriteLine($"Calling Sum() with three arguments, result is: {result3}");
            //----------------Part Four
            double dblResult = Sum(20.5, 30.6);
            Console.WriteLine($"Calling Sum() that takes doubles result in: {dblResult}");
        }

        //sum() method that takes two integer arguments and sums them
        //the method returns no value which is why we use void
        //we also need to use static in the method signature because Main is static
        //and you cannot call a non-static method from a static method
        //----------------Part One
        ////static void Sum(int first, int second)
        ////{
        ////    int sum = first + second;
        ////    Console.WriteLine($"The sum of {first} and {second} is: {sum}");
        ////}
        //----------------Part Two
        static int Sum(int first, int second)
        {
            int sum = first + second;
            return sum;
        }
        //----------------Part Three
        static int Sum(int first, int second, int third)
        {
            int sum = first + second + third;
            return sum;
        }
        //----------------Part Four
        static double Sum(double first, double second)
        {
            double result = first + second;
            return result;
        }
    }
}
