namespace Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfCharacters;
            string misteryString = "Hello from SEDC Codecademy 2024";


            while (true)
            {
                Console.WriteLine("I am hiding a string.\nEnter number of how many characters of the string you want to see:");
                string userInput = Console.ReadLine();

                if (!int.TryParse(userInput, out numberOfCharacters))
                {
                    Console.WriteLine($"Invalid input \"{userInput}\".");
                    continue;
                }

                if (numberOfCharacters <= 0)
                {
                    Console.WriteLine("Sorry, string cannot have length zero or less than zero.");
                    continue;
                } else if (numberOfCharacters > misteryString.Length)
                {
                    Console.WriteLine($"Sorry, the hidden string has less than {numberOfCharacters} characters.");
                    continue;
                }

                string substring = Substrings(misteryString, numberOfCharacters);
                Console.WriteLine($"The first {numberOfCharacters} characters of the hidden string are {substring}.\nThe extracted substring is {substring.Length} characters long.");
                break;
            }

        }

        public static string Substrings (string sampleString, int substringLength)
        {
            string hiddenString = sampleString;
            string substring = hiddenString.Substring(0, substringLength);
            return substring;
        }
    }
}
