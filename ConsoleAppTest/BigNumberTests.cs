// using Xunit;
//
// namespace ConsoleAppTest;
//
// public class BigNumberTests
// {
//     [Theory]
//     [InlineData(1001, 1002, 2003)]
//     [InlineData(1, 1000, 1001)]
//     [InlineData(1234567, 765432, 1999999)]
//     public void BigNumberTest1(int a, int b, int expected)
//     {
//         var number1 = new BigNumber(a);
//         var number2 = new BigNumber(b);
//         var result = number1 + number2;
//         
//         Assert.Equal(result.ToString(), new BigNumber(expected).ToString());
//     }
//
//     [Theory]
//     [InlineData(1001, 1002, 2003)]
//     [InlineData(50, 52, 102)]
//     [InlineData(9, 15, 24)]
//     public void Test2(int a, int b, int expected)
//     {
//         var list1 = new List<int>();
//         while (a > 0)
//         {
//             list1.Add(a % 10);
//             a = a / 10;
//         }
//         var list2 = new List<int>();
//         while (b > 0)
//         {
//             list2.Add(b % 10);
//             b = b / 10;
//         }
//         
//         var expectedList = new List<int>();
//         var expectedCopy = expected;
//         while (expectedCopy > 0)
//         {
//             expectedList.Add(expectedCopy % 10);
//             expectedCopy = expectedCopy / 10;
//         }
//         
//         var number1 = new BigNumber(list1);
//         var number2 = new BigNumber(list2);
//         var result = number1 + number2;
//         
//         Assert.Equal(result.ToString(), new BigNumber(expectedList).ToString());
//     }
// }