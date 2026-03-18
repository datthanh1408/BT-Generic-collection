// Ten: Vo Van Thanh Dat
// MSV: 22204

using System;
using System.Collections.Generic;
using System.Linq;

class Bai3
{
    static void Main()
    {
        List<int> list = new List<int>();

        for (int i = 0; i < 5; i++)
        {
            Console.Write("Nhap so: ");
            list.Add(int.Parse(Console.ReadLine()));
        }

        int max = list.Max();

        Console.WriteLine("So lon nhat: " + max);
    }
}