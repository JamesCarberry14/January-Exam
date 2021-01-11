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
        public string firstname { get; set; }
        public string lastname { get; set; }
        public decimal balance { get; set; }
        public DateTime interestdate { get; set; }

        public Account(string FName, string LName, decimal Balance, DateTime InterestDate)
        {
            firstname = FName;
            lastname = LName;
            balance = Balance;
            interestdate = InterestDate;
        }


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


        public static void Deposit(decimal balance, decimal value)
        {          
                balance += value;          
        }


        public abstract decimal CalculateInterest();
    
    }







    public class CurrentAccount : Account
    {
        public decimal interestrate { get; set; }



        public CurrentAccount(string FName, string LName, decimal Balance, DateTime InterestDate) : base(FName, LName, Balance, InterestDate)
        {
            interestrate = 0.03m;
        }


        public override decimal CalculateInterest()
        {
            interestdate = DateTime.Now;

            decimal Interest = balance * interestrate;
            return Interest;
        }
    }






    public class SavingsAccount : Account
    {
        public decimal interestrate { get; set; }



        public SavingsAccount(string FName, string LName, decimal Balance, DateTime InterestDate) : base(FName, LName, Balance, InterestDate)
        {
            interestrate = 0.06m;
        }




        public override decimal CalculateInterest()
        {
            interestdate = DateTime.Now;

            decimal Interest = balance * interestrate;
            return Interest;
        }

    }





}
