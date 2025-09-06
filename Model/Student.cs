using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRecord
{
    class Student
    {
        public int ID;
        public string Name;
        public string Course;
        public int YearLevel;
        public float GPA;

        public Student(int id, string name, string course, int year, float gpa)
        {
            ID = id;
            Name = name;
            Course = course;
            YearLevel = year;
            GPA = gpa;
        }

        public void Display()
        {
            Console.WriteLine($"ID: {ID}, Name: {Name}, Course: {Course}, Year: {YearLevel}, GPA: {GPA}");
        }
    }
}

