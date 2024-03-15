namespace NumberStat
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Please enter a number:");
                string userInput = Console.ReadLine();
                string continueChoise;

                if (decimal.TryParse(userInput, out decimal enteredNumberInteger))
                {
                    string result = NumberStats(userInput);
                    Console.WriteLine($"{result}");
                } else
                {
                    Console.WriteLine("Invalid input.");
                    continue;
                }

                while (true)
                {
                    Console.WriteLine("Would you like to enter another numner (y/n)?");
                    continueChoise = Console.ReadLine();

                    if (continueChoise.ToLower() == "y")
                    {
                        break;
                    }
                    if (continueChoise != "y" && continueChoise != "n")
                    {
                        Console.WriteLine("Please enter Y or N.");
                        continue;
                    }
                }

                if (continueChoise.ToLower() == "n")
                {
                    break;
                }
                
            }
                
        }

        public static string NumberStats(string number)
        {
            string numberSign;
            string numberType;
            string numberParity;

            //int inputNumberInteger;
            decimal inputNumberDecimal;

            if (number.Contains(".") || number.Contains(","))
            {
                numberType = "decimal";

            }
            else
            {
                //int.TryParse(number, out inputNumberInteger);
                numberType = "integer";
            }

            decimal.TryParse(number, out inputNumberDecimal);

            if (inputNumberDecimal >= 0)
            {
                numberSign = "positive";
            }
            else
            {
                numberSign = "negative";
            }

            if (inputNumberDecimal % 2 == 0)
            {
                numberParity = "even";
            }
            else
            {
                numberParity = "odd";
            }

            return $"Stats for number {number}: number\n- {numberSign}\n- {numberType}\n- {numberParity}";
        }
    }
}
