using Services;

namespace _10_Hero_s_Journey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] emails = ["player_1@game.com", "player_2@game.com"];
            string[] passwords = ["play1", "play2"];

            UserLoginService.UserLogin(emails, passwords);

        }
    }
}
