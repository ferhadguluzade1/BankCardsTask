using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTaskFor24._10._25._14oclock
{
    internal class StandartCard :Card
    {
        private double cashback;
        public StandartCard(string ownerName, double balance) :base(ownerName, balance)
        {
            
        }

        public override void Withdraw(double amount)
        {
            cashback = amount * 1 / 100;
            amount += cashback;
            Console.WriteLine("Cashback: " + cashback);
            Console.WriteLine("Amount: " + amount);
        }
        



    }
}
