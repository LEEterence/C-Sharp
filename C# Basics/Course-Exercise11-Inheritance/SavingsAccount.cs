/*
 * The only difference between a checking account and savings account is that this bank has a “bonus bucks” program when you deposit money to a savings account. 
For every $100 deposited in a single deposit transaction to a savings account, the bank will deposit $1 in bonus bucks to the account (Hint: Use Math.Floor(number) to round a number down to the nearest whole number).

Saving account ONLY overrides the Deposit Method
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Course_Exercise11
{
    class SavingsAccount : Account
    {
        // Fields
        private double value;
        private double bonusBucks;

        // Constructors
        public SavingsAccount() : base()
        {
            balance = 0;
        }
        public SavingsAccount(double balance) : base(balance)
        {
            this.balance = balance;
        }
        //Methods
        public void SavingDeposit()
        {
            Console.WriteLine();
            CheckBalance();
            Console.Write("Enter the amount to deposit: ");
            value = Convert.ToDouble(Console.ReadLine());

            if(value >= 100)
            {
                bonusBucks = Math.Floor(value);
                bonusBucks /= 100;
                value += bonusBucks;
                DepositMoney(value);
                Console.WriteLine($"You have earned ${bonusBucks} of bonus bucks!");
            }
            else
            {
                DepositMoney(value);
            }
            Console.WriteLine($"A total of ${value} has been deposited to your account.");
            CheckBalance();

            //Console.WriteLine($"Your current balance is {balance}.\n");
        }

        public void SavingWithdraw()
        {
            Console.WriteLine();
            CheckBalance();
            Console.Write("Enter the amount to withdraw: ");
            value = Convert.ToDouble(Console.ReadLine());

            //if (balance >= value)
            //{
            //    Console.WriteLine($"A total of ${value} has been withdrawn from your account.");
            //    //Console.WriteLine($"Your current balance is {balance}.\n");
            //    WithdrawMoney(value);
            //    CheckBalance();
            //}
            //else
            //{
            //    Console.WriteLine("You don't have enough funds to withdraw that amount!");
            //}
        }
    }
}
