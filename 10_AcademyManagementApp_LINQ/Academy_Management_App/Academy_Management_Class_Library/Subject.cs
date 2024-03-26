namespace Academy_Management_Class_Library
{
    public class Subject
    {
        public int Id { get; set; }
        public string SubjectTitle { get; set; }

        public Subject(int id, string subjectTitle)
        {
            Id = id;
            SubjectTitle = subjectTitle;
        }
    }
}
