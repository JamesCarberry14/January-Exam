using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace January_Exam
{
    public abstract class Account
    {

        //variables
        public string firstname { get; set; }
        public string lastname { get; set; }
        public decimal balance { get; set; }
        public DateTime interestdate { get; set; }


        //constructor
        public Account(string FName, string LName, decimal Balance, DateTime InterestDate)
        {
            firstname = FName;
            lastname = LName;
            balance = Balance;
            interestdate = InterestDate;
        }

        //withdraw method
        public static void Withdraw(decimal balance, decimal value)
        {
            if(balance >= value)
            {
                balance -= value;
            }
            else
            {
                WriteLine("Insufficient Funds");
            }
        }

        //deposit method
        public static void Deposit(decimal balance, decimal value)
        {          
                balance += value;          
        }


        public abstract decimal CalculateInterest();

        public override abstract string ToString();

    }






    //Current Account class
    public class CurrentAccount : Account
    {
        //variables
        public decimal interestrate { get; set; }


        //constructor
        public CurrentAccount(string FName, string LName, decimal Balance, DateTime InterestDate) : base(FName, LName, Balance, InterestDate)
        {
            interestrate = 0.03m;
        }

        //calculate interest method
        public override decimal CalculateInterest()
        {
            interestdate = DateTime.Now;

            decimal Interest = balance * interestrate;
            return Interest;
        }

        //tostring method
        public override string ToString()
        {
            return string.Format($"{balance},{lastname}, {firstname} - Current Account");
        }


    }





    //Savings account class
    public class SavingsAccount : Account
    {
        //variables
        public decimal interestrate { get; set; }


        //Constructor
        public SavingsAccount(string FName, string LName, decimal Balance, DateTime InterestDate) : base(FName, LName, Balance, InterestDate)
        {
            interestrate = 0.06m;
        }



        //calculate interest method
        public override decimal CalculateInterest()
        {
            interestdate = DateTime.Now;

            decimal Interest = balance * interestrate;
            return Interest;
        }

        //tostring method
        public override string ToString()
        {
            return string.Format($"{balance},{lastname}, {firstname} - Current Account");
        }

    }





}
