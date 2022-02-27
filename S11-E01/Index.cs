using S11_E01.Entities;
using S11_E01.Entities.Exceptions;
using System.Globalization;

namespace S11_E01
{
    internal static class Index
    {
        public static void Main()
        {
            Console.WriteLine("Enter account data:");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Holder: ");
            string? name = Console.ReadLine();
            Console.Write("Initial balance: ");
            double ibalance = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Withdraw limit: ");
            double wlimit = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Account a = new Account(number,name,ibalance,wlimit);

            Console.WriteLine();
            Console.Write("Enter ammout for withdraw: ");
            try
            {
                a.Withdraw(double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture));
                Console.WriteLine("New balance: " + a.Balance.ToString("F2",CultureInfo.InvariantCulture));
            }
            catch(DomainException e) //Chama a excessão personalizada.
            {
                Console.WriteLine("Withdraw error: " + e.Message);
            }
        }
    }
}