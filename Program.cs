// Ten: Vo Van Thanh Dat
// MSV: 22204

using System;
using System.Collections.Generic;

class Bai6
{
    static void Main()
    {
        List<string> list = new List<string>() { "An", "Binh", "Cuong" };

        Console.Write("Nhap ten: ");
        string name = Console.ReadLine();

        if (list.Contains(name))
            Console.WriteLine("Ton tai");
        else
            Console.WriteLine("Khong ton tai");
    }
}