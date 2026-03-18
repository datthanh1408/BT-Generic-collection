// Ten: Vo Van Thanh Dat
// MSV: 22204

using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    public int Id;
    public string Name;
}

class Bai12
{
    static void Main()
    {
        List<Student> list = new List<Student>()
        {
            new Student{Id=1, Name="An"},
            new Student{Id=2, Name="Binh"},
            new Student{Id=3, Name="Cuong"}
        };

        Console.Write("Nhap ten can tim: ");
        string name = Console.ReadLine();

        var kq = list.Where(s => s.Name.Contains(name));

        Console.WriteLine("Ket qua:");
        foreach (var s in kq)
        {
            Console.WriteLine(s.Id + " - " + s.Name);
        }
    }
}