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

        //public static string selectAdminAction(List<Admin> admins, List<Teacher> teachers, List<Student> students, Admin loggedAdmin)
        //{
        //    while (true)
        //    {
        //        Console.WriteLine("\nPlease select action (1 - 7):\n1. Add Admin\n2. Remove Admin\n3. Add Teacher\n4. Remove Teacher\n5. Add Student\n6. Remove Student\n7. Exit");
        //        string selectedAdminAction = Console.ReadLine();

        //        switch (selectedAdminAction)
        //        {
        //            case "1":
        //                {
        //                    AddAdmin(admins, teachers, students, loggedAdmin);
        //                    break;
        //                }
        //            case "2":
        //                {
        //                    RemoveAdmin(admins, teachers, students, loggedAdmin);
        //                    break;
        //                }
        //            case "3":
        //                {
        //                    AddTeacher(admins, teachers, students, loggedAdmin);
        //                    break;
        //                }
        //            case "4":
        //                {
        //                    RemoveTeacher(admins, teachers, students, loggedAdmin);
        //                    break;
        //                }
        //            case "5":
        //                {
        //                    AddStudent(admins, teachers, students, loggedAdmin);
        //                    break;
        //                }
        //            case "6":
        //                {
        //                    AdminFunctions.RemoveStudent(admins, teachers, students, loggedAdmin);
        //                    break;
        //                }
        //            case "7":
        //                {
        //                    break;
        //                }
        //            default :
        //                {
        //                    continue;
        //                }
        //        }


        //        return $"{selectedAdminAction}";
        //    }
        //}

        //public static void AddAdmin(List<Admin> admins, List<Teacher> teachers, List<Student>students,  Admin loggedAdmin)
        //{
        //    Console.WriteLine($"There are {admins.Count} admins now.");
        //    Console.WriteLine("Please enter admin's first name: ");
        //    string adminFirstName = Console.ReadLine();
        //    Console.WriteLine("Please enter admin's last name: ");
        //    string adminLastName = Console.ReadLine();
        //    Console.WriteLine("Please enter admin's username: ");
        //    string adminUserName = Console.ReadLine();
        //    Console.WriteLine("Please enter admin's passwrod: ");
        //    string adminPassword = Console.ReadLine();

        //    int adminId; 

        //    while (true)
        //    {
        //        adminId = new Random().Next(0, 100);
        //        foreach (Admin admin in admins)
        //        {
        //            if (admin.Id != adminId)
        //            {
        //                break;
        //            }
        //        }
        //        break;
        //    }

        //    Admin newAdmin = new Admin(adminId, adminFirstName, adminLastName, adminUserName, adminPassword);
        //    admins.Add(newAdmin);
        //    Console.WriteLine($"There are {admins.Count} admins now.");
        //    selectAdminAction(admins, teachers, students, loggedAdmin);

        //}

        //public static void RemoveAdmin(List<Admin> admins, List<Teacher> teachers, List<Student> students, Admin loggedAdmin)
        //{
        //    List<int> AdminIds = new List<int>();

        //    if (admins.Count == 1)
        //    {
        //        Console.WriteLine("Sorry, no more admins left to remove.");
        //        selectAdminAction(admins, teachers, students, loggedAdmin);
        //    }

        //    while (true)
        //    {
        //        Console.WriteLine($"Select the ID of the admin you would like to remove");

        //        foreach (Admin admin in admins)
        //        {
        //            if (!(admin.Id == loggedAdmin.Id))
        //            {
        //                AdminIds.Add(admin.Id);
        //                Console.WriteLine($"ID: {admin.Id}, {admin.FirstName} {admin.LastName}");
        //            }
        //        }
        //        string selectedIdToRemove = Console.ReadLine();

        //        if (!int.TryParse(selectedIdToRemove, out int selectedId))
        //        {
        //            Console.WriteLine("Please select one of the available IDs.");
        //            AdminIds.Clear();
        //            continue;
        //        } else
        //        {
        //            if (!AdminIds.Contains(selectedId))
        //            {
        //                Console.WriteLine("Please select one of the existing IDs:");
        //            }
        //            else
        //            {
        //                Admin adminToBeRemoved = admins.Find(x => x.Id == selectedId);
        //                admins.Remove(adminToBeRemoved);
        //                break;
        //            }
        //        }

        //    }
        //    selectAdminAction(admins, teachers, students, loggedAdmin);
        //}

        //public static void AddTeacher(List<Admin> admins, List<Teacher> teachers, List<Student> students, Admin loggedAdmin)
        //{
        //    Console.WriteLine($"There are {teachers.Count} teachers now.");
        //    Console.WriteLine("Please enter teacher's first name: ");
        //    string teacherFirstName = Console.ReadLine();
        //    Console.WriteLine("Please enter teacher's last name: ");
        //    string teacherLastName = Console.ReadLine();
        //    Console.WriteLine("Please enter teacher's username: ");
        //    string teacherUserName = Console.ReadLine();
        //    Console.WriteLine("Please enter teacher's passwrod: ");
        //    string teacherPassword = Console.ReadLine();

        //    int teacherId;

        //    while (true)
        //    {
        //        teacherId = new Random().Next(0, 100);
        //        foreach (Teacher teacher in teachers)
        //        {
        //            if (teacher.Id != teacherId)
        //            {
        //                break;
        //            }
        //        }
        //        break;
        //    }

        //    Teacher newTeacher = new Teacher(teacherId, teacherFirstName, teacherLastName, teacherUserName, teacherPassword);
        //    teachers.Add(newTeacher);
        //    Console.WriteLine($"There are {teachers.Count} teachers now.");
        //    selectAdminAction(admins, teachers, students, loggedAdmin);

        //}

        //public static void RemoveTeacher(List<Admin> admins, List<Teacher> teachers, List<Student> students, Admin loggedAdmin)
        //{
        //    List<int> TeachersIds = new List<int>();

        //    if (teachers.Count == 0)
        //    {
        //        Console.WriteLine("Sorry, no more teachers left to remove.");
        //        selectAdminAction(admins, teachers, students, loggedAdmin);
        //    }

        //    while (true)
        //    {
        //        Console.WriteLine($"Select the ID of the teacher you would like to remove");

        //        foreach (Teacher teacher in teachers)
        //        {
        //            Console.WriteLine($"ID: {teacher.Id}, {teacher.FirstName} {teacher.LastName}");
        //            TeachersIds.Add(teacher.Id);
        //        }
        //        string selectedIdToRemove = Console.ReadLine();

        //        if (!int.TryParse(selectedIdToRemove, out int selectedId))
        //        {
        //            Console.WriteLine("Please select one of the available IDs.");
        //            TeachersIds.Clear();
        //            continue;
        //        }
        //        else
        //        {
        //            if (!TeachersIds.Contains(selectedId))
        //            {
        //                Console.WriteLine("Please select one of the existing IDs:");
        //            }
        //            else
        //            {
        //                Teacher teacherToBeRemoved = teachers.Find(x => x.Id == selectedId);
        //                teachers.Remove(teacherToBeRemoved);
        //                break;
        //            }
        //        }

        //    }
        //    foreach (Teacher teacher in teachers)
        //    {
        //            Console.WriteLine($"ID: {teacher.Id}, {teacher.FirstName} {teacher.LastName}");
        //    }
        //    selectAdminAction(admins, teachers, students, loggedAdmin);
        //}

        //public static void AddStudent(List<Admin> admins, List<Teacher> teachers, List<Student> students, Admin loggedAdmin)
        //{
        //    Console.WriteLine($"There are {students.Count} students now.");
        //    Console.WriteLine("Please enter student's first name: ");
        //    string studentFirstName = Console.ReadLine();
        //    Console.WriteLine("Please enter student's last name: ");
        //    string studentLastName = Console.ReadLine();
        //    Console.WriteLine("Please enter student's username: ");
        //    string studentUserName = Console.ReadLine();
        //    Console.WriteLine("Please enter student's passwrod: ");
        //    string studentPassword = Console.ReadLine();

        //    int studentId;

        //    while (true)
        //    {
        //        studentId = new Random().Next(0, 100);
        //        foreach (Student student in students)
        //        {
        //            if (student.Id != studentId)
        //            {
        //                break;
        //            }
        //        }
        //        break;
        //    }

        //    Student newStudent = new Student(studentId, studentFirstName, studentLastName, studentUserName, studentPassword);
        //    students.Add(newStudent);
        //    Console.WriteLine($"There are {students.Count} students now.");
        //    selectAdminAction(admins, teachers, students, loggedAdmin);
        //}

        //public static void RemoveStudent(List<Admin> admins, List<Teacher> teachers, List<Student> students, Admin loggedAdmin)
        //{
        //    List<int> StudentsIds = new List<int>();

        //    if (students.Count == 0)
        //    {
        //        Console.WriteLine("Sorry, no more students left to remove.");
        //        selectAdminAction(admins, teachers, students, loggedAdmin);
        //    }

        //    while (true)
        //    {
        //        Console.WriteLine($"Select the ID of the student you would like to remove");

        //        foreach (Student student in students)
        //        {
        //            Console.WriteLine($"ID: {student.Id}, {student.FirstName} {student.LastName}");
        //            StudentsIds.Add(student.Id);
        //        }
        //        string selectedIdToRemove = Console.ReadLine();

        //        if (!int.TryParse(selectedIdToRemove, out int selectedId))
        //        {
        //            Console.WriteLine("Please select one of the available IDs.");
        //            StudentsIds.Clear();
        //            continue;
        //        }
        //        else
        //        {
        //            if (!StudentsIds.Contains(selectedId))
        //            {
        //                Console.WriteLine("Please select one of the existing IDs:");
        //            }
        //            else
        //            {
        //                Student studentToBeRemoved = students.Find(x => x.Id == selectedId);
        //                students.Remove(studentToBeRemoved);
        //                break;
        //            }
        //        }

        //    }
        //    foreach (Student student in students)
        //    {
        //        Console.WriteLine($"ID: {student.Id}, {student.FirstName} {student.LastName}");
        //    }
        //    selectAdminAction(admins, teachers, students, loggedAdmin);
        //}
    }
}
