using System.Globalization;

namespace S04_E02
{
    public class Index
    {
        public static void Main()
        {
            Funcionario a = new();
            Funcionario b = new();
            Console.WriteLine("Dados do primeiro funcionário:");
            Console.Write("Nome: ");
            a.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            a.Salario = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("\nDados do segundo funcionário:");
            Console.Write("Nome: ");
            b.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            b.Salario = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("\nSalário médio = " + ((a.Salario + b.Salario) / 2.0).ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
