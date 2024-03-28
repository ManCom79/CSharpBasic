namespace Services
{
    public class ActionRunAway
    {
        public static void RunAway(GameCharacter gameCharacter, int eventValue) {
            Console.WriteLine("Running!!!");
            Random rnd = new Random();

            if (gameCharacter.Agility >= rnd.Next(0, 10))
            {
                Console.WriteLine("You ran away!\n");
            }
            else
            {
                Console.WriteLine("You got cought, you were not fast enough.\n");
                Console.WriteLine($"Your health was {gameCharacter.Health}.");
                gameCharacter.Health += eventValue;
                Console.WriteLine($"Your health now is {gameCharacter.Health}.");
            }
        }    
    }
}
