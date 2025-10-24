using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTaskFor24._10._25._14oclock
{
    internal class PremiumCard: Card
    {
        private double cashback;
        public PremiumCard(string ownerName, double balance) : base(ownerName, balance)
        {

        }
        public override void Withdraw(double amount)
        {
            while (amount <= 5000)
            {
                cashback = amount * 3 / 100;
                amount += cashback;
                Console.WriteLine("Cashback: " + cashback);
                Console.WriteLine("Amount: "+ amount);
            }
            
        }



    }
}
