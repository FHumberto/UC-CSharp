using System.Globalization;

namespace S10_E01.Entities
{
    internal class ImportedProduct : Product
    {
        public double customsfee { get; set; }

        public ImportedProduct()
        {
        }

        public ImportedProduct(string name,double price,double customsfee) : base(name,price)
        {
            this.customsfee = customsfee;
        }

        public double TotalPrice()
        {
            return price + customsfee;
        }

        public override string PriceTag()
        {
            return name + " $ " + TotalPrice().ToString("F2",CultureInfo.InvariantCulture) +
                " (Customs fee: $ " + customsfee.ToString("F2",CultureInfo.InvariantCulture) + ")";
        }
    }
}