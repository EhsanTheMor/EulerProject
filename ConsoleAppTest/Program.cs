using System.Diagnostics;
using ConsoleAppTest;

var sw = Stopwatch.StartNew();

var exampleList1 = new List<int>() { 1, 2, 3, 4 };
var exampleList2 = new List<int>() { 81, 88, 75, 42, 87, 84, 86, 65 };
var subs = Subsets.CalsulateSubsets(exampleList2);

bool isSpecial = true;
for (int selectedSubset = 0; selectedSubset < subs.Count; selectedSubset++)
{
    var sub = subs[selectedSubset];
    if (sub.Count == 3)
    {
    Console.WriteLine(String.Join(", ", sub));
    }

    for (int restSub = 0; restSub < subs.Count; restSub++)
    {
        if (selectedSubset == restSub) continue;
        
        var sub2 = subs[restSub];
        
        if(!Subsets.AreDisjoint(sub2, sub)) continue;

        if (Subsets.SubsetSum(sub) == Subsets.SubsetSum(sub2))
        {
            isSpecial = false;
            break;
        } 
    }
}

Console.WriteLine("Found Solution in {0} and the result is -> isSpecial: {1};", sw.ElapsedMilliseconds, isSpecial.ToString());



