using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTaskFor24._10._25._14oclock
{
    internal class BuisinessCard :Card
    {
        private double cashback;
        public override void Withdraw(double amount)
        {
            cashback = (amount * 2 / 100) - 2;
            amount += cashback;
            Console.WriteLine(amount);
        }


    }
}
