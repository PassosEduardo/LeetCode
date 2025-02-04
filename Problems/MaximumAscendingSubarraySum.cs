namespace LeetCode.Problems;
public class MaximumAscendingSubarraySum : IProblem
{
    public void Execute()
    {
        int[] array = [10, 20, 30, 5, 10, 50];

        Console.WriteLine(FindMaximun(array));

        array = [10, 20, 30, 40, 50];

        Console.WriteLine(FindMaximun(array));

        array = [12, 17, 15, 13, 10, 11, 12];

        Console.WriteLine(FindMaximun(array));

    }

    private int FindMaximun(int[] nums)
    {
        Console.WriteLine("Input: " + '[' + string.Join(',', nums) + ']');

        int maximum = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            int total = nums[i];

            for (int j = i+1; j < nums.Length; j++)
            {
                if (nums[j] > nums[j-1])
                {
                    total += nums[j];
                    continue;
                }
                else
                  break;
            }

            if(total > maximum)
                maximum = total;

        }

        return maximum;
    }
}
