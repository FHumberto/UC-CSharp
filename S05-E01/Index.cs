using System.Globalization;

namespace S05_E01
{
    internal static class Index
    {
        public static void Main()
        {
            Conta ContaBancaria;
            Console.Write("Entre o número da conta: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("\nEntre o titular da conta: ");
            string? nome = Console.ReadLine();
            Console.Write("\nHaverá depósito inicial (s/n)? ");
            char z = char.Parse(Console.ReadLine());

            if(z == 's' || z == 'S')
            {
                Console.Write("\nEntre o valor de depósito inicial: ");
                float saldo = float.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                ContaBancaria = new Conta(id,nome,saldo);
            }
            else
            {
                ContaBancaria = new Conta(id,nome);
            }
            Console.WriteLine("\nDados da conta: ");
            Console.WriteLine(ContaBancaria);
            Console.Write("\nEntre um valor para depósito: ");
            ContaBancaria.Deposito(float.Parse(Console.ReadLine(),CultureInfo.InvariantCulture));

            Console.WriteLine("\nDados da conta atualizados: ");
            Console.WriteLine(ContaBancaria);

            Console.Write("\nEntre um valor para saque: ");
            ContaBancaria.Saque(float.Parse(Console.ReadLine(),CultureInfo.InvariantCulture));
            Console.WriteLine("\nDados da conta atualizados: ");
            Console.WriteLine(ContaBancaria);
        }
    }
}