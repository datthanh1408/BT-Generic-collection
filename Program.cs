// Ten: Vo Van Thanh Dat
// MSV: 22204

using System;
using System.Collections.Generic;

class Bai5
{
    static void Main()
    {
        List<string> list = new List<string>() { "An", "Binh", "Cuong" };

        Console.Write("Nhap ten can xoa: ");
        string name = Console.ReadLine();

        list.Remove(name);

        Console.WriteLine("Danh sach sau khi xoa:");
        foreach (var x in list)
        {
            Console.WriteLine(x);
        }
    }
}