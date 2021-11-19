namespace S04_E01
{
    public class Index
    {
        public static void Main()
        {
            Pessoa a = new();
            Pessoa b = new();
            Console.WriteLine("Dados da primeira pessoa:");
            Console.Write("Nome: ");
            a.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            a.Idade = int.Parse(Console.ReadLine());
            Console.WriteLine("\nDados da segunda pessoa:");
            Console.Write("Nome: ");
            b.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            b.Idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Pessoa mais velha: " + (a.Idade > b.Idade ? a.Nome : b.Nome));
        }
    }
}
