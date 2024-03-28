namespace Services
{
    public class GameCharacter
    {
        public string Name { get; set; }
        public string Race { get; set; }
        public string CharacterClass { get; set; }
        public int Health {  get; set; }
        public int Strength {  get; set; }
        public int Agility { get; set; }

        public GameCharacter(string name, string race, string characterClass, int health, int strength, int agility)
        {
            Name = name;
            Race = race;
            CharacterClass = characterClass;
            Health = health;
            Strength = strength;
            Agility = agility;
        }
    }
}
