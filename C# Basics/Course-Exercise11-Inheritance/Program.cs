/*
Exercise:
Write a program that will simulate an ATM and allow a customer to deposit to and withdraw from their checking or savings account.

Requirements:
Create an Account class that can store a balance and has methods for depositing and withdrawing money. We only need to inherit from this class, not instantiate an object from it, so make it an abstract class.

Derive two different classes from the Account class - CheckingAccount and SavingsAccount. 
The only difference between a checking account and savings account is that this bank has a “bonus bucks” program when you deposit money to a savings account. 
For every $100 deposited in a single deposit transaction to a savings account, the bank will deposit $1 in bonus bucks to the account (Hint: Use Math.Floor(number) to round a number down to the nearest whole number).

Assume that the ATM has a retina scanner, so it can automatically identify the customer and no login information is required. Assume the user for this example currently has no money in either of his account types.

Program should have a menu that allows user to select their checking account, savings account, or to exit the program. Once they choose an account, user should be able to choose to make a deposit, make a withdrawal, check their account balance, or exit back to the previous menu. If user attempts to make a withdrawal, the account should check to make sure that the funds are available first and not allow them to go over their balance. After making a deposit or withdrawal, program should display the new balance.
 * 
 */

using System;

namespace Course_Exercise11
{
    class Program
    {
        static void Main(string[] args)
        {
            byte menuChoice;
            byte secondMenuChoice;
            CheckingAccount checking = new CheckingAccount();
            SavingsAccount saving = new SavingsAccount();
            do
            {
                menuChoice = InitialMenu(); ;
                switch (menuChoice)
                {
                    case 1:
                        SecondaryMenu();
                        secondMenuChoice = Convert.ToByte(Console.ReadLine());
                        switch (secondMenuChoice)
                        {
                            case 1:

                                checking.DepositMoney();
                                break;
                            case 2:
                                checking.CheckingWithdraw();
                                break;
                            case 3:
                                checking.CheckBalance();
                                break;
                            case 4:
                                break;
                            default:
                                break;
                        }
                        break;
                    case 2:
                        SecondaryMenu();
                        secondMenuChoice = Convert.ToByte(Console.ReadLine());
                        switch (secondMenuChoice)
                        {
                            case 1:
                                saving.SavingDeposit();
                                break;
                            case 2:
                                saving.SavingWithdraw();
                                break;
                            case 3:
                                saving.CheckBalance();
                                break;
                            case 4:
                                break;
                            default:
                                break;
                        }
                        break;
                    case 3:
                        saving.CheckBalance();
                        break;
                    default:
                        break;
                }
            } while (menuChoice != 3);

        }


        static byte InitialMenu()
        {
            byte choice;
            string top = new string('=', 30);
            string bottom = new string('=', 30);

            Console.WriteLine(top);
            Console.WriteLine("Welcome! Please make a selection\n1 - Checking Account\n2 - Savings Account\n3 - Exit");
            Console.WriteLine(bottom);

            Console.Write("Choice: ");
            choice = Convert.ToByte(Console.ReadLine());

            return choice;
        }

        static void SecondaryMenu()
        {
            string top = new string('=', 30);
            string bottom = new string('=', 30);
            try
            {
                //byte choice; 
                Console.WriteLine(top);
                Console.WriteLine("1 - Deposit\n2 - Withdraw\n3 - Check Balance\n4 - Exit");
                Console.WriteLine(bottom);
                Console.Write("Choice: ");

                //choice = Convert.ToByte(Console.ReadLine());
                //return choice;

            }
            catch (Exception E)
            {
                Console.WriteLine (E + "Exception");
            }
        }

    }
}
