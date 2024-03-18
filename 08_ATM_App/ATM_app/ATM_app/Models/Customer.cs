namespace ATM_app.Models
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public long CredicCardNumber { get; set; }

        private int _CreditCardPin;
        public int CreditCardPin { 
            get => _CreditCardPin; 
            set => _CreditCardPin = value; 
        }

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
