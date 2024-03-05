namespace SumOfEvenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[6];
            int sum = 0;
            int userInteger;
            int countEntries = 0;

            while (true)
            {
                Console.WriteLine($"Please enter number {countEntries + 1}");
                string userEntry = Console.ReadLine();

                if(!int.TryParse(userEntry, out userInteger))
                {
                    Console.WriteLine("Invalid entry. Please enter a number!");
                    continue;
                }

                numbers[countEntries] = userInteger;
                countEntries++;

                if(countEntries == 6)
                {
                    break;
                }
            }

            foreach(int number in numbers)
            {
                if(number % 2 == 0) {
                    sum += number;
                }
            }

            Console.WriteLine($"The sum of all even numbers in the array is {sum}.");
        }
    }
}
