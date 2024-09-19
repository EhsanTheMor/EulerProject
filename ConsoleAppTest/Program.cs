using System.Diagnostics;
using ConsoleAppTest;

var sw = Stopwatch.StartNew();

var exampleList1 = new List<int>() { 1, 2, 3, 4 };
var exampleList2 = new List<int>() { 81, 88, 75, 42, 87, 84, 86, 65 };
var subs = Subsets.CalsulateSubsets(exampleList2);

Console.WriteLine("Found Solution in {0};", sw.ElapsedMilliseconds);



