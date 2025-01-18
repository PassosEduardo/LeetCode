// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


var result = FindThePrefixCommonArray.FindThePrefixCommonArrayMethod([1,3,2,4], [3,1,2,4]);

System.Console.WriteLine(string.Join(",",result));

result = FindThePrefixCommonArray.FindThePrefixCommonArrayMethod([2,3,1], [3,1,2]);

System.Console.WriteLine(string.Join(",",result));