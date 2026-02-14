namespace BankCredit
{
  class Program
  {
    static void Main(string[] args)
    {
        Card card = new CreditCard(100, 100);
        card.Pay(150);
        card.Deposit(165);
        Console.WriteLine(card.Balance);
        Console.ReadKey();
    }
  }
}