using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRecord
{
    partial class SinglyLinkedList
    {
        public void SearchStudent(int id)
        {
            Node temp = head;
            while (temp != null)
            {
                if (temp.Data.ID == id)
                {
                    Console.WriteLine("Student found:");
                    temp.Data.Display();
                    Console.WriteLine();
                    return;
                }
                temp = temp.Next;
            }
            Console.WriteLine("Student not found.\n");
        }
    }
}
