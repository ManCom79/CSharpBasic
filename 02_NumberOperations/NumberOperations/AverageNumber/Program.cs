namespace AverageNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Handle first entry
            Console.WriteLine("Enter the First number: ");
            string firstInput = Console.ReadLine();

            int firstNumber;
            bool parseFirstNumber = int.TryParse(firstInput, out firstNumber);

            if(!parseFirstNumber) {
                Console.WriteLine($"Provided input \"{firstInput}\" is not a number.");
            } else
            {
                Console.WriteLine($"First entered number is {firstNumber}");
            }

            //Handle second entry
            Console.WriteLine("Enter the Second number: ");
            string secondInput = Console.ReadLine();

            int secondNumber;
            bool parseSecondNumber = int.TryParse(secondInput, out secondNumber);

            if(!parseSecondNumber)
            {
                Console.WriteLine($"Provided input \"{secondInput}\" is not a number");
            } else
            {
                Console.WriteLine($"Second entered number is {secondNumber}");
            }


            //Handle third entry
            Console.WriteLine("Enter the Third number: ");
            string thirdInput = Console.ReadLine();

            int thirdNumber;
            bool parseThirdNumber = int.TryParse(thirdInput, out thirdNumber);

            if (!parseThirdNumber)
            {
                Console.WriteLine($"Provided input \"{thirdInput}\" is not a number");
            } else
            {
                Console.WriteLine($"Third entered number is {thirdNumber}");
            }


            //Handle fourth entry
            Console.WriteLine("Enter the Fourth number: ");
            string fourthInput = Console.ReadLine();

            int fourthNumber;
            bool parseFourthNumber = int.TryParse(fourthInput, out fourthNumber);

            if(!parseFourthNumber) {
                Console.WriteLine($"Provided input \"{fourthInput}\" is not a number.");
            } else
            {
                Console.WriteLine($"Fourth entered number is {fourthNumber}");
            }

            //Calculate average of the four entered numbers
            float average;
            average = (firstNumber + secondNumber + thirdNumber + (float)fourthNumber) / 4;

            Console.WriteLine($"Average of {firstNumber}, {secondNumber}, {thirdNumber} and {fourthNumber} is {average}.");
        }
    }
}
