// Ten: Vo Van Thanh Dat
// MSV: 22204

using System;
using System.Collections.Generic;

class Student
{
    public int Id;
    public string Name;
}

class Bai14
{
    static void Main()
    {
        List<Student> list = new List<Student>()
        {
            new Student{Id=1, Name="An"},
            new Student{Id=2, Name="Binh"},
            new Student{Id=3, Name="Cuong"}
        };

        Console.Write("Nhap ID can xoa: ");
        int id = int.Parse(Console.ReadLine());

        list.RemoveAll(s => s.Id == id);

        Console.WriteLine("Danh sach sau khi xoa:");
        foreach (var s in list)
        {
            Console.WriteLine(s.Id + " - " + s.Name);
        }
    }
}