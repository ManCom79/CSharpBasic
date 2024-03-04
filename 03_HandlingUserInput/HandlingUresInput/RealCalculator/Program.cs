namespace RealCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1;
            int number2;
            float result;

            while (true)
            {
                Console.WriteLine("Please enter the first number: ");
                string firstNumberInput = Console.ReadLine();

                if (int.TryParse(firstNumberInput, out number1))
                {
                    break;
                }

                Console.WriteLine("Invalid entry. Please try again!");
            }

            while (true)
            {
                Console.WriteLine("Please enter the second number: ");
                string secondNumberInput = Console.ReadLine();

                if (int.TryParse(secondNumberInput, out number2))
                {
                    break;
                }

                Console.WriteLine("Invalid entry. Please try again!");
            }

            while (true)
            {
                Console.WriteLine("Please enter the operation (+, -, *, /)");
                string operationInput = Console.ReadLine();

                switch (operationInput)
                {
                    case "+":
                        result = number1 + number2;
                        Console.WriteLine($"Sum of {number1} and {number2} is {result}.");
                        break;
                    case "-":
                        result = number1 - number2;
                        Console.WriteLine($"Difference of {number1} and {number2} is {result}.");
                        break;
                    case "*":
                        result = number1 * number2;
                        Console.WriteLine($"Product of {number1} and {number2} is {result}.");
                        break;
                    case "/":
                        result = number1 / (float)number2;
                        Console.WriteLine($"Quotient of {number1} and {number2} is {result}.");
                        break;
                    default: 
                        Console.WriteLine("Invalid entry. Please try again!");
                        continue;
                }
                break;
            }
        }
    }
}
