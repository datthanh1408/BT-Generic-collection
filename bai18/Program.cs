// Ten: Vo Van Thanh Dat
// MSV: 22204

using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    public string Name;
    public double Score;
}

class Bai18
{
    static void Main()
    {
        List<Student> list = new List<Student>()
        {
            new Student{Name="An", Score=7.5},
            new Student{Name="Binh", Score=9.0},
            new Student{Name="Cuong", Score=8.2}
        };

        double maxScore = list.Max(s => s.Score);

        var top = list.Where(s => s.Score == maxScore);

        Console.WriteLine("Sinh vien diem cao nhat:");
        foreach (var s in top)
        {
            Console.WriteLine(s.Name + " - " + s.Score);
        }
    }
}