namespace Academy_Management_Class_Library
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public Dictionary<string, int> Achievments { get; set; }

        public Student(int id, string firstName, string lastName, string userName, string password, Dictionary<string, int> achievments)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            UserName = userName;
            Password = password;
            Achievments = achievments;
        }
    }
}
