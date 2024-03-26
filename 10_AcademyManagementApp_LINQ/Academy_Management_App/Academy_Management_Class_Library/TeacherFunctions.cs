using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Academy_Management_Class_Library
{
    public class TeacherFunctions
    {
        public static void selectAction(List<Student> students)
        {
            while (true)
            {
                Console.WriteLine("Please select action (1 or 2):\n1. List students\n2. List subjects\n3. Exit");
                string selectedAction = Console.ReadLine();

                if (selectedAction != "1" && selectedAction != "2" && selectedAction != "3")
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }

                switch (selectedAction)
                {
                    case "1":
                        {
                            listStudents(students);
                            break;
                        }
                    case "2":
                        {
                            listSubjectStats(students);
                            break;
                        }
                    case "3":
                        {
                            break;
                        }
                }
                break;
            }
        }

        public static void listStudents(List<Student> students)
        {

            while (true)
            {
                bool exit = false;

                foreach (Student student in students)
                {
                    Console.WriteLine($"ID: {student.Id}; First Name: {student.FirstName}; Last Name: {student.LastName}");
                }

                Console.WriteLine("Please select ID of a student to list its subjects, or select 0 to exit:");
                string selectedAction = Console.ReadLine();

                List<int> listOfStudentIds = new List<int>();

                foreach (Student student in students)
                {
                    listOfStudentIds.Add(student.Id);
                }

                if (!int.TryParse(selectedAction, out int studentId)) {
                    Console.WriteLine("Please select one of the available options!");
                    continue;
                } else
                {
                    if (listOfStudentIds.Contains(studentId))
                    { 
                        List<Student> studentFound = students.Where(x => x.Id == studentId).ToList();
                        Console.WriteLine($"Achievments of {studentFound[0].FirstName} {studentFound[0].LastName} are:");
                        if (studentFound[0].Achievments.Count == 0)
                        {
                            Console.WriteLine("NEW STUDENT ENROLMENT!!! No achievments available at the moment.");
                        } else
                        {
                            foreach (var subjects in studentFound[0].Achievments)
                            {
                                Console.WriteLine($"Subject: {subjects.Key}; Grade {subjects.Value}");
                            }
                        }
                        continue;
                    }
                    else if (studentId == 0)
                    {
                        selectAction(students);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input!");
                        continue;
                    }
                }

                
            }
        }

        public static void listSubjectStats(List<Student> students)
        {
            List<string> allSubjects = new List<string>();

            foreach (Student student in students)
            {
                foreach(var subject in student.Achievments)
                {
                    allSubjects.Add(subject.Key);
                }
            }

            List<string> uniqueSubejects = new List<string>();
            uniqueSubejects = allSubjects.Distinct().ToList();

            Console.WriteLine("Available subcets are:");
            foreach (string subeject in uniqueSubejects)
            {
                Console.WriteLine(subeject);
            }

            foreach(string subject in uniqueSubejects)
            {
                int counter = 0;
                for (int i = 0; i < allSubjects.Count; i++)
                {
                    if (subject == allSubjects[i])
                    {
                        counter++;
                    }
                }
                Console.WriteLine($"The subject \"{subject}\" has {counter} students enrolled. ");
            }
            selectAction(students);
        }
    }
}
