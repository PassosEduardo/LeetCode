using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems;
public static class TwoSum
{
    public static int[] FindTwoSum(int[] nums, int target)
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

        throw new Exception();
    }
}
