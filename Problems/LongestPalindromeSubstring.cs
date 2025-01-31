using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LeetCode.Problems;
public class LongestPalindromeSubstring : IProblem
{
    public void Execute()
    {
        var str = "babad";
        Console.WriteLine(Find(str));

        str = "cbbd";
        Console.WriteLine(Find(str));
    }

    private string Find(string str)
    {
        var possibilities = new List<string>();

        for (int start = 0; start < str.Length; start++)
        {
            for (int index = start + 1; index < str.Length; index++)
            {
                var subString = str.Substring(start, index - start);

                if (subString.Length < 2)
                    continue;

                var reordered = subString.Reverse();

                var reorderedStr = string.Join("", reordered);

                if(string.Equals(subString, reorderedStr))
                    possibilities.Add(subString);
            }
        }

        var max = possibilities.Max(x => x.Length);

        return possibilities.Where(p => p.Length == max).FirstOrDefault();
    }

    //Given a string s, return the longest
    //palindromic

    //substring
    // in s.



    //Example 1:

    //Input: s = "babad"
    //Output: "bab"
    //Explanation: "aba" is also a valid answer.
    //Example 2:

    //Input: s = "cbbd"
    //Output: "bb"
}
