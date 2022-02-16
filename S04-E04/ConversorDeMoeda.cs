namespace S04_E04
{
    internal static class ConversorDeMoeda
    {
        public const double Iof = 6.0;

        public static double DolarParaReal(double quantia,double cotacao)
        {
            double total = quantia * cotacao;
            return total + total * Iof / 100.0;
        }
    }
}