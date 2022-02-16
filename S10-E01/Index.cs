using S10_E01.Entities;
using System.Globalization;

namespace S10_E01
{
    public static class Index
    {
        public static void Main()
        {
            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());
            List<Product> listP = new List<Product>();

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                char pt = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string? pname = Console.ReadLine();
                Console.Write("Price: ");
                double pprice = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                if(pt == 'i')
                {
                    Console.Write("Customs fee: ");
                    double pcf = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    listP.Add(new ImportedProduct(pname,pprice,pcf));
                }
                else if(pt == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateOnly pdate = DateOnly.Parse(Console.ReadLine());
                    listP.Add(new UsedProduct(pname,pprice,pdate));
                }
                else if(pt == 'c')
                {
                    listP.Add(new Product(pname,pprice));
                }
            }

            Console.WriteLine();
            Console.WriteLine("PRICE TAGS:");

            foreach(Product prod in listP)
            {
                Console.WriteLine(prod.PriceTag());
            }
        }
    }
}