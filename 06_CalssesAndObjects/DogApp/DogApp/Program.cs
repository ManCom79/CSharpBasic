namespace DogApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int userNumber;

            Console.WriteLine($"What is the dog's name?");
            string userInputDogName = Console.ReadLine();

            Console.WriteLine($"What breed is the dog?");
            string userInputDogBreed = Console.ReadLine();

            Console.WriteLine($"What color is the dog?");
            string userInputDogColor = Console.ReadLine();

            while (true)
            {
                Console.WriteLine($"Please enter number 1, 2 or 3");
                string userInput = Console.ReadLine();

                if(!int.TryParse(userInput, out userNumber))
                {
                    Console.WriteLine("You have not entered a number.");
                    continue;
                }

                if (userNumber < 1 || userNumber > 3)
                {
                    Console.WriteLine("Number you entered was not 1, 2 or 3.");
                    continue;
                }

                break;  
            }

            Dog dog = new Dog(userInputDogName, userInputDogBreed, userInputDogColor);

            Console.WriteLine($"{dog.Name} is a dog of {dog.Breed} breed. {dog.Name} is {dog.Color}.");

            switch (userNumber)
            {
                case 1:
                    {
                        Console.WriteLine(dog.Eat());
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine(dog.Play());
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine(dog.ChaseTail());
                        break;
                    }
            }
        }
    }
}
