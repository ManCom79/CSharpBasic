﻿using Academy_Management_Class_Library;
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

            Student student1 = new Student("Steph", "Stephenson", "steph123", "stephenson123");
            Student student2 = new Student("Ana", "Anson", "ana123", "anson123");


            List<Admin> admins = new List<Admin>() { admin1, admin2 };
            List<Teacher> teachers = new List<Teacher> { teacher1, teacher2 };
            List<Student> students = new List<Student> { student1, student2 };

            while (true)
            {
                bool adminUserFound = false;
                bool teacherUserFound = false;
                bool studentUserFound = false;

                Console.WriteLine("Welcome to the Academy Management App!\nSelect your role to log in (1, 2 or 3)");
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
                                            selectAdminAction(admins, teachers ,loggedAdmin);
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
                                            teacherUserFound = true;
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
                                            studentUserFound = true;
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
                    break;
                } else if (teacherUserFound = true)
                {
                    break;
                } else
                {
                    continue;
                }
            }

        }

        public static string selectAdminAction(List<Admin> admins, List<Teacher> teachers, Admin loggedAdmin)
        {
            while (true)
            {
                Console.WriteLine("\nPlease select action (1, 2 or 3):\n1. Add Admin\n2. Remove Admin\n3. Add Teacher\n4. Remove Teacher\n5. Add Student\n6. Remove Student\n7. Exit");
                string selectedAdminAction = Console.ReadLine();

                switch (selectedAdminAction)
                {
                    case "1":
                        {
                            AddAdmin(admins, teachers, loggedAdmin);
                            break;
                        }
                    case "2":
                        {
                            RemoveAdmin(admins, teachers, loggedAdmin);
                            break;
                        }
                    case "3":
                        {
                            AddTeacher(admins, teachers, loggedAdmin);
                            break;
                        }
                    case "4":
                        {
                            RemoveTeacher(admins, teachers, loggedAdmin);
                            break;
                        }
                    case "7":
                        {
                            continue;
                        }
                    default :
                        {
                            continue;
                        }
                }


                return $"{selectedAdminAction}";
            }
        }

        public static void AddAdmin(List<Admin> admins, List<Teacher> teachers,  Admin loggedAdmin)
        {
            Console.WriteLine($"There are {admins.Count} admins now.");
            Console.WriteLine("Please enter admin's first name: ");
            string adminFirstName = Console.ReadLine();
            Console.WriteLine("Please enter admin's last name: ");
            string adminLastName = Console.ReadLine();
            Console.WriteLine("Please enter admin's username: ");
            string adminUserName = Console.ReadLine();
            Console.WriteLine("Please enter admin's passwrod: ");
            string adminPassword = Console.ReadLine();

            int adminId; 

            while (true)
            {
                adminId = new Random().Next(0, 100);
                foreach (Admin admin in admins)
                {
                    if (admin.Id != adminId)
                    {
                        break;
                    }
                }
                break;
            }

            Admin newAdmin = new Admin(adminId, adminFirstName, adminLastName, adminUserName, adminPassword);
            admins.Add(newAdmin);
            Console.WriteLine($"There are {admins.Count} admins now.");
            selectAdminAction(admins, teachers, loggedAdmin);

        }

        public static void RemoveAdmin(List<Admin> admins, List<Teacher> teachers, Admin loggedAdmin)
        {
            List<int> AdminIds = new List<int>();

            if (admins.Count == 1)
            {
                Console.WriteLine("Sorry, no more admins left to remove.");
                selectAdminAction(admins, teachers, loggedAdmin);
            }

            while (true)
            {
                Console.WriteLine($"Select the ID of the admin you would like to remove");

                foreach (Admin admin in admins)
                {
                    if (!(admin.Id == loggedAdmin.Id))
                    {
                        AdminIds.Add(admin.Id);
                        Console.WriteLine($"ID: {admin.Id}, {admin.FirstName} {admin.LastName}");
                    }
                }
                string selectedIdToRemove = Console.ReadLine();

                if (!int.TryParse(selectedIdToRemove, out int selectedId))
                {
                    Console.WriteLine("Please select one of the available IDs.");
                    AdminIds.Clear();
                    continue;
                } else
                {
                    if (!AdminIds.Contains(selectedId))
                    {
                        Console.WriteLine("Please select one of the existing IDs:");
                    }
                    else
                    {
                        Admin adminToBeRemoved = admins.Find(x => x.Id == selectedId);
                        admins.Remove(adminToBeRemoved);
                        break;
                    }
                }

            }
            selectAdminAction(admins, teachers, loggedAdmin);
        }

        public static void AddTeacher(List<Admin> admins, List<Teacher> teachers, Admin loggedAdmin)
        {
            Console.WriteLine($"There are {teachers.Count} teachers now.");
            Console.WriteLine("Please enter teacher's first name: ");
            string teacherFirstName = Console.ReadLine();
            Console.WriteLine("Please enter teacher's last name: ");
            string teacherLastName = Console.ReadLine();
            Console.WriteLine("Please enter teacher's username: ");
            string teacherUserName = Console.ReadLine();
            Console.WriteLine("Please enter teacher's passwrod: ");
            string teacherPassword = Console.ReadLine();

            int teacherId;

            while (true)
            {
                teacherId = new Random().Next(0, 100);
                foreach (Teacher teacher in teachers)
                {
                    if (teacher.Id != teacherId)
                    {
                        break;
                    }
                }
                break;
            }

            Teacher newTeacher = new Teacher(teacherId, teacherFirstName, teacherLastName, teacherUserName, teacherPassword);
            teachers.Add(newTeacher);
            Console.WriteLine($"There are {teachers.Count} teachers now.");
            selectAdminAction(admins, teachers, loggedAdmin);

        }

        public static void RemoveTeacher(List<Admin> admins, List<Teacher> teachers, Admin loggedAdmin)
        {
            List<int> TeachersIds = new List<int>();

            if (teachers.Count == 0)
            {
                Console.WriteLine("Sorry, no more teachers left to remove.");
                selectAdminAction(admins, teachers, loggedAdmin);
            }

            while (true)
            {
                Console.WriteLine($"Select the ID of the teacher you would like to remove");

                foreach (Teacher teacher in teachers)
                {
                    Console.WriteLine($"ID: {teacher.Id}, {teacher.FirstName} {teacher.LastName}");
                    TeachersIds.Add(teacher.Id);
                }
                string selectedIdToRemove = Console.ReadLine();

                if (!int.TryParse(selectedIdToRemove, out int selectedId))
                {
                    Console.WriteLine("Please select one of the available IDs.");
                    TeachersIds.Clear();
                    continue;
                }
                else
                {
                    if (!TeachersIds.Contains(selectedId))
                    {
                        Console.WriteLine("Please select one of the existing IDs:");
                    }
                    else
                    {
                        Teacher teacherToBeRemoved = teachers.Find(x => x.Id == selectedId);
                        teachers.Remove(teacherToBeRemoved);
                        break;
                    }
                }

            }
            foreach (Teacher teacher in teachers)
            {
                    Console.WriteLine($"ID: {teacher.Id}, {teacher.FirstName} {teacher.LastName}");
            }
            selectAdminAction(admins, teachers, loggedAdmin);
        }
    }
}
