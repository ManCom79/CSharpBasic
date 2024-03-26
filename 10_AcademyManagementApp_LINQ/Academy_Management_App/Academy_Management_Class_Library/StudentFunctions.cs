namespace Academy_Management_Class_Library
{
    public class StudentFunctions
    {
        public static void listSubjcets(Dictionary<string, int> achievments)
        {
            if (achievments.Count == 0)
            {
                Console.WriteLine("NEW STUDENT ENROLMENT!!! No achievments available at the moment.");
            } else
            {
                foreach (var achievment in achievments)
                {
                    Console.WriteLine($"Subject: {achievment.Key}, Grade: {achievment.Value}");
                }
            }
        }
    }
}
