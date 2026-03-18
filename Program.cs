// Ten: Vo Van Thanh Dat
// MSV: 22204

using System;
using System.Collections.Generic;

class Bai7
{
    static void Main()
    {
        List<int> list = new List<int>();

        for (int i = 0; i < 5; i++)
        {
            Console.Write("Nhap so: ");
            list.Add(int.Parse(Console.ReadLine()));
        }

        list.Sort();

        Console.WriteLine("Danh sach tang dan:");
        foreach (var x in list)
        {
            Console.WriteLine(x);
        }
    }
}