using System.Diagnostics;
using System.Threading.Tasks.Dataflow;

// var a = new BigNumber([1,2,3,4,5,6,7,9,8,2]);
// var isEnd = a.IsEndingPandigital();
// var isStart = a.IsStartingPandigital();
// Console.WriteLine(isEnd);


// var a = new BigNumber([8,7,8,6,5,4]);
// var b = new BigNumber([9,9,9,9]);
//
// a.AddToContainer(b.Container);

var a = new BigNumber([1]);
var b = new BigNumber([1]);
var c = new BigNumber([0]);

Span<int> arr1 = stackalloc int[100_000];
Span<int> arr2 = stackalloc int[100_000];
var isArr1UsedLast = false;

var index = 2;
var sw = Stopwatch.StartNew();
var aSw = Stopwatch.StartNew();
var bSw = Stopwatch.StartNew();
var cSw = Stopwatch.StartNew();

while (true)
{
    if (b.IsStartingPandigital())
    {
        break;
    }

    var dest = isArr1UsedLast ? arr2 : arr1;
    isArr1UsedLast = !isArr1UsedLast;

    // aSw.Start();
    b.Container.CopyTo(dest);
    // b.Container.CopyTo(c.Container);
    // aSw.Stop();

    // bSw.Start();
    b.AddToContainer(a.Container);
    // bSw.Stop();

    // cSw.Start();
    a.Container = dest;
    // cSw.Stop();

    index++;
    // if (index % 1000 == 0)
    // {
    //     Console.WriteLine(index);
    // }
}

Console.WriteLine("Executed {0} in {1}; a: {2} b: {3}, c: {4}", index, sw.ElapsedMilliseconds, aSw.ElapsedMilliseconds,
    bSw.ElapsedMilliseconds, cSw.ElapsedMilliseconds);
Console.WriteLine(b.Container.ToArray());