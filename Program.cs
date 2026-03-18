// Ten: Vo Van Thanh Dat
// MSV: 22204

using System;
using System.Collections.Generic;
using System.Linq;

class Bai9
{
    static void Main()
    {
        List<int> list = new List<int>() { 1, 2, 2, 3, 3, 4 };

        List<int> kq = list.Distinct().ToList();

        Console.WriteLine("Danh sach khong trung:");
        foreach (var x in kq)
        {
            Console.WriteLine(x);
        }
    }
}