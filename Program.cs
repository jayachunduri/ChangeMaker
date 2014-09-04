using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            //calling Change maker function with different amounts
            ChangeMaker(3.18);
            ChangeMaker(0.99);
            ChangeMaker(12.93);
        }

        static void ChangeMaker(double amount)
        {
            //converted the amount into cents
            double amountInCents = amount * 100;

            //finding how many quarters are there in the total amount in cents
            double quarters = Math.Floor(amountInCents / 25);

            //amount after the quarters
            double remaingAmount = amountInCents - (25 * quarters);

            //finding dimes in amount after quarters
            double dimes = Math.Floor(remaingAmount / 10);
            
            //amount after dimes
            remaingAmount = remaingAmount - (10 * dimes);

            //finding nickles in amount after dimes
            double nickles = Math.Floor(remaingAmount / 5);

            //remaining amount itself represent the pennies in the amount
            double pennies = remaingAmount - (5 * nickles);
            
            //Printing the output
            Console.WriteLine("Amount: $" + amount);
            Console.WriteLine("Quarters: " + quarters);
            Console.WriteLine("Dimes: " + dimes);
            Console.WriteLine("Nickles: " + nickles);
            Console.WriteLine("Pennies: " + pennies);

            Console.WriteLine();
        }
    }
}
