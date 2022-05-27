
using System;
using System.Collections.Generic;
using System.Linq;

var nums = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

var evens = nums.Where(i => i % 2 == 0);

foreach (var n in evens) {
    Console.WriteLine(n);
}

Console.WriteLine("------------");

nums.Add(12);

foreach (var n in evens) {
    Console.WriteLine(n);
}

