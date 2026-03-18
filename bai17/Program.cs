// Ten: Vo Van Thanh Dat
// MSV: 22204

using System;
using System.Collections.Generic;
using System.Linq;

class Bai17
{
    static void Main()
    {
        List<int> list = new List<int>() { 1, 2, 2, 3, 3, 3, 4 };

        var max = list
            .GroupBy(x => x)
            .OrderByDescending(g => g.Count())
            .First();

        Console.WriteLine("So xuat hien nhieu nhat: " + max.Key);
        Console.WriteLine("So lan: " + max.Count());
    }
}