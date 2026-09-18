using System;
using System.Threading;
Console.WriteLine("Hello, World!");
int a = 5;
Console.WriteLine(a);
List<int> numbers = new List<int> {1, 2, 3, 4, 5};
foreach (int item in numbers)
{
    Console.WriteLine(item);
    Thread.Sleep(300);
}