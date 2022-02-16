using System.Globalization;

namespace S04_E03_2
{
    internal static class Index
    {
        public static void Main()
        {
            Funcionario f = new();
            Console.Write("Nome: ");
            f.Nome = Console.ReadLine();
            Console.Write("Salário bruto: ");
            f.SalarioBruto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            f.Imposto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine("\nFuncionario: " + f);
            Console.Write("\nDigite a porcentagem para aumentar o salário: ");
            double p = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            f.AumentarSalario(p);
            Console.WriteLine("\nDados atualizados: " + f);
        }
    }
}