namespace DogApp
{
    public class Dog
    {
        public string Name { get; set; }
        public string Breed { get; set; }
        public string Color { get; set; }

        public Dog(string name, string breed, string color) {
            Name = name;
            Breed = breed;
            Color = color;
        }

        public string Eat()
        {
            string message = $"{Name} is now eating.";
            return message;
        }

        public string Play()
        {
            string message = $"{Name} is now playing.";
            return message;
        }

        public string ChaseTail()
        {
            string message = $"{Name} is now chasing its tail.";
            return message;
        }
    }
}
