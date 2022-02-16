using System.Globalization;

namespace S04_E03_3
{
    internal class Index
    {
        public static void Main()
        {
            Aluno a = new();
            Console.Write("Nome do aluno: ");
            a.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno: ");
            a.nota1 = float.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            a.nota2 = float.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            a.nota3 = float.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine("NOTA FINAL = " + a.NotaFinal().ToString("F2",CultureInfo.InvariantCulture));
            if(a.NotaFinal() >= 60.0)
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTAM " + (60.0 - a.NotaFinal()).ToString("F2",CultureInfo.InvariantCulture) + " PONTOS");
            }
        }
    }
}