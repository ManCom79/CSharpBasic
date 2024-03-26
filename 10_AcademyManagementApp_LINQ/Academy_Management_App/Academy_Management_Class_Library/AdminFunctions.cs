namespace Academy_Management_Class_Library
{
    public class AdminFunctions
    {

        public static string selectAdminAction(List<Admin> admins, List<Teacher> teachers, List<Student> students, Admin loggedAdmin)
        {
            while (true)
            {
                Console.WriteLine("\nPlease select action (1 - 7):\n1. Add Admin\n2. Remove Admin\n3. Add Teacher\n4. Remove Teacher\n5. Add Student\n6. Remove Student\n7. Exit");
                string selectedAdminAction = Console.ReadLine();

                switch (selectedAdminAction)
                {
                    case "1":
                        {
                            AddAdmin(admins, teachers, students, loggedAdmin);
                            break;
                        }
                    case "2":
                        {
                            RemoveAdmin(admins, teachers, students, loggedAdmin);
                            break;
                        }
                    case "3":
                        {
                            AddTeacher(admins, teachers, students, loggedAdmin);
                            break;
                        }
                    case "4":
                        {
                            RemoveTeacher(admins, teachers, students, loggedAdmin);
                            break;
                        }
                    case "5":
                        {
                            AddStudent(admins, teachers, students, loggedAdmin);
                            break;
                        }
                    case "6":
                        {
                            AdminFunctions.RemoveStudent(admins, teachers, students, loggedAdmin);
                            break;
                        }
                    case "7":
                        {
                            break;
                        }
                    default:
                        {
                            continue;
                        }
                }


                return $"{selectedAdminAction}";
            }
        }

        public static void AddAdmin(List<Admin> admins, List<Teacher> teachers, List<Student> students, Admin loggedAdmin)
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
            selectAdminAction(admins, teachers, students, loggedAdmin);

        }

        public static void RemoveAdmin(List<Admin> admins, List<Teacher> teachers, List<Student> students, Admin loggedAdmin)
        {
            List<int> AdminIds = new List<int>();

            if (admins.Count == 1)
            {
                Console.WriteLine("Sorry, no more admins left to remove.");
                selectAdminAction(admins, teachers, students, loggedAdmin);
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
                }
                else
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
            selectAdminAction(admins, teachers, students, loggedAdmin);
        }

        public static void AddTeacher(List<Admin> admins, List<Teacher> teachers, List<Student> students, Admin loggedAdmin)
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
            selectAdminAction(admins, teachers, students, loggedAdmin);

        }

        public static void RemoveTeacher(List<Admin> admins, List<Teacher> teachers, List<Student> students, Admin loggedAdmin)
        {
            List<int> TeachersIds = new List<int>();

            if (teachers.Count == 0)
            {
                Console.WriteLine("Sorry, no more teachers left to remove.");
                selectAdminAction(admins, teachers, students, loggedAdmin);
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
            selectAdminAction(admins, teachers, students, loggedAdmin);
        }

        public static void AddStudent(List<Admin> admins, List<Teacher> teachers, List<Student> students, Admin loggedAdmin)
        {
            Console.WriteLine($"There are {students.Count} students now.");
            Console.WriteLine("Please enter student's first name: ");
            string studentFirstName = Console.ReadLine();
            Console.WriteLine("Please enter student's last name: ");
            string studentLastName = Console.ReadLine();
            Console.WriteLine("Please enter student's username: ");
            string studentUserName = Console.ReadLine();
            Console.WriteLine("Please enter student's passwrod: ");
            string studentPassword = Console.ReadLine();

            int studentId;

            while (true)
            {
                studentId = new Random().Next(0, 100);
                foreach (Student student in students)
                {
                    if (student.Id != studentId)
                    {
                        break;
                    }
                }
                break;
            }

            Student newStudent = new Student(studentId, studentFirstName, studentLastName, studentUserName, studentPassword);
            students.Add(newStudent);
            Console.WriteLine($"There are {students.Count} students now.");
            selectAdminAction(admins, teachers, students, loggedAdmin);
        }

        public static void RemoveStudent(List<Admin> admins, List<Teacher> teachers, List<Student> students, Admin loggedAdmin)
        {
            List<int> StudentsIds = new List<int>();

            if (students.Count == 0)
            {
                Console.WriteLine("Sorry, no more students left to remove.");
                selectAdminAction(admins, teachers, students, loggedAdmin);
            }

            while (true)
            {
                Console.WriteLine($"Select the ID of the student you would like to remove");

                foreach (Student student in students)
                {
                    Console.WriteLine($"ID: {student.Id}, {student.FirstName} {student.LastName}");
                    StudentsIds.Add(student.Id);
                }
                string selectedIdToRemove = Console.ReadLine();

                if (!int.TryParse(selectedIdToRemove, out int selectedId))
                {
                    Console.WriteLine("Please select one of the available IDs.");
                    StudentsIds.Clear();
                    continue;
                }
                else
                {
                    if (!StudentsIds.Contains(selectedId))
                    {
                        Console.WriteLine("Please select one of the existing IDs:");
                    }
                    else
                    {
                        Student studentToBeRemoved = students.Find(x => x.Id == selectedId);
                        students.Remove(studentToBeRemoved);
                        break;
                    }
                }

            }
            foreach (Student student in students)
            {
                Console.WriteLine($"ID: {student.Id}, {student.FirstName} {student.LastName}");
            }
            selectAdminAction(admins, teachers, students, loggedAdmin);
        }
    }
}
