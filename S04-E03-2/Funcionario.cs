using System.Globalization;

namespace S04_E03_2
{
    internal class Funcionario
    {
        public string? Nome;
        public double SalarioBruto = 0;
        public double Imposto;

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }
        public double AumentarSalario(double Porcentagem)
        {
            return SalarioBruto += SalarioBruto * Porcentagem / 100.0;
        }
        public override string ToString()
        {
            return Nome + ", R$ " + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
