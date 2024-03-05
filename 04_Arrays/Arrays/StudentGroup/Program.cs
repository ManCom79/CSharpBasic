namespace StudentGroup
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userChoise;

            string[] studentsG1 = new string[5];
            studentsG1 = ["John", "Ana", "Jack", "Mary", "Scotty"];

            string[] studentsG2 = new string[5];
            studentsG2 = ["Spock", "Uhura", "Jane", "Paul", "Tom"];

            while(true)
            {
                Console.WriteLine("Enter student group (1 or 2): ");
                string userInput = Console.ReadLine();

                if(!(userInput == "1" || userInput == "2"))
                {
                    Console.WriteLine("Please enter 1 or 2: ");
                    continue;
                }

                Console.WriteLine($"Students in group G{userInput} are:");

                switch (userInput)
                {
                    case "1":
                        foreach(string student in studentsG1)
                        {
                            Console.WriteLine(student);
                        }
                    break;
                    case "2":
                        foreach(string student in studentsG2)
                        {
                            Console.WriteLine(student);
                        }
                        break;
                }
                break;
            }
        }
    }
}
