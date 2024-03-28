namespace Services
{
    public class GameEngine
    {
        public static void Engine(List<int> availableEvents, GameCharacter gameCharacter)
        {
            int selectedEventId = GetRandomEventService.GetEvent(availableEvents);

            KeyValuePair<string, int> currentEvent = EventService.Event(selectedEventId);

            Console.WriteLine("*********************************************************");
            Console.WriteLine($"\n{currentEvent.Key}");
            SelectGameCharacterAction.CharacterAction(gameCharacter, currentEvent.Value);
        }

        public static bool PlayAgain(bool playAgain)
        {
            while (true)
            {
                Console.WriteLine("Play again (Yes/No)?");
                string continuePlay = Console.ReadLine();

                if (continuePlay.ToLower() == "y")
                {
                    playAgain = true;
                    return playAgain;
                } else if (continuePlay.ToLower() == "n")
                {
                    playAgain = false;
                    return playAgain;
                } else
                {
                    Console.WriteLine("Please type \"y\" ot \"n\".");
                    continue;
                }
            }
        }
    }
}
