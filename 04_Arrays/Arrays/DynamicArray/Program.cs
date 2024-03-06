namespace DynamicArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[0];
            string userInput;

            while (true)
            {
                Console.WriteLine("Please enter a name: ");
                string userNameInput = Console.ReadLine();

                Array.Resize(ref names, names.Length + 1);
                names[names.Length - 1] = userNameInput;

                while (true)
                {
                    Console.WriteLine("Would you like to enter another name? (Y/N)");
                    string userToContinueInput = Console.ReadLine();
                    userInput = userToContinueInput.ToLower();

                    if (userInput == "y")
                    {
                        break;
                    }

                    if (userInput != "y" && userInput != "n")
                    {
                        Console.WriteLine("Please enter Y or N.");
                        continue;
                    }
                    if (userInput == "n")
                    {
                        break;
                    }
                }
                if (userInput == "n")
                {
                    break;
                }
            }
            Console.WriteLine("The names entered in the array are:");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
