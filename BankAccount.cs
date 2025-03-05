using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//**Encapsulation Challenge**

//Create a `BankAccount` class where `balance` is a private field.Implement methods for `Deposit()` and `Withdraw()`, 
//ensuring that withdrawal is only allowed if there is a sufficient balance.Prevent direct modification of `balance` from outside the class.

namespace practise
{
    class BankAccount
    {
        private decimal balance=50000;
        public void HolderInfo()
        {
            string Name,AccNumber;
            Console.WriteLine("enter name ::");
            Name = Console.ReadLine();
            Console.WriteLine("enter acc numb ::");
            AccNumber = Console.ReadLine();
            Console.WriteLine("Balance::" + balance);
        }

        public void WithDraw()
        {
            decimal Amount;
            Console.Write("enter amount to withdraw:: ");
            Amount=Convert.ToDecimal(Console.ReadLine());
            if (Amount <= balance)
            {
                balance = balance - Amount;
                Console.WriteLine("total balance=" + balance);
            }
            else if (Amount > balance)
            {
                Console.WriteLine("unsufficient balance!! try again!!");
                WithDraw();
            }
        }

        public void Deposit()
        {
            decimal Amount;
            Console.WriteLine("enter amount to deposit ::");
            Amount = Convert.ToDecimal(Console.ReadLine());
            balance = balance + Amount;
            Console.WriteLine("total balance == " + balance);
        }
    }
}
