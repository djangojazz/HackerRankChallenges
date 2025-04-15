using Challenges;

//Fibonacci.FibonacciAtindexRecursive(12);
//Larrys_Array.Run(null);
//InsertDataAtTail.Run();
//InsertDataAtHead.Run();
//SparseArrays.Run(new List<string> { "aba", "baba", "aba", "xzxb" }, new List<string> { "aba", "xzxb", "ab" });

int n = 5;
var queries = new List<List<int>>()
{
    new List<int>() { 1, 2, 100 },
    new List<int>() { 2, 5, 100 },
    new List<int>() { 3, 4, 100 },
    new List<int>() { 1, 1, 200 }
};
ArrayManipulation.Run(n, queries);