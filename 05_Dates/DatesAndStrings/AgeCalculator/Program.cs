namespace AgeCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int day;
            int month;
            int year;
            bool leapYear;
            DateTime birthday;

            while (true)
            {
                Console.WriteLine("Please enter the year when you were born in numerical format (ex: 1979): ");
                string inputYear = Console.ReadLine();

                if(!int.TryParse(inputYear, out year))
                {
                    Console.WriteLine($"Invalid input {inputYear}.");
                    continue;
                } else
                {   
                    if (year > 2024)
                    {
                        Console.WriteLine($"Impossible! Year {year} is in the future!");
                        continue;
                    }
                    if (DateTime.IsLeapYear(year))
                    {
                        leapYear = true;
                        Console.WriteLine($"The year {year} is a leap year.");
                    } else
                    {
                        leapYear = false;
                        Console.WriteLine($"The year {year} is not a leap year.");
                    }
                }
                break;
            }

            while (true)
            {
                Console.WriteLine("Please enter the month when you were born in numerical format (ex: 8 for August): ");
                string inputMonth = Console.ReadLine();

                if(!int.TryParse(inputMonth, out month))
                {
                    Console.WriteLine($"Invalid input {inputMonth}.");
                    continue;
                }

                if (month < 1 || month > 12)
                {
                    Console.WriteLine($"Entered value for month is {month}. Please enter value between 1 and 12.");
                    continue;
                } else
                {
                    Console.WriteLine($"Entered value for month is {month}");
                    break;
                }
            }


            while (true)
            {
                Console.WriteLine("Please enter the day of month when you were born in numerical format (ex: 7 for 7th day of month): ");
                string inputDay = Console.ReadLine();

                if (!int.TryParse(inputDay, out day)) {
                    Console.WriteLine($"Invalid input {inputDay}.");
                    continue;
                } else
                {
                    switch (month)
                    {
                        case 1:
                        case 3:
                        case 5:
                        case 7:
                        case 8:
                        case 10:
                        case 12:
                            {
                                if (day < 0 || day > 31)
                                {
                                    Console.WriteLine("Value must be between 1 and 31:");
                                    continue;
                                }
                                else
                                {
                                    Console.WriteLine($"You were born on {day}.{month}.{year}.");
                                    break;
                                }
                            }
                        case 4:
                        case 6:
                        case 9:
                        case 11:
                            {
                                if (day < 0 || day > 30)
                                {
                                    Console.WriteLine("Value must be between 1 and 31:");
                                    continue;
                                }
                                else
                                {
                                    Console.WriteLine($"You were born on {day}.{month}.{year}.");
                                    break;
                                }
                            }
                        case 2:
                            {
                                if (leapYear)
                                {
                                    if (day < 0 || day > 29)
                                    {
                                        Console.WriteLine($"Value must be between 1 and 29");
                                        continue;
                                    }
                                }
                                else
                                {
                                    if (day < 0 || day > 28)
                                    {
                                        Console.WriteLine($"Value must be between 1 and 28");
                                        continue;
                                    }
                                }
                                Console.WriteLine($"You were born on {day}.{month}.{year}.");
                                break;
                            }
                    }
                }

                birthday = new DateTime(year, month, day);
                if (birthday > DateTime.Now)
                {
                    Console.WriteLine($"Invalid input {birthday} - seems like a date in future.");
                }
                else
                {
                    if (birthday.Day == DateTime.Now.Day && birthday.Month == DateTime.Now.Month)
                    {
                        Console.WriteLine("HAPPY BIRTHDAY!!!");
                    }
                    int age = CalculateAge(birthday);
                    Console.WriteLine($"You are {age} year(s) old.");
                }

                break;
            }

        }

        public static int CalculateAge(DateTime dateOfBirth)
        {
            DateTime currentDate = DateTime.Today;
            int age = currentDate.Year - dateOfBirth.Year;
            if (dateOfBirth > currentDate.AddYears(-age))
            {
                age--;
            }
            return age;
        }
    }
}
