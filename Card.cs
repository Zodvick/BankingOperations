namespace BankCredit;

public class Card
{
    protected decimal _balance;

    public Card(decimal balance)
    {
        _balance = balance;
    }
    
    public decimal Balance => _balance;

    public virtual decimal Pay(decimal amount)
    {
        if (_balance >= amount)
        {
            _balance -= amount;
        }
        return amount;
    }

    public virtual bool Deposit(decimal amount)
    {
        if (amount == 0)
        {
            return false;
        }
        else
        {
            _balance += amount;
            return true;
        }
        
    }
}