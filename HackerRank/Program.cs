using HackerRank.Algorithms.Warmup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    class Program
    {
        static void Main(string[] args)
        {
            RunTest(typeof(PlusMinus));
            Console.ReadKey();
        }

        static void RunTest(Type objType)
        {
            dynamic obj = Activator.CreateInstance(objType);
            obj.Start();
        }
    }
}
