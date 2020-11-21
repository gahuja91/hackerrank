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
            int result = chiefHopper(arr);
            watch.Stop();

            Console.WriteLine($"Chief Hopper Execution Time: {watch.Elapsed}");
            Console.WriteLine(result);
        }

        public int chiefHopper(int[] arr)
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
    }
}
