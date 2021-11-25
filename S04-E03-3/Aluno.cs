namespace S04_E03_3
{
    internal class Aluno
    {
        public string? Nome;
        public float nota1;
        public float nota2;
        public float nota3;
        public float NotaFinal()
        {
            return nota1 + nota2 + nota3;
        }
    }
}
