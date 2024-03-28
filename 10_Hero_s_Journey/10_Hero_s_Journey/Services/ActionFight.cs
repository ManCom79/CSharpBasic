namespace Services
{
    public class ActionFight
    {
        public static void Fight(GameCharacter gameCharacter, int eventValue) {
            Console.WriteLine("Fighting!!!");
            Random rnd = new Random();

            if (gameCharacter.Strength >= rnd.Next(0, 10))
            {
                Console.WriteLine("You won the fight!\n");
            } else
            {
                Console.WriteLine("You lost the fight.\n");
                Console.WriteLine($"Your health was {gameCharacter.Health}.");
                gameCharacter.Health += eventValue;
                Console.WriteLine($"Your health now is {gameCharacter.Health}.");
            }
        }
    }
}
