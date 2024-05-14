using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class custInfo
    {
        // fields
        private double balance;
        private long AccountNumber = 12345678;
        private bool IsLocked = true;

        //methods

        public int findAcc(long accNum)
        {
            if(accNum == this.AccountNumber)
            {
                if (this.IsLocked) { IsLocked = false; }
                return 0; 
            }
            else
            {
                return -1;
            }
        }
        public double displayBal
        {
            get { return balance; }
        }

        public void deposit(double amount)
        {

            if(!IsLocked) { balance = amount; }
        }

        public void withdraw(double wdrwamount)
        {
           
if (!IsLocked)
            {
                if (wdrwamount < balance)
                {
                    double newBal = this.balance - wdrwamount;
                    this.balance = newBal;
                    Console.WriteLine($"AMOUNT {wdrwamount} WIHDRAWN");
                    Console.WriteLine();
                    Console.WriteLine("Want To See Updated Account Balance ? (yes/no) ");
                    string consult = Console.ReadLine();
                    if (String.Equals(consult, "yes", StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine("Your Updated Balance is : {0}", displayBal);
                        Console.WriteLine() ;
                        Console.WriteLine("Thank You For Banking With Us ! Visit Again..");
                    }
                    else
                    {
                        Console.WriteLine("Thank You For Banking With Us ! Visit Again..");
                    }
                }
                else
                {
                    Console.WriteLine("Insufficient Balance");
                    Console.WriteLine();
                    Console.WriteLine("Thank You For Banking With Us ! Visit Again..");

                }
            }

        } 
    }
}
