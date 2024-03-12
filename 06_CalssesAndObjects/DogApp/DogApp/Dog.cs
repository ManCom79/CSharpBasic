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
            return $"{Name} is now eating.";
        }

        public string Play()
        {
            return $"{Name} is now playing.";
        }

        public string ChaseTail()
        {
            return $"{Name} is now chasing its tail.";
        }
    }
}
