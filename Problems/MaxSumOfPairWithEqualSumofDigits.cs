using System;
using System.Security.Permissions;

namespace LeetCode.Problems;
public class MaxSumOfPairWithEqualSumofDigits : IProblem
{

    #region
//    You are given a 0-indexed array nums consisting of positive integers.You can choose two indices i and j, such that i != j, and the sum of digits of the number nums[i] is equal to that of nums[j].

//Return the maximum value of nums[i] + nums[j] that you can obtain over all possible indices i and j that satisfy the conditions.



//Example 1:

//Input: nums = [18, 43, 36, 13, 7]
//Output: 54
//Explanation: The pairs (i, j) that satisfy the conditions are:
//- (0, 2), both numbers have a sum of digits equal to 9, and their sum is 18 + 36 = 54.
//- (1, 4), both numbers have a sum of digits equal to 7, and their sum is 43 + 7 = 50.
//So the maximum sum that we can obtain is 54.
//Example 2:

//Input: nums = [10, 12, 19, 14]
//Output: -1
//Explanation: There are no two numbers that satisfy the conditions, so we return -1.
    #endregion
    public void Execute()
    {
        Console.WriteLine(GetMaxSumOfPairWithEqualSumofDigits([18, 43, 36, 13, 7]));

        Console.WriteLine(GetMaxSumOfPairWithEqualSumofDigits([10, 12, 19, 14]));
    }

    private int GetMaxSumOfPairWithEqualSumofDigits(int[] nums)
    {
        List<int> firstNumberPossible = new();
        List<int> secondNumberPossible = new();

        for (int i = 0; i < nums.Length - 1; i++)
        {
            int firstNumber = nums[i];

            for(int j = i+1; j < nums.Length; j++)
            {
                int secondNumber = nums[j];

                var firstCharArray = firstNumber.ToString().ToCharArray();

                var secondCharArray = secondNumber.ToString().ToCharArray();

                int firstSum = 0;

                int secondSum = 0;

                foreach (var item in firstCharArray)
                {
                    firstSum += int.Parse(item.ToString());
                }

                foreach (var item in secondCharArray)
                {
                    secondSum += int.Parse(item.ToString());
                }

                if(firstSum == secondSum)
                {
                   firstNumberPossible.Add(firstNumber);
                   secondNumberPossible.Add(secondNumber);
                }

            }
        }

        int maxValue = -1;

        for (int i = 0; i < firstNumberPossible.Count(); i++)
        {
            var sum = firstNumberPossible[i] + secondNumberPossible[i];

            if(sum > maxValue)
                maxValue = sum;
        }

        return maxValue;
    }
}
