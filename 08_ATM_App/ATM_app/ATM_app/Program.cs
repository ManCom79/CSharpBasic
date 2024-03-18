using ATM_app.Models;

namespace ATM_app
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer("Bob", "Bobsky", 1234123412341234, 123, 1000);
            Customer customer2 = new Customer("Jane", "Doe", 1111222233334444, 111, 1500);
            Customer[] customers = new Customer[] { customer1, customer2 };

            Console.WriteLine("Welcome to the ATM app");

            while (true)
            {
                Console.WriteLine("Please select what you would like to do:\n1. Checkout your account\n2. Register new Credit Card");
                string customerAction = Console.ReadLine();

                if (customerAction == "1")
                {
                    MainAccountControl(customers);
                    break;
                }
                else if (customerAction == "2")
                {
                    AddCreditCard(customers);
                    continue;
                } else
                {
                    Console.WriteLine("\nInvalid input.\n");
                    continue;
                }
            }
        }

        public static Customer[] AddCreditCard(Customer[] customers)
        {
            Console.WriteLine("Please enter first name:\n");
            string enteredFirstName = Console.ReadLine();

            Console.WriteLine("Please enter last name:\n");
            string enteredLastName = Console.ReadLine();

            int num1 = new Random().Next(1000, 9999);
            int num2 = new Random().Next(1000, 9999);
            int num3 = new Random().Next(1000, 9999);
            int num4 = new Random().Next(1000, 9999);
            string stringCardNumber = $"{num1}{num2}{num3}{num4}";
            long.TryParse(stringCardNumber, out long cardNumber);
            Console.WriteLine($"Card number is: {num1}-{num2}-{num3}-{num4}\n");

            int pin = new Random().Next(100,999);
            Console.WriteLine($"The pin of the card is: {pin}\n");

            Console.WriteLine($"Created card {num1}-{num2}-{num3}-{num4} is created with initial balance of $0.");

            Customer customer3 = new Customer() { FirstName = enteredFirstName, LastName = enteredLastName, CredicCardNumber = cardNumber, CreditCardPin = pin, Balance = 0 };
            customers[customers.Length - 1] = customer3;

            foreach ( Customer customer in customers )
            {
                Console.WriteLine(customer.CredicCardNumber);
            }
            return customers;
         }
        public static void MainAccountControl(Customer[] customers)
        {
            long customerCardNumber;
            int customerPin;
            bool userFound = false;
            bool restrtApp = false;

            Console.WriteLine("Welcome to the ATM app");

            while (true)
            {
                Console.WriteLine("Please enter card number in format xxxx-xxxx-xxxx-xxxx:");
                string cardNumberInput = Console.ReadLine();

                cardNumberInput = cardNumberInput.Trim();

                if (cardNumberInput.Length != 19)
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
                                if (!int.TryParse(customerPinInput, out customerPin))
                                {
                                    Console.WriteLine("Incorrect pin.");
                                    continue;
                                }
                                if (customerPin == customer.CreditCardPin)
                                {
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
        public static string SelectAction()
        {
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

                Console.WriteLine($"You have successfully withdrawn ${withdraw}. Your balance is now ${balance}.");
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

                Console.WriteLine($"You have successfully deposited ${deposit}. Your balance is now ${balance}.");
                break;

            }

            return balance;
        }
    }
}