global using LeetCode.Problems;
global using LeetCode.Configuration;
global using LeetCode;

namespace LeetCode.Configuration;
public static class ProblemFactory
{
    public static IProblem ProduceProblem(string problemName)
    {
        switch (problemName)
        {
            case nameof(FindThePrefixCommonArray):
                return new FindThePrefixCommonArray();

            case nameof(TwoSum):
                return new TwoSum();

            case nameof(AddTwoNumbers):
                return new AddTwoNumbers();

            default:
                return new ProblemNotFound(problemName);
        }
    }
}

public class ProblemNotFound : IProblem
{
    string ProblemName;
    public ProblemNotFound(string problemName)
    {
        ProblemName = problemName;
    }
    public void Execute()
    {
        Console.WriteLine($" {ProblemName} not found");
    }
}

