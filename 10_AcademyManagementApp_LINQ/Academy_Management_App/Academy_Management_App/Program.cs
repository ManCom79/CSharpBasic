using Academy_Management_Class_Library;
using System.Collections;
using System.Collections.Generic;

namespace Academy_Management_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Admin loggedAdmin;
            Teacher loggedTeacher;
            Student loggedStudent;

            Admin admin1 = new Admin(1, "Bob", "Bobsky", "bob123", "bobsky123");
            Admin admin2 = new Admin(2, "Jane", "Doe", "jane123", "doe123");

            Teacher teacher1 = new Teacher(1, "John", "Johnson", "john123", "johnson123");
            Teacher teacher2 = new Teacher(2, "Jess", "Jesson", "jess123", "jesson123");

            Subject subject1 = new Subject(1, "Programming");
            Subject subject2 = new Subject(2, "DevOps");
            Subject subject3 = new Subject(3, "QA");

            Dictionary<string, int> achievment = new Dictionary<string, int>() {};
            Dictionary<string, int> achievment1 = new Dictionary<string, int>() { { subject1.SubjectTitle, 4 }, { subject2.SubjectTitle, 3} };
            Dictionary<string, int> achievment2 = new Dictionary<string, int>() { { subject1.SubjectTitle, 5 }, { subject3.SubjectTitle, 5} };
            Dictionary<string, int> achievment3 = new Dictionary<string, int>() { { subject2.SubjectTitle, 4 }, { subject3.SubjectTitle, 5} };
            Dictionary<string, int> achievment4 = new Dictionary<string, int>() { { subject1.SubjectTitle, 3 }, { subject3.SubjectTitle, 4} };
            Dictionary<string, int> achievment5 = new Dictionary<string, int>() { { subject2.SubjectTitle, 2 }, { subject3.SubjectTitle, 3} };
            Dictionary<string, int> achievment6 = new Dictionary<string, int>() { { subject1.SubjectTitle, 5 }, { subject3.SubjectTitle, 2} };

            Student student1 = new Student(1, "Steph", "Stephenson", "steph123", "stephenson123", achievment1);
            Student student2 = new Student(2, "Ana", "Anson", "ana123", "anson123", achievment2);
            Student student3 = new Student(3, "John", "Doe", "john123", "doe123", achievment3);
            Student student4 = new Student(4, "Janice", "Joplin", "janice123", "joplin123", achievment4);
            Student student5 = new Student(5, "Tom", "Henks", "tom123", "henks123", achievment5);
            Student student6 = new Student(6, "Ema", "Thompson", "ema123", "thompson123", achievment6);

            List<Admin> admins = new List<Admin>() { admin1, admin2 };
            List<Teacher> teachers = new List<Teacher> { teacher1, teacher2 };
            List<Student> students = new List<Student> { student1, student2, student3, student4, student5, student6};
            List<Subject> subjects = new List<Subject> { };

            while (true)
            {
                bool adminUserFound = false;
                bool teacherUserFound = false;
                bool studentUserFound = false;

                Console.WriteLine("Welcome to the Academy Management App!\nSelect your role to log in:\n1. Admin\n2. Teacher\n3. Student");
                string signedInRole = Console.ReadLine();

                switch (signedInRole)
                {
                    case "1":
                        {
                            Console.WriteLine("Please enter your admin username: ");
                            string loggedAdminUserName = Console.ReadLine();

                            if (admins.Where(x => x.UserName == loggedAdminUserName).ToList().Count != 0)
                            {
                                Console.WriteLine("Please enter your password:");
                                string loggedAdminPassword = Console.ReadLine();
                                if (admins.Where(x => x.UserName == loggedAdminUserName && x.Password == loggedAdminPassword).ToList().Count != 0)
                                {
                                    foreach(Admin admin in admins)
                                    {
                                        if (admin.UserName == loggedAdminUserName && admin.Password == loggedAdminPassword)
                                        {
                                            loggedAdmin = admin;
                                            Console.WriteLine($"Welcome {loggedAdmin.FirstName} {loggedAdmin.LastName}.");
                                            //adminUserFound = true;
                                            AdminFunctions.selectAdminAction(admins, teachers, students,loggedAdmin, achievment);
                                            break;
                                        }
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Sorry, wrong password!");
                                    continue;
                                }

                            } else
                            {
                                Console.WriteLine("Sorry, the user does not exist");
                                continue;
                            }
                            break;
                        }
                        case "2":
                        {
                            Console.WriteLine("Please enter your teacher username: ");
                            string loggedTeacherUserName = Console.ReadLine();

                            if (teachers.Where(x => x.UserName == loggedTeacherUserName).ToList().Count != 0)
                            {
                                Console.WriteLine("Please enter your password:");
                                string loggedTeacherPassword = Console.ReadLine();
                                if (teachers.Where(x => x.UserName == loggedTeacherUserName && x.Password == loggedTeacherPassword).ToList().Count != 0)
                                {
                                    foreach (Teacher teacher in teachers)
                                    {
                                        if (teacher.UserName == loggedTeacherUserName && teacher.Password == loggedTeacherPassword)
                                        {
                                            loggedTeacher = teacher;
                                            Console.WriteLine($"Welcome {loggedTeacher.FirstName} {loggedTeacher.LastName}.");
                                            //teacherUserFound = true;
                                            TeacherFunctions.selectAction(students);
                                        }
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Sorry, wrong password!");
                                    continue;
                                }

                            }
                            else
                            {
                                Console.WriteLine("Sorry, the user does not exist");
                                continue;
                            }
                            break;
                        }
                    case "3":
                        {
                            Console.WriteLine("Please enter your student username: ");
                            string loggedStudentUserName = Console.ReadLine();

                            if (students.Where(x => x.UserName == loggedStudentUserName).ToList().Count != 0)
                            {
                                Console.WriteLine("Please enter your password:");
                                string loggedStudentPassword = Console.ReadLine();
                                if (students.Where(x => x.UserName == loggedStudentUserName && x.Password == loggedStudentPassword).ToList().Count != 0)
                                {
                                    foreach (Student student in students)
                                    {
                                        if (student.UserName == loggedStudentUserName && student.Password == loggedStudentPassword)
                                        {
                                            loggedStudent = student;
                                            Console.WriteLine($"Welcome {loggedStudent.FirstName} {loggedStudent.LastName}.");
                                            StudentFunctions.listSubjcets(student.Achievments);
                                            break;
                                        }
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Sorry, wrong password!");
                                    continue;
                                }

                            }
                            else
                            {
                                Console.WriteLine("Sorry, the user does not exist");
                                continue;
                            }
                            break;
                        }
                    default:
                        {
                            continue;
                        }
                }
                if (adminUserFound = true)
                {
                    continue;
                } else if (teacherUserFound = true)
                {
                    continue;
                } else
                {
                    continue;
                }
            }

        }
    }
}
