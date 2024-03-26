namespace Academy_Management_Class_Library
{
    public class StudentFunctions
    {
        public static void listSubjcets(Dictionary<string, int> achievments)
        {
            foreach(var achievment in achievments)
            {
                Console.WriteLine($"Subject: {achievment.Key}, Grade: {achievment.Value}");
            }
        }
    }
}
