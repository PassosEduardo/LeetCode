namespace LeetCode.Problems;
public class LengthOfLongestSubstring : IProblem
{
    public void Execute()
    {
        var input = "abcabcbb";
        Console.WriteLine(ExecuteLengthOfLongestSubstring(input));

        input = "bbbbb";
        Console.WriteLine(ExecuteLengthOfLongestSubstring(input));

        input = "pwwkew";
        Console.WriteLine(ExecuteLengthOfLongestSubstring(input));
    }

    private int ExecuteLengthOfLongestSubstring(string s)
    {
        var final = new Dictionary<int, List<char>>();

        for (int i1 = 0; i1 < s.Length; i1++)
        {
            var listUnique = new List<char>();
            listUnique.Add(s[i1]);

            for (int i = i1+1; i < s.Length; i++)
            {
                if (!listUnique.Contains(s[i]))
                    listUnique.Add(s[i]);
                else
                    break;
            }
            
            if(!final.ContainsKey(listUnique.Count))
                final.Add(listUnique.Count, listUnique);
        }

        var key = final.Keys.Max();

        final.TryGetValue(key, out List<char> longest);

        Console.WriteLine(string.Join(",", longest));
        return longest.Count;    
    }
}
