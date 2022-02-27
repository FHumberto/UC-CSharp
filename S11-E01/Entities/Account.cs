using S11_E01.Entities.Exceptions;

namespace S11_E01.Entities
{
    public class Account
    {
        public int Number { get; private set; }
        public string? Holder { get; private set; }
        public double Balance { get; private set; }
        public double WithdrawLimit { get; private set; }

        public Account()
        {
        }

        public Account(int number,string? holder,double balance,double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double ammount)
        {
            Balance += ammount;
        }

        public void Withdraw(double ammount)
        {
            if(ammount > WithdrawLimit)
            {
                throw new DomainException("The amount exceeds withdraw limit");
            }
            if(Balance < ammount)
            {
                throw new DomainException("Not enough balance");
            }
            Balance -= ammount;
        }
    }
}