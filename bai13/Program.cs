// Ten: Vo Van Thanh Dat
// MSV: 22204

using System;
using System.Collections.Generic;

class Student
{
    public int Id;
    public string Name;
}

class Bai13
{
    static void Main()
    {
        List<Student> list = new List<Student>()
        {
            new Student{Id=1, Name="An"},
            new Student{Id=2, Name="Binh"},
            new Student{Id=3, Name="Cuong"},
            new Student{Id=4, Name="dat"}
        };

        int count = list.Count;

        Console.WriteLine("So sinh vien: " + count);
    }
}