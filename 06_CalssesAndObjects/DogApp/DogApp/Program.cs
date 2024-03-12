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
                Console.WriteLine($"Please enter number");
                string userInput = Console.ReadLine();

                if(!int.TryParse(userInput, out userNumber))
                {
                    Console.WriteLine("Please enter a number");
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
