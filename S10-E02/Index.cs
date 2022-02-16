using S10_E02.Entities;
using System.Globalization;

namespace S10_E02
{
    public static class Index
    {
        public static void Main()
        {
            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());
            List<TaxPayer> list = new List<TaxPayer>();

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or company (i/c)? ");
                char c = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string? name = Console.ReadLine();
                Console.Write("Anual income: ");
                double income = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                if(c == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double health = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    list.Add(new Individual(name,income,health));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int emp = int.Parse(Console.ReadLine());
                    list.Add(new Company(name,income,emp));
                }
            }
            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");
            double t = default;
            foreach(TaxPayer acc in list)
            {
                Console.WriteLine(acc.Name + ": $ " + acc.tax().ToString("F2",CultureInfo.InvariantCulture));
                t += acc.tax();
            }
            Console.WriteLine();
            Console.WriteLine("TOTAL TAXES: $ " + t.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}