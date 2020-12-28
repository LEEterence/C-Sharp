//Create an Account class that can store a balance and has methods for depositing and withdrawing money. We only need to inherit from this class, not instantiate an object from it, so make it an abstract class.

using System;
using System.Collections.Generic;
using System.Text;

namespace Course_Exercise11
{
    // Since we are inheriting from this class no instances of objects should be created here
    abstract class Account
    {
        protected double balance;

        public Account()
        {

        }
        public Account(double balance)
        {
            this.balance = 0.00;
        }
        public virtual void DepositMoney(double deposit)
        {
            balance += deposit;
            Console.WriteLine($"A total of ${deposit.ToString("F")} has been deposited to your account.");
            CheckBalance();
        }
        protected void WithdrawMoney(double withdraw)
        {
            if (balance >= withdraw)
            {
                //WithdrawMoney(withdraw);
                balance -= withdraw;
                Console.WriteLine($"A total of ${withdraw.ToString("F")} has been withdrawn from your account.");
                CheckBalance();
            }
            else
            {
                Console.WriteLine("You don't have enough funds to withdraw that amount!");
                CheckBalance();
            }
        }

        public void CheckBalance()
        {
            Console.WriteLine($"Your current balance is ${balance.ToString("F")}.\n");
        }
    }
}
