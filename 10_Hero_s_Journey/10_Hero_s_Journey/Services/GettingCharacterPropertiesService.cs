namespace Services
{
    public class GettingCharacterPropertiesService
    {
        public static GameCharacter GettingCharacterProperties(List<Dictionary<string, int>> races, List<Dictionary<string, int>> classes)
        {

            string characterName = "";
            string characterRace = "";
            string characterClass = "";
            int characterRaceIndex = 0;
            int characterClassIndex = 0;

            while (true)
            {
                Console.Write($"\nPlease enter your characters' name: ");
                string inputCharacterName = Console.ReadLine();

                inputCharacterName = inputCharacterName.Trim();

                if (inputCharacterName.Length > 0 && inputCharacterName.Length < 20)
                {
                    Console.WriteLine($"\nYour character name is: {inputCharacterName}");
                    characterName = inputCharacterName;
                    break;
                }
                else
                {
                    Console.WriteLine(" Please use minimum 1 and maximum 20 characters for name,");
                    continue;
                }
            }

            while (true)
            {
                Console.WriteLine($"\nPlease select characters' race (1, 2 or 3):\n1) Dwarf:\n * Has Health 100\n * Has Strength 6\n * Has Agility 2\n2) Elf:\n* Has Health 60\n* Has Strength 4\n* Has Agility 6\n3) Human:\n * Has Health 80\n * Has Strength 5\n * Has Agility 4\"");
                string userCharacterRace = Console.ReadLine();

                switch (userCharacterRace)
                {
                    case "1":
                        {
                            Console.WriteLine("You selected Dwarf");
                            characterRaceIndex = 0;
                            characterRace = "Dwarf";
                            break;
                        }
                    case "2":
                        {
                            Console.WriteLine("You selected Elf");
                            characterRaceIndex = 1;
                            characterRace = "Elf";
                            break;
                        }
                    case "3":
                        {
                            Console.WriteLine("You selected Human");
                            characterRaceIndex = 2;
                            characterRace = "Human";
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Please select 1, 2 or 3.");
                            continue;
                        }
                }
                break;
            };

            while (true)
            {
                Console.WriteLine($"\nPlease select characters' class (1, 2 or 3):\n1) Warrior:\n * Health 20\n * Agility -1\n2) Rogue:\n* Health -20\n* Agility 1\n3) Mage:\n * Health 20\n * Agility -1\"");
                string userCharacterClass = Console.ReadLine();

                switch (userCharacterClass)
                {
                    case "1":
                        {
                            Console.WriteLine("You selected Warrior");
                            characterClassIndex = 0;
                            characterClass = "Warrior";
                            break;
                        }
                    case "2":
                        {
                            Console.WriteLine("You selected Rogue");
                            characterClassIndex = 1;
                            characterClass = "Rogue";
                            break;
                        }
                    case "3":
                        {
                            Console.WriteLine("You selected Mage");
                            characterClassIndex = 2;
                            characterClass = "Mage";
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Please select 1, 2 or 3.");
                            continue;
                        }
                }
                break;
            };

            int charRaceHealth = races[characterRaceIndex]["Health"];
            int charRaceStrength = races[characterRaceIndex]["Strength"];
            int charRaceAgility = races[characterRaceIndex]["Agility"];

            int charClassHealth = classes[characterClassIndex]["Health"];
            int charClassStrength = 0;
            int charClassAgility = 0;

            bool classStrengthSuccess = classes[characterClassIndex].TryGetValue("Strength", out charClassStrength);
            bool classAgilitySuccess = classes[characterClassIndex].TryGetValue("Agility", out charClassAgility);

            int charOverallHealth = charRaceHealth + charClassHealth;
            int charOverallStrength = charRaceStrength + charClassStrength;
            int charOverallAgility = charRaceAgility + charClassAgility;

            GameCharacter player = new GameCharacter(characterName, characterRace, characterClass, charOverallHealth, charOverallStrength, charOverallAgility);

            return player;
        }
    }
}
