using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems;
public class TwoSum : IProblem
{
    public void Execute()
    {
        var example1 = FindTwoSum([2, 7, 11, 15], 9);

        Console.WriteLine("example1 " + string.Join(",", example1));

        var example2 = FindTwoSum([3, 2, 4], 6);

        Console.WriteLine("example2 " + string.Join(",", example2));

        var example3 = FindTwoSum([3, 3], 6);

        Console.WriteLine("example2 " + string.Join(",", example3));
    }

    public int[] FindTwoSum(int[] nums, int target)
    {
        for (int fisrtNumberIndex = 0; fisrtNumberIndex < nums.Length; fisrtNumberIndex++)
        {
            for (int secondNumebrIndex = 1; secondNumebrIndex < nums.Length; secondNumebrIndex++)
            {
                if (nums[fisrtNumberIndex] + nums[secondNumebrIndex] == target)
                {
                    return [fisrtNumberIndex, secondNumebrIndex];
                }
            }            
        }

        Console.WriteLine("Not found");
        throw new Exception();
    }
}
