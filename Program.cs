using HomeTaskFor24._10._25._14oclock;

public class Card
{
    private long CardNumber;
    private string OwnerName;
    private double Balance;
    private decimal AnnualFee;
    private double cashback;


    public Card(string ownerName, double balance)
    {
        Console.WriteLine(Balance);
        Console.WriteLine(cashback);
        OwnerName = ownerName;
        //Console.WriteLine(ownerName);
        
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
        Card userCard = new Card("Ferhad Guluzade", 3000);
        userCard.CardNumber = 2828290102827896;
        userCard.OwnerName = "Ferhad Guluzade";
        userCard.AnnualFee=100;
        Console.WriteLine("Balance: "+ userCard.Balance);


        PremiumCard premiumCard = new PremiumCard("Ferhad Guluzade", 3000);
   

        BuisinessCard buisinessCard = new BuisinessCard("Ferhad Guluzade", 3000);


        StandartCard standartCard = new StandartCard("Ferhad Guluzade", 3000);
    }



}
