
namespace Services
{
    public class SelectGameCharacterAction
    {
        public static void CharacterAction(GameCharacter gameCharacter, int eventValue)
        {
            while (true)
            {
                Console.WriteLine($"What will your hero do (1 or 2)?\n1. Fight\n2. Run Away\n");
                string selectedCharacterAction = Console.ReadLine();

                if ( selectedCharacterAction == "1")
                {
                    ActionFight.Fight(gameCharacter, eventValue);

                } else if ( selectedCharacterAction == "2")
                {
                    ActionRunAway.RunAway(gameCharacter, eventValue);
                } else
                {
                    Console.WriteLine("Please select 1 or 2");
                    continue;
                }
                break;
            }
        }
    }
}
