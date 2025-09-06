using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRecord
{
    partial class SinglyLinkedList
    {
        public void AddStudent(Student student, int option, int targetId )
        {
            Node newNode = new Node(student);

            if (option == 1)
            {
                newNode.Next = head;
                head = newNode;
                Console.WriteLine("Student added at the beginning!\n");
            }
            else if (option == 2)
            {
                if (head == null)
                {
                    head = newNode;
                }
                else
                {
                    Node temp = head;
                    while (temp.Next != null)
                        temp = temp.Next;
                    temp.Next = newNode;
                }
                Console.WriteLine("Student added at the end!\n");
            }
            else if (option == 3)
            {
                Node temp = head;
                while (temp != null && temp.Data.ID != targetId)
                    temp = temp.Next;

                if (temp == null)
                {
                    Console.WriteLine("Target Student ID not found. Adding canceled.\n");
                }
                else
                {
                    newNode.Next = temp.Next;
                    temp.Next = newNode;
                    Console.WriteLine($"Student added after ID {targetId}!\n");
                }
            }
        }
    }
}
