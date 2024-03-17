using ATM_app.Models;

namespace ATM_app
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long customerCardNumber;
            int customerPin;
            bool userFound = false;
            bool restrtApp = false;

            Customer customer1 = new Customer("Bob", "Bobsky", 1234123412341234, 123, 1000);
            Customer customer2 = new Customer("Jane", "Doe", 1111222233334444, 111, 1500);
            Customer[] customers = new Customer[] { customer1, customer2 };

            Console.WriteLine("Welcome to the ATM app");

            while (true) {
                Console.WriteLine("Please enter card number in format xxxx-xxxx-xxxx-xxxx:");
                string cardNumberInput = Console.ReadLine();

                cardNumberInput = cardNumberInput.Trim();

                if (cardNumberInput.Length != 19 )
                {
                    Console.WriteLine("Invalid card number");
                    continue;
                }
                cardNumberInput = cardNumberInput.Replace("-", "");

                if (!long.TryParse(cardNumberInput, out customerCardNumber))
                {
                    Console.WriteLine("Invalid card number");
                    continue;
                }

                int counter = 0;
                foreach (Customer customer in customers)
                {
                    if (customerCardNumber == customer.CredicCardNumber)
                    {
                        counter += 1;
                    }
                }

                if (counter == 0)
                {
                    Console.WriteLine("Credit Card with that number does not exist!\n");
                    continue;
                }
                
                foreach (Customer customer in customers)
                {
                    if (customerCardNumber == customer.CredicCardNumber)
                    {
                        while (true)
                        {
                            Console.WriteLine("Please enter pin:");
                            string customerPinInput = Console.ReadLine();

                            {
                                if (!int.TryParse(customerPinInput, out customerPin)) {
                                    Console.WriteLine("Incorrect pin.");
                                    continue;
                                }
                                if (customerPin == customer.CreditCardPin) {
                                    userFound = true;
                                    break;
                                };
                            }
                        }
                        Console.WriteLine($"\nWelcome {customer.FirstName} {customer.LastName}");
                        while (true)
                        {
                            if (restrtApp == true)
                            {
                                break;
                            }
                            
                            string selectedAction = SelectAction();
                            switch (selectedAction)
                            {
                                case "a":
                                    {
                                        ShowBalance(customer);
                                        continue;
                                    }
                                case "b":
                                    {
                                        customer.Balance = CashWithdrawal(customer);
                                        break;
                                    }
                                case "c":
                                    {
                                        customer.Balance = CashDeposit(customer);
                                        continue;
                                    }
                                case "d":
                                    {
                                        Console.WriteLine("Thank you for using the ATM app.");
                                        restrtApp = true;
                                        continue;
                                    }
                            }
                        }
                    }
                }

                if (restrtApp == true)
                {
                    restrtApp = false;
                    continue;
                }

                if (userFound)
                {
                    break;
                }
                continue;           
            }
        }

        public static string SelectAction() { 
            while (true)
            {
                Console.WriteLine($"\nWhat would you like to do?\na. Check Balance\nb. Cash Withdrawal\nc. Cash Deposit\nd. Exit");
                string actionSelection = Console.ReadLine();

                if (actionSelection != "a" && actionSelection != "b" && actionSelection != "c" && actionSelection != "d")
                {
                    Console.WriteLine("Invalid action selection!");
                    continue;
                }

                return actionSelection;
            }
        }

        public static int ShowBalance(Customer user)
        {
            int balance = user.Balance;
            Console.WriteLine($"\nAccount balance is ${balance}.");
            return balance;
        }


        public static int CashWithdrawal(Customer customer)
        {
            int balance = customer.Balance;
            int withdraw;

            while (true)
            {
                Console.WriteLine("\nHow much money would you like to withdraw?\n***Please insert zero if you do not want to make a withdraw.***");
                string withdrawInput = Console.ReadLine();

                if (!int.TryParse(withdrawInput, out withdraw))
                {
                    Console.WriteLine("Invalid input");
                    continue;
                }

                if (withdraw > balance)
                {
                    Console.WriteLine($"Sorry, you do not have sufficient funds. Your balance is ${balance}.");
                    continue;
                }

                if (withdraw < 0)
                {
                    Console.WriteLine("Withdrawal cannot be less than zero");
                    continue;
                }

                balance -= withdraw;

                Console.WriteLine($"You have successfully withdrawn ${withdraw}. Your balance is now %{balance}.");
                break;

            }

            return balance;
        }

        public static int CashDeposit(Customer customer)
        {
            int balance = customer.Balance;
            int deposit;

            while (true)
            {
                Console.WriteLine("\nHow much money would you like to deposit?\n***Please insert zero of you do not want to make a deposit.***");
                string depositInput = Console.ReadLine();

                if (!int.TryParse(depositInput, out deposit))
                {
                    Console.WriteLine("Invalid input");
                    continue;
                }

                if (deposit < 0)
                {
                    Console.WriteLine("Deposit cannot be less than zero");
                    continue;
                }

                balance += deposit;

                Console.WriteLine($"You have successfully deposited ${deposit}. Your balance is now %{balance}.");
                break;

            }

            return balance;
        }
    }
}