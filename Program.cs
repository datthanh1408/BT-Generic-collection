// Ten: Vo Van Thanh Dat
// MSV: 22204

using System;
using System.Collections.Generic;

class Bai8
{
    static void Main()
    {
        List<int> list = new List<int>() { 1, 2, 3, 4, 5 };

        list.Reverse();

        Console.WriteLine("Danh sach sau khi dao nguoc:");
        foreach (var x in list)
        {
            Console.WriteLine(x);
        }
    }
}