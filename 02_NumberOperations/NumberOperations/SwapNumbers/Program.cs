namespace SwapNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number: ");
            string firstNumberInput = Console.ReadLine();

            Console.WriteLine("Enter the second number: ");
            string secondNumberInput = Console.ReadLine();

            string tempValueKeeper = firstNumberInput;
            
            firstNumberInput = secondNumberInput;
            secondNumberInput = tempValueKeeper;

            Console.WriteLine($"First number is: {firstNumberInput}");
            Console.WriteLine($"Second number is: {secondNumberInput}");

        }
    }
}
