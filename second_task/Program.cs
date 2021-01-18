using System;

namespace second_task
{
    class Program
    {
        static Func<int,int,int> add = (x,y) => x+y;
        static Func<int,int,int> mul = (x,y) => x*y;
        static Func<int,int,int> substitution = (x,y) => x-y;
        static Func<int,int,int> divide = (x,y) => {
            if (y == 0)
                throw new DivideByZeroException();
            return x/y;
        };

        static void Main(string[] args)
        {
            Console.WriteLine("second task!");

            Console.WriteLine($"1+2 = {add(1,2)}");
            Console.WriteLine($"2*2 = {mul(2,2)}");
            Console.WriteLine($"4/2 = {divide(4,2)}");
            Console.WriteLine($"5-3 = {substitution(5,3)}");

            try {
                divide(4,0);
            } catch(DivideByZeroException) {
                Console.WriteLine("Divide by zero!");
            }
            
        }
    }
}
