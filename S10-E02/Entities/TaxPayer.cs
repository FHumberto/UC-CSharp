namespace S10_E02.Entities
{
    public abstract class TaxPayer
    {
        public string? Name { get; set; }
        public double AnualIncome { get; set; }

        protected TaxPayer()
        {
        }

        protected TaxPayer(string? name,double anualIncome)
        {
            Name = name;
            AnualIncome = anualIncome;
        }

        public abstract double tax();
    }
}