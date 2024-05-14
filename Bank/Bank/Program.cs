using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Alps Bank ");
            Console.WriteLine("==========================");
            
            custInfo c1 = new custInfo();

            Console.WriteLine("Enter Account Number ");
            long acc = long.Parse(Console.ReadLine());
            c1.findAcc(acc);


            if (c1.findAcc(acc) == 0)
            {
                Console.WriteLine("Enter The Amount To Be Deposited ");
                Console.WriteLine();
                double amt = double.Parse(Console.ReadLine());
                c1.deposit(amt);
                Console.WriteLine();

                Console.WriteLine("Your New Balance Is ");
                Console.WriteLine(c1.displayBal);

                Console.WriteLine();
                Console.WriteLine("Withdrawal Amount : ");
                double wdamt = double.Parse(Console.ReadLine());
                c1.withdraw(wdamt);
                Console.WriteLine();
            }
            else 
            {
                Console.WriteLine("Account Not Found");
                Console.WriteLine("Thank You");
            }

                //Console.WriteLine("Thank You For Banking With us");
            Console.ReadLine();


        }
    }
}
