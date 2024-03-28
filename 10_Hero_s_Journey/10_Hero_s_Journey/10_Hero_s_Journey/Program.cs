using Services;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace _10_Hero_s_Journey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] emails = ["a", "player_1@game.com", "player_2@game.com"];
            string[] passwords = ["a", "play1", "play2"];

            Dictionary<string, int> dwarf = new Dictionary<string, int> (){ { "Health", 100}, { "Strength", 6 }, { "Agility", 2 } };
            Dictionary<string, int> elf = new Dictionary<string, int> (){ { "Health", 60}, { "Strength", 4 }, { "Agility", 6 } };
            Dictionary<string, int> human = new Dictionary<string, int> (){ { "Health", 80}, { "Strength", 5 }, { "Agility", 4 } };
            List<Dictionary<string, int>> races = new List<Dictionary<string, int>> () { dwarf, elf, human };

            Dictionary<string, int> warrior = new Dictionary<string, int> (){ { "Health", 20}, { "Agility", -1 } };
            Dictionary<string, int> rogue = new Dictionary<string, int> (){ { "Health", -20}, { "Agility", 1 } };
            Dictionary<string, int> mage = new Dictionary<string, int> (){ { "Health", 20}, { "Strength", -1 } };
            List<Dictionary<string, int>> classes = new List<Dictionary<string, int>> () { warrior, rogue, mage };

            string loggedUser = UserLoginService.UserLogin(emails, passwords);

            GameCharacter gameCharacter = GettingCharacterPropertiesService.GettingCharacterProperties(races, classes);

            //Console.WriteLine($"Printing from main: {gameCharacter.Name}, {gameCharacter.Race}, {gameCharacter.CharacterClass}, {gameCharacter.Health}, {gameCharacter.Strength}, {gameCharacter.Agility}");

        }
    }
}
