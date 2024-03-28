namespace _10_Hero_s_Journey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] emais = ["player_1@game.com", "player_2@game.com"];
            string[] passwords = ["play1", "play2"];

            while (true)
            {
                int logInAttemptCounter = 0;
                string loggedUserEmail = "";
                string loggedUserPassword = "";
                bool userLogged = false;

                Console.WriteLine("********** Welcome to \"Hero's Journey\" **********");
                while (true)
                {
                    Console.Write("Enter email to log in: ");
                    string userEnteredEmail = Console.ReadLine();

                    userEnteredEmail = userEnteredEmail.Trim();

                    if (userEnteredEmail.Length == 0)
                    {
                        Console.Write("No valid entry (empty string).");
                        continue;
                    }

                    while (true)
                    {
                        if (!userEnteredEmail.Contains("@"))
                        {
                            Console.WriteLine("Please enter valid email. You were missing the \"@\" symbol.");
                            break;
                        }
                        else {
                            string[] validateEmailPoint = userEnteredEmail.Split('@');
                            if (!validateEmailPoint[validateEmailPoint.Length - 1].Contains("."))
                            Console.WriteLine("Please enter valid email. You were missing the domain\"(.com or similar)\" .");
                            break;
                        }
                        
                    }

                    while (true)
                    {
                        if (logInAttemptCounter < 5)
                        {
                            if (!emais.Contains(userEnteredEmail))
                            {
                                logInAttemptCounter++;
                                Console.WriteLine("Not registered user!");
                                break;
                            } else { 
                                while(true)
                                {
                                    if (logInAttemptCounter < 5)
                                    {
                                        int emailIndex = Array.IndexOf(emais, userEnteredEmail);

                                        Console.Write("Enter password: ");
                                        string userEnteredPassword = Console.ReadLine();
                                                                                   
                                        if (passwords[emailIndex] == userEnteredPassword)
                                        {
                                            Console.WriteLine("Welcome!");
                                            userLogged = true;
                                            break;
                                        } else {
                                            logInAttemptCounter++;
                                            if (logInAttemptCounter == 5) { 
                                                break; 
                                            } else  {
                                                Console.WriteLine($"You have {5 - logInAttemptCounter} log-in attempts left!");
                                                continue;
                                            }
                                        }
                                    }

                                }
                            }                     
                        }
                        break;
                    }
                    break;
                }
            }
        }
    }
}
