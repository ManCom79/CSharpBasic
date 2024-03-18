namespace ATM_app.Models
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public long CredicCardNumber { get; set; }

        public int CreditCardPin { get; set; }

        public int Balance { get; set; }

        //public CreditCard CreditCard { get; set; }

        public Customer(string firstName, string lastName, long creditCardNumber, int creditCardPin, int balance)
        {
            FirstName = firstName;
            LastName = lastName;
            CredicCardNumber = creditCardNumber;
            CreditCardPin = creditCardPin;
            Balance = balance;
        }

        public Customer() { }
    }   
}
