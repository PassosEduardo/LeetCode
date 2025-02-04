namespace LeetCode.Problems;
public class AddTwoNumbers : IProblem
{
    public void Execute()
    {
        ExecuteAddTwoNumbers([2, 4, 3], [5, 6, 4]);
        ExecuteAddTwoNumbers([0], [0]);
        ExecuteAddTwoNumbers([9, 9, 9, 9, 9, 9, 9], [9, 9, 9, 9]);
    }

    private void ExecuteAddTwoNumbers(int[] list1, int[] list2)
    {
        string firstNumberStr = "";

        for (int i1 = list1.Length -1; i1 >= 0; i1--)
        {
            firstNumberStr = string.Concat(firstNumberStr, list1[i1].ToString());
        }

        string secondNumberStr = "";

        for (int i2 = list2.Length - 1; i2 >= 0; i2--)
        {
            secondNumberStr = string.Concat(secondNumberStr, list2[i2].ToString());
        }

        int firstNumber = int.Parse(firstNumberStr);
        int secondNumber = int.Parse(secondNumberStr);

        var result = (firstNumber + secondNumber).ToString();

        var enumResult = new List<char>();

        for (int i = result.Length -1 ; i >= 0; i--)
        {
            enumResult.Add(result[i]);
        }

        Console.WriteLine("[" + string.Join(",", enumResult) + "]" );
    }


}
