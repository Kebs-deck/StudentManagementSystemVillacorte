using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRecord
{
    class Node
    {
        public Student Data;
        public Node Next;

        public Node(Student student)
        {
            Data = student;
            Next = null;
        }
    }
}
