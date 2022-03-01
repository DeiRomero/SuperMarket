namespace SuperMarket
{
    public class FixedPriceProduct : Product
    {
        public override decimal GetValeuToPay()
        {
            return Price + (Price * (decimal)Tax);
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                   $"\n\tValue.......:{$"{GetValeuToPay():C2}",14}";

        }

    }
}
