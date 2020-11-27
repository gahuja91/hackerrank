using HackerRank.Utility;
using System;
using System.Linq;

//REFERENCE: https://www.hackerrank.com/challenges/chief-hopper/problem?h_r=next-challenge&h_v=zen
namespace HackerRank.Algorithms.Greedy
{
    public class ChiefHopper
    {
        public void Start()
        {
            //int n = Convert.ToInt32(Console.ReadLine());
            //int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            int[] arr = FileReader.ReadNumbersFile("../../Data/ChiefHopper.txt").ToArray();

            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();
            int result = ChiefHopperOptimized(arr);
            watch.Stop();

            Console.WriteLine($"Chief Hopper Execution Time: {watch.Elapsed}");
            Console.WriteLine(result);
        }

        private int NonOptimizedChiefHopper(int[] arr)
        {
            var minEnergy = 0;

            if (arr[0] % 2 == 0)
                minEnergy = arr[0] / 2;
            else
                minEnergy = arr[0] / 2 + 1;

            Search:
                int energy = minEnergy;

                for (int i = 0; i < arr.Length; i++)
                {
                    energy = (2 * energy) - arr[i];
                    if (energy < 0)
                    {
                        minEnergy++;
                        goto Search;
                    }
                }

            return minEnergy;
        }

        private int ChiefHopperOptimized(int[] arr)
        {
            int maxHeight = arr.Max();

            int lowestEnergy = 0;
            int maxEnergy = maxHeight;

            while(lowestEnergy != maxEnergy)
            {
                int mid = (lowestEnergy + maxEnergy) / 2;
                bool canReach = CanCompleteCourse(arr, mid, maxHeight);

                if (canReach)
                    maxEnergy = mid;
                else
                    lowestEnergy = mid + 1;
            }

            return maxEnergy;
        }

        private bool CanCompleteCourse(int[] arr, int energy, int maxHeight)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                energy = (2 * energy) - arr[i];

                if (energy < 0)
                    return false;

                if (energy > maxHeight)
                    return true;
            }

            return true;
        }
    }
}
