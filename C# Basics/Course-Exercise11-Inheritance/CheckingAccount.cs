/*
 * DON'T initialize an object here 
 * CheckingAccount doesn't need ANY CODE
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Course_Exercise11
{
    class CheckingAccount : Account
    {
        // Fields
        private double value;

        // Constructors
        public CheckingAccount() : base()
        {
            balance = 0;
        }
        public CheckingAccount(double balance) : base(balance)
        {
            this.balance = balance;
        }
        //Methods
        public void DepositMoney()
        {
            Console.WriteLine();
            CheckBalance();
            Console.Write("Enter the amount to deposit: ");
            value = Convert.ToDouble(Console.ReadLine());
            DepositMoney(value);
        }
        
        public void CheckingWithdraw()
        {
            Console.WriteLine();
            CheckBalance();
            Console.Write("Enter the amount to withdraw: ");
            value = Convert.ToDouble(Console.ReadLine());

            //if (balance >= value)
            //{
            //    WithdrawMoney(value);
                
            //}
            //else
            //{
            //    Console.WriteLine("You don't have enough funds to withdraw that amount!");
            //    CheckBalance();
            //}
        }
    }
}
