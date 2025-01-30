// See https://aka.ms/new-console-template for more information
using LeetCode.Problems;

Console.WriteLine("Hello, World!");


#region FindThePrefixCommonArrayMethod

//var result = FindThePrefixCommonArray.FindThePrefixCommonArrayMethod([1,3,2,4], [3,1,2,4]);

//    System.Console.WriteLine(string.Join(",",result));

//    result = FindThePrefixCommonArray.FindThePrefixCommonArrayMethod([2,3,1], [3,1,2]);

//    System.Console.WriteLine(string.Join(",",result));

#endregion

#region TwoSum

var example1 = TwoSum.FindTwoSum([2, 7, 11, 15], 9);

Console.WriteLine("example1 " + string.Join(",", example1));

var example2 = TwoSum.FindTwoSum([3, 2, 4], 6);

Console.WriteLine("example2 " + string.Join(",", example2));

var example3 = TwoSum.FindTwoSum([3, 3], 6);

Console.WriteLine("example2 "  + string.Join(",", example3));

#endregion