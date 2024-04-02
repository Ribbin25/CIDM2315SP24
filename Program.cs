﻿using System;

using System.Collections.Generic;

namespace Homework9;
public class Student
{
    private int studentID;
    private string studentName;
    public static List<Student> studentList = new List<Student>();
    public Student(int id,string name)
    {
        this.studentID = id;
        this.studentName = name;
        studentList.Add(this);
    }
    public void PrintInfo()
    {
        Console.WriteLine($"Student ID: {studentID}, Name: {studentName}");
    } 
    public string getname(){
        return this.studentName;
    }
    
}
class Program
{
    static void Main(string[] args)
    {
        Student s1 = new Student(111, "Alice");
        Student s2 = new Student(222, "Bob");
        Student s3 = new Student(333, "Cathy");
        Student s4 = new Student(444, "David");

        Dictionary<string, double> gradebook = new Dictionary<string, double>()
        {
            {"Alice", 4.0},
            {"Bob", 3.6},
            {"Cathy", 2.5},
            {"David", 1.8},
        };
        
        if(!gradebook.ContainsKey("Tom"))
        {
            gradebook.Add("Tom", 3.3);
        }
        Student s5 = new Student(555, "Tom");

        double totalGPA = 0.0;
      

        foreach (var student in Student.studentList)
        {
            // Console.WriteLine(student.getname());
            // Console.WriteLine("studentname = "+student.studentName );
            if(gradebook.ContainsKey(student.getname()))
            {
                totalGPA += gradebook[student.getname()];
            }

        }
        Console.WriteLine("_______________________________________");
        double averageGPA = totalGPA / Student.studentList.Count;
        Console.WriteLine($"Average GPA: {averageGPA}");

        Console.WriteLine("Students with GPA greater than average GPA: ");
        foreach (var student in Student.studentList)
        {
            // if(gradebook.ContainsKey(student.studentName) && gradebook[student.studentName] > averageGPA);
            if(gradebook.ContainsKey(student.getname()) && gradebook[student.getname()] > averageGPA)
            {
                student.PrintInfo();
            }
        } 
    }
}
////including Tom on the Students with GPA greater than average GPA since his is 3.3