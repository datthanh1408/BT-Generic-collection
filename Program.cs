// Ten: Vo Van Thanh Dat
// MSV: 22204

using System;
using System.Collections.Generic;

class Bai4
{
    static void Main()
    {
        List<int> list = new List<int>() { 1, 2, 4, 7, 8,10 };

        int dem = 0;

        foreach (int x in list)
        {
            if (x % 2 == 0)
                dem++;
        }

        Console.WriteLine("So chan: " + dem);
    }
}