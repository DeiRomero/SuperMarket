namespace SuperMarket
{
    public class VariablePriceProduct : Product
    {
        public string Measurement { get; set; }

        public double Quantity { get; set; }

        public override decimal GetValeuToPay()
        {
            decimal Assistant = (Price * (decimal)Quantity);
            return (Price * (decimal)Quantity) * (decimal)Tax + Assistant;

        }

        public override string ToString()
        {
            return $"  {Id}  {$"{Description}",6}" +
                   $"\n\tMeasurement.:{$"{Measurement}",5}" +
                   $"\n\tQuanti......:{$"{Quantity:N2}",14}" +
                   $"\n\tPrice.......:{$"{Price:C2}",14}" +
                   $"\n\tTax.........:{$"{Tax:P2}",16}" +
                   $"\n\tValue.......:{$"{GetValeuToPay():C2}",14}";
        }

    }
}
