namespace S06_E01
{
    public static class Index
    {
        public static void Main()
        {
            Estudante[] n = new Estudante[10]; // Cria o vetor com dez posicao.
            Console.Write("Quantos quartos serão alugados? ");
            int alg = int.Parse(Console.ReadLine());
            for(int i = 1; i <= alg; i++)
            {
                Console.Write("\nAluguel #{0}:",i);
                Console.Write("\nNome: ");
                string? Nome = Console.ReadLine();
                Console.Write("Email: ");
                string? Email = Console.ReadLine();
                Console.Write("Quarto: ");
                int q = int.Parse(Console.ReadLine());
                n[q] = new Estudante(Nome,Email); // instancia a posicao e coloca os dados.
            }
            Console.WriteLine("\nQuartos Ocupados:");
            for(int i = 0; i < 10; i++)
            {
                if(n[i] != null)
                {
                    Console.WriteLine(i + ": " + n[i].ToString());
                }
            }
        }
    }
}