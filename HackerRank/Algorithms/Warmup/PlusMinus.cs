using System;
using System.Linq;

namespace HackerRank.Algorithms.Warmup
{
    public class PlusMinus
    {
        public void Start()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));

            plusMinus(arr);
        }

        public void plusMinus(int[] arr)
        {
            int total = arr.Count();
            var negativeCount = 0.0;
            var positiveCount = 0.0;
            var zeroCount = 0.0;

            for (int i = 0; i < total; i++)
            {
                if (arr[i] > 0)
                    positiveCount++;
                else if (arr[i] < 0)
                    negativeCount++;
                else
                    zeroCount++;
            }

            var positiveRatio = string.Format("{0:N6}", positiveCount / total);
            var negativeRatio = string.Format("{0:N6}", negativeCount / total);
            var zeroRatio = string.Format("{0:N6}", zeroCount / total);

            Console.WriteLine(positiveRatio);
            Console.WriteLine(negativeRatio);
            Console.WriteLine(zeroRatio);
        }
    }
}
