// Ten: Vo Van Thanh Dat
// MSV: 22204

using System;
using System.Collections.Generic;
using System.Linq;

class Bai10
{
    static void Main()
    {
        List<int> list = new List<int>() { 5, 2, 8, 1, 3 };

        int min = list.Min();

        Console.WriteLine("Gia tri nho nhat: " + min);
    }
}