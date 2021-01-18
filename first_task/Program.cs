using System;

namespace first_task
{

    delegate int MyDelegate(int a, int b, int c);

    

    class Program
    {
        static void Main(string[] args)
        {            
            Console.WriteLine("Third lesson, first task!");

            MyDelegate del = delegate(int a, int b, int c) { return a+b+c; };

            Console.WriteLine(del(1,2,3));

            MyDelegate lambdaDel = delegate(int a, int b, int c) { return a+b+c; };

            Console.WriteLine(lambdaDel(1,2,3));
        }
    }
}
