using System.Globalization;

namespace S06_E02
{
    internal static class Index
    {
        public static void Main()
        {
            List<Employee> f = new List<Employee>();

            Console.Write("How many employees will be registered? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Employee #" + (i + 1));
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string? name = Console.ReadLine();
                Console.Write("Salary ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine();
                f.Add(new Employee(id, name, salary));
            }

            Console.Write("Enter the employee id that will have salary increase : ");
            int searchId = int.Parse(Console.ReadLine());
            Employee? emp = f.Find(x => x.Id == searchId); // coloca o membro emcontrado em outro objeto
            if (emp != null)
            {
                Console.Write("Enter de percentage: ");
                double inc = double.Parse(Console.ReadLine(), CultureInfo.CurrentCulture);
                emp.IncreaseSalary(inc);
            }
            else
            {
                Console.WriteLine("This Id does not exist!*");
            }

            Console.WriteLine("\nUpdated List of employess:");
            foreach (Employee obj in f)
            {
                Console.WriteLine(obj); // imprime os dados do objeto
            }
        }
    }
}
