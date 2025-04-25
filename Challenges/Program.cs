using Challenges.Heap;
using Challenges.Helpers;
using Challenges.LinkedListChallenges;
using Challenges.Stacks;

//Fibonacci.FibonacciAtindexRecursive(12);
//Larrys_Array.Run(null);
//InsertDataAtTail.Run();
//InsertDataAtHead.Run();
//SparseArrays.Run(new List<string> { "aba", "baba", "aba", "xzxb" }, new List<string> { "aba", "xzxb", "ab" });

//int n = 5;
//var queries = new List<List<int>>()
//{
//    new List<int>() { 1, 2, 100 },
//    new List<int>() { 2, 5, 100 },
//    new List<int>() { 3, 4, 100 },
//    new List<int>() { 1, 1, 200 }
//};
//ArrayManipulation.Run(n, queries);

//int t = 1;
//int n = 5;
//int[] m = new int[] { 1, 2, 2, 3, 4 };

//int t2 = 1;
//int n2 = 6;
//int[] m2 = new int[] { 3, 3, 3, 4, 5, 5 };
//LinkedListsRemovingDupes.Run(t2, n2, m2);

//var argsForPositionFromTail = new string[] { "2", "1", "1", "0", "3", "3", "2", "1", "2" };
//PositionFromTailLinkedList.Run(argsForPositionFromTail);

//var argsForEqualStacks1 = new List<int> { 1, 1, 1, 1, 2 };
//var argsForEqualStacks2 = new List<int> { 3, 7 };
//var argsForEqualStacks3 = new List<int> { 1, 3, 1 };
//var result = EqualStacks.Run(argsForEqualStacks1, argsForEqualStacks2, argsForEqualStacks3);
//Console.WriteLine(result);

//var intsForTree = new int[] { 1, 2, 5, 3, 6, 4 };
//var treeNode = CreateTreeStructureFromArrayOnly.CreateTree(intsForTree);
//Console.WriteLine(treeNode.Id);

var intsForCookies = new List<int> { 13, 47, 74, 12, 89, 74, 18, 38 };
var k = 90;
var result = CookiesSweet.Run(k, intsForCookies);
Console.WriteLine(result);

//5