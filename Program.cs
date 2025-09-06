using System;

namespace StudentRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            SinglyLinkedList studentList = new SinglyLinkedList();

            while (true)
            {
                Console.WriteLine("╔═══════════════════════════════╗");
                Console.WriteLine("║         Student Record        ║");
                Console.WriteLine("╠═══════════════════════════════╣");
                Console.WriteLine("║       1. Add Student          ║");
                Console.WriteLine("║       2. Delete Student       ║");
                Console.WriteLine("║       3. Search Student       ║");
                Console.WriteLine("║       4. Update Student       ║");
                Console.WriteLine("║       5. Display All          ║");
                Console.WriteLine("║       6. Exit                 ║");
                Console.WriteLine("╚═══════════════════════════════╝");
                Console.Write("Select an Option: ");

                int choice;
                while (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Enter a valid option number!");
                    Console.Write("Select an Option: ");
                }
                Console.WriteLine();

                switch (choice)
                {
                    case 1:
                        int id;
                        while (true)
                        {
                            Console.Write("Enter ID: ");
                            if (int.TryParse(Console.ReadLine(), out id))
                                break;
                            Console.WriteLine("Enter valid ID Number!");
                        }

                        Console.Write("Enter Name: ");
                        string name = Console.ReadLine();

                        Console.Write("Enter Course: ");
                        string course = Console.ReadLine();

                        int year;
                        while (true)
                        {
                            Console.Write("Enter Year Level: ");
                            if (int.TryParse(Console.ReadLine(), out year))
                                break;
                            Console.WriteLine("Enter valid Year Level!");
                        }

                        float gpa;
                        while (true)
                        {
                            Console.Write("Enter GPA: ");
                            if (float.TryParse(Console.ReadLine(), out gpa))
                                break;
                            Console.WriteLine("Enter valid GPA!");
                        }

                        Console.WriteLine("Where do you want to insert?");
                        Console.WriteLine("1. At Beginning");
                        Console.WriteLine("2. At End");
                        Console.WriteLine("3. After Specific Student");
                        Console.Write("Choice: ");
                        int insertChoice = int.Parse(Console.ReadLine());

                        int targetId = -1;
                        if (insertChoice == 3)
                        {
                            Console.Write("Enter target Student ID: ");
                            targetId = int.Parse(Console.ReadLine());
                        }

                        studentList.AddStudent(new Student(id, name, course, year, gpa), insertChoice, targetId);
                        break;

                    case 2:
                        Console.Write("Enter ID to delete: ");
                        int deleteId = int.Parse(Console.ReadLine());
                        studentList.DeleteStudent(deleteId);
                        break;

                    case 3:
                        Console.Write("Enter ID to search: ");
                        int searchId = int.Parse(Console.ReadLine());
                        studentList.SearchStudent(searchId);
                        break;

                    case 4:
                        Console.Write("Enter ID to update: ");
                        int updateId = int.Parse(Console.ReadLine());
                        studentList.UpdateStudent(updateId);
                        break;

                    case 5:
                        studentList.DisplayStudents();
                        break;

                    case 6:
                        Console.WriteLine("Exiting program...");
                        return;

                    default:
                        Console.WriteLine("Invalid choice, try again.\n");
                        break;
                }
            }
        }
    }
}
