using System.Globalization;

namespace S04_E04
{
    internal class Index
    {
        public static void Main()
        {
            Console.Write("Qual é a cotação do dolar? ");
            double Cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("\nQuandos dólares você vai comprar? ");
            double Quantidade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("\nValor a ser pago em reais = " + ConversorDeMoeda.DolarParaReal(Quantidade, Cotacao).ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
