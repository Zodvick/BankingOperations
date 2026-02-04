namespace BankCredit;

public class Card
{
    private int _creditLimit;
    private bool _usedCredit;

    public Card(int creditLimit, bool usedCredit)
    {
        _creditLimit = creditLimit;
        _usedCredit = usedCredit;
    }
    
    public bool AvailableCredit
    {
        get { return _usedCredit; }
    }

    public void TakeCredit(int amount)
    {
        _usedCredit = true;
        _creditLimit -= amount;
    }

    public void PayCredit(int amount)
    {
        _usedCredit = false;
        _creditLimit += amount;
    }
}