namespace NumbersInQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> numbersQueue = new Queue<int>();

            while (true)
            {
                bool enterNewNumber = false;

                Console.Write("Please enter a number: ");
                string userInput = Console.ReadLine();

                if (!int.TryParse(userInput, out int enteredNumber))
                {
                    Console.WriteLine("Invalid Input!");
                    continue;
                } else
                {
                    numbersQueue.Enqueue(enteredNumber);
                }

                while (true)
                {
                    Console.WriteLine("Would you like to enter another number (y/n)?");
                    string enterNumberAgain = Console.ReadLine();

                    if (enterNumberAgain.ToLower() == "y")
                    {
                        enterNewNumber = true;
                        break;
                    };

                    if (enterNumberAgain.ToLower() == "n")
                    {
                        break;
                    };

                    if (enterNumberAgain.ToLower() != "y" && enterNumberAgain.ToLower() != "n")
                    {
                        Console.WriteLine("Please enter \"y\" or \"n\"");
                        continue;
                    }
                }

                if (enterNewNumber == true)
                {
                    continue;
                } else
                {
                    break;
                }

            }
            Console.WriteLine("\nThe numbers in the queue are entered in this order:");
            foreach (int number in numbersQueue)
            {
                Console.WriteLine($"{number}");
            }
        }
    }
}
