using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRecord
{
    partial class SinglyLinkedList
    {
        public void DeleteStudent(int id)
        {
            if (head == null)
            {
                Console.WriteLine("List is empty.\n");
                return;
            }

            if (head.Data.ID == id)
            {
                head = head.Next;
                Console.WriteLine("Student deleted successfully!\n");
                return;
            }

            Node temp = head;
            while (temp.Next != null && temp.Next.Data.ID != id)
                temp = temp.Next;

            if (temp.Next == null)
            {
                Console.WriteLine("Student not found.\n");
            }
            else
            {
                temp.Next = temp.Next.Next;
                Console.WriteLine("Student deleted successfully!\n");
            }
        }
    }
}
