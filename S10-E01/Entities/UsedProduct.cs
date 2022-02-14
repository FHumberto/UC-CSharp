namespace S10_E01.Entities
{
    internal class UsedProduct : Product
    {
        public DateOnly manufactureDate { get; set; }

        public UsedProduct()
        {
        }

        public UsedProduct(string name,double price,DateOnly manufactureDate) : base(name,price)
        {
            this.manufactureDate = manufactureDate;
        }

        public override string PriceTag()
        {
            return name + " (used) $" + price + " (Manifacture date: " + manufactureDate + ")";
        }
    }
}
