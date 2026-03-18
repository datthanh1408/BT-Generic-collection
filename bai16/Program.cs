// Ten: Vo Van Thanh Dat
// MSV: 22204

using System;
using System.Collections.Generic;

class Bai16
{
    static void Main()
    {
        Console.Write("Nhap chuoi: ");
        string str = Console.ReadLine();

        Dictionary<char, int> dict = new Dictionary<char, int>();

        foreach (char c in str)
        {
            if (dict.ContainsKey(c))
                dict[c]++;
            else
                dict[c] = 1;
        }

        Console.WriteLine("So lan xuat hien:");
        foreach (var item in dict)
        {
            Console.WriteLine(item.Key + " : " + item.Value);
        }
    }
}