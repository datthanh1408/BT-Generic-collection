// Ten: Vo Van Thanh Dat
// MSV: 22204

using System;
using System.Collections.Generic;

class Bai1
{
    static void Main()
    {
        List<int> list = new List<int>() { 1, 2, 3, 4, 5 };

        Console.WriteLine("Danh sach:");
        foreach (int x in list)
        {
            Console.WriteLine(x);
        }
    }
}