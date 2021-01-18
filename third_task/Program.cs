using System;
using System.Collections.Generic;

namespace third_task
{
    class Program
    {
        static Func<List<Func<int>>, int> ret = (lst) => {
        int aggregator = 0;
        foreach(var d in lst)
            aggregator += d();
        return (int)aggregator/lst.Count;
    };
    static Func<int> first = () => 2;
    static Func<int> second = () => 2;
    static Func<int> third = () => 2;
        static void Main(string[] args)
        {
            Console.WriteLine("Third task!");

            List<Func<int>> lst = new List<Func<int>>() { first, second, third };

            Console.WriteLine($"Got: {ret(lst)}");
        }
    }
}
