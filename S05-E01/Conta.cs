using System.Globalization;

namespace S05_E01
{
    internal class Conta
    {
        public int Id { get; private set; }
        private string? Nome { get; set; }

        private double saldo;

        private double GetSaldo()
        {
            return saldo;
        }

        private void SetSaldo(double value)
        {
            saldo = value;
        }

        public Conta(int id,string nome)
        {
            Id = id;
            Nome = nome;
            SetSaldo(0);
        }
        public Conta(int id,string nome,float saldo) : this(id,nome)
        {
            SetSaldo(saldo);
        }

        public void Deposito(double quantia)
        {
            SetSaldo(GetSaldo() + quantia);
        }
        public void Saque(double quantia)
        {
            SetSaldo(GetSaldo() - quantia - 5.0);
        }

        public override string ToString()
        {
            return "Conta " + Id + ", Titular: " + Nome + ", Saldo: $ " + GetSaldo().ToString("F2",CultureInfo.InvariantCulture);
        }
    }
}
