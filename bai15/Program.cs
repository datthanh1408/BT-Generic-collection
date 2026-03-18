// Ten: Vo Van Thanh Dat
// MSV: 22204

using System;
using System.Collections.Generic;

class Bai15
{
    static void Main()
    {
        Dictionary<string, string> dict = new Dictionary<string, string>()
        {
            {"hello", "xin chao"},
            {"book", "quyen sach"},
            {"cat", "con meo"}
        };

        Console.Write("Nhap tu tieng Anh: ");
        string key = Console.ReadLine().ToLower();

        if (dict.ContainsKey(key))
            Console.WriteLine("Nghia: " + dict[key]);
        else
            Console.WriteLine("Khong tim thay");
    }
}