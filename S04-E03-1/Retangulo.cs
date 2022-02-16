namespace S04_E03_1
{
    internal class Retangulo
    {
        public double Largura = 0;
        public double Altura = 0;

        public double Area()
        {
            return Largura * Altura;
        }

        public double Perimetro()
        {
            return 2 * (Largura + Altura);
        }

        public double Diagonal()
        {
            return Math.Sqrt(Largura * Largura + Altura * Altura);
        }
    }
}