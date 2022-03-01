namespace SuperMarket
{
    public abstract class Product
    {
        public string Description { get; set; }
        public int Id { get; set; }
        public decimal Price { get; set; }
        public float Tax { get; set; }

        public abstract decimal GetValeuToPay();

        public override string ToString()
        {
            return $"  {Id}  {$"{Description}",13}" +
                    $"\n\tPrice.......:{$"{Price:C2}",14}" +
                    $"\n\tTax.........:{$"{Tax:P2}",16}";
        }


    }
}
