namespace Bank200.Data
{
    public class SystemDB
    {      
        public List<string> currentAccount;
        private int _balance;
        private int _overdraft;
        private int _customerNumber;
        public SystemDB(int customerNumber, int balance, int overdraft)
        {
            SavingAccount(customerNumber = 1, balance = 2000);
            SavingAccount(customerNumber = 2, balance = 5000);
            CurrentAccount(customerNumber = 3, balance = 1000, overdraft = 10000);
            CurrentAccount(customerNumber = 4, balance = 5000, overdraft = 10000);
            _balance = balance;
            _overdraft = overdraft;
            _customerNumber = customerNumber;
        }

        public void CurrentAccount(int value1, int value2, int value3)
        {
            
        }

        public void SavingAccount(int value1, int value2)
        {
            
        }
    }
}
