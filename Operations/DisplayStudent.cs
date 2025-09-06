using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRecord
{
    partial class SinglyLinkedList
    {
        public void DisplayStudents()
        {
            if (head == null)
            {
                Console.WriteLine("No students in the list.\n");
                return;
            }

            Node temp = head;
            Console.WriteLine("\nStudent List");
            while (temp != null)
            {
                temp.Data.Display();
                temp = temp.Next;
            }
            Console.WriteLine();
        }
    }
}
