namespace Services
{
    public class UserLoginService
    {
        public static void UserLogin(string[] emails, string[] passwords)
        {
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
                        else
                        {
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
                            if (!emails.Contains(userEnteredEmail))
                            {
                                logInAttemptCounter++;
                                Console.WriteLine("Not registered user!");
                                break;
                            }
                            else
                            {
                                while (true)
                                {
                                    if (logInAttemptCounter < 5)
                                    {
                                        int emailIndex = Array.IndexOf(emails, userEnteredEmail);

                                        Console.Write("Enter password: ");
                                        string userEnteredPassword = Console.ReadLine();

                                        if (passwords[emailIndex] == userEnteredPassword)
                                        {
                                            Console.WriteLine("Welcome!");
                                            userLogged = true;
                                            break;
                                        }
                                        else
                                        {
                                            logInAttemptCounter++;
                                            if (logInAttemptCounter == 5)
                                            {
                                                break;
                                            }
                                            else
                                            {
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
