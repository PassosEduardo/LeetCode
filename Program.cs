Console.WriteLine("Type the class name to execute:");

var problemName = Console.ReadLine();

IProblem problem = ProblemFactory.ProduceProblem(problemName);

Console.Clear();

problem.Execute();