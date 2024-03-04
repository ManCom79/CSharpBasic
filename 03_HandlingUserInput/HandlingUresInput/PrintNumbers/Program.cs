namespace PrintNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1;
            int number2;

            while (true)
            {
                Console.WriteLine("Please enter a number: ");
                string firstNumberInput = Console.ReadLine();

                if (int.TryParse(firstNumberInput, out number1))
                {
                    for (int i = 1; i <= number1; i++)
                    {
                        Console.WriteLine(i);
                    }
                    break;
                }

                Console.WriteLine("Wrong input. Please enter number!");
            }

            while (true)
            {
                Console.WriteLine("Please enter a number: ");
                string secondNumberInput = Console.ReadLine();

                if (int.TryParse(secondNumberInput, out number2))
                {
                    for (int i = number2; i>= 1; i--)
                    {
                        Console.WriteLine(i);
                    }
                    break;
                }

                Console.WriteLine("Wrong input. Please enter number!");
            }
        }
    }
}
