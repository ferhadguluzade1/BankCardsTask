using HomeTaskFor24._10._25._14oclock;

public class Card
{
    private long CardNumber;
    private string OwnerName;
    private double Balance;
    private decimal AnnualFee;
    private double cashback;


    public Card(string ownerName)
    {
        Console.WriteLine(Balance);
        Console.WriteLine(cashback);
        OwnerName = ownerName;
        
    }

    public void Deposit(double amount)
    {
        Balance += amount;
    }

    public virtual void Withdraw(double amount)
    {
        if (Balance < amount)
        {
            Console.WriteLine("Insufficient balance");
            return;
        }
        Balance -= amount;

        
    }
    public static void Main()
    {
        Card userCard = new Card("Ferhad Guluzade");
        userCard.CardNumber = 2828290102827896;
        userCard.OwnerName = "Ferhad Guluzade";
        userCard.AnnualFee=100;
        Console.WriteLine("Balance: "+ userCard.Balance);


        PremiumCard premiumCard = new PremiumCard();
   

        BuisinessCard buisinessCard = new BuisinessCard();


        StandartCard standartCard = new StandartCard();
    }



}
