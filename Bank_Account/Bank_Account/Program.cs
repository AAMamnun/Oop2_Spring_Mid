using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
    class Program
    {
        static void Main(string[] args)
        {

            Account acc1 = new SuperSavings("Mim", "111", 5000f);
            acc1.Withdraw(80);
            acc1.ShowInfo();

            Account acc2 = new Overdraft("Mamnun", "222", 1000f, 1000);
            acc2.Transfer(acc1, 4000);
            acc2.ShowInfo();

        }
    }
}
