global using LeetCode.Configuration;
global using LeetCode;

namespace LeetCode.Configuration;
public static class ProblemFactory
{
    public static IProblem ProduceProblem(string problemName)
    {
        var typeName = "LeetCode.Problems." + problemName;


        var type = Type.GetType(typeName);

        var obj = Activator.CreateInstance(type);

        
        return (IProblem) obj;
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

