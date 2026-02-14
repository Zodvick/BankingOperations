namespace BankCredit;

public class CreditCard : Card
{
    private decimal _creditLimit;
    private decimal _creditBalance;

    public CreditCard(decimal balance, decimal creditLimit) : base(balance)
    {
        _creditLimit = creditLimit;
        _creditBalance = creditLimit;
    }

    public override decimal Pay(decimal amount)
    {
        if(amount > (Balance + _creditBalance)) return 0;
        if (amount > Balance)
        {
            decimal fromCredit = amount - Balance;
            _balance = 0;
            _creditBalance -= fromCredit;
        }
        else
        {
            if(amount <= Balance)
            {
                _balance -= amount;
            }
        }
        return amount;
    }
    
    public override bool Deposit(decimal amount)
    {
            decimal toRepay = _creditLimit - _creditBalance;
            if (amount <= toRepay)
            {
                _creditBalance += amount;
            }
            else
            {
                    _creditBalance = _creditLimit;
                    base.Deposit(amount - toRepay);
                
            }
            return true;
    }
}