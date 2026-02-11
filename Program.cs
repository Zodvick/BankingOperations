namespace BankCredit
{
  class Program
  {
    static void Main(string[] args)
    {
        Card card = new CreditCard(2000, 10000);
        card.Pay(5000);
        card.Deposit(5500);
        Console.WriteLine(card.Balance);
        Console.ReadKey();
    }
  }
}