using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRecord
{
    partial class SinglyLinkedList
    {
        public void UpdateStudent(int id)
        {
            Node temp = head;
            while (temp != null)
            {
                if (temp.Data.ID == id)
                {
                    Console.Write("Enter new name: ");
                    temp.Data.Name = Console.ReadLine();
                    Console.Write("Enter new course: ");
                    temp.Data.Course = Console.ReadLine();

                    int year;
                    while (true)
                    {
                        Console.Write("Enter new year level: ");
                        if (int.TryParse(Console.ReadLine(), out year))
                            break;
                        Console.WriteLine("Enter valid Year Level!");
                    }
                    temp.Data.YearLevel = year;

                    float gpa;
                    while (true)
                    {
                        Console.Write("Enter new GPA: ");
                        if (float.TryParse(Console.ReadLine(), out gpa))
                            break;
                        Console.WriteLine("Enter valid GPA!");
                    }
                    temp.Data.GPA = gpa;

                    Console.WriteLine("Student updated successfully!\n");
                    return;
                }
                temp = temp.Next;
            }
            Console.WriteLine("Student not found.\n");
        }
    }
}
