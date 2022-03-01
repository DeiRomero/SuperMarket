using System.Collections;

namespace SuperMarket
{
    public class ComposedProduct : Product
    {
        public float Discount { get; set; }

        public ICollection Products { get; set; }
        
        public override decimal GetValeuToPay()
        {
            decimal Value = 0;
           
            foreach (Product product in Products)
            {
                float Disc = 0;
                decimal Assi;
                Assi = product.GetValeuToPay();
                Disc = (float)Assi * Discount;
                Value += Assi - (decimal)Disc;

            }
            return Value;

        }

        public override string ToString()
        {
            string Assistent = "";
            foreach (Product productDiscount in Products)
            {
                Assistent += productDiscount.Description + ",";
            }
            return $"  {Id}  {$"{Description}",9}" +
                   $"\n\tProducts....: {$"{Assistent}",9}" +
                   $"\n\tDiscount....:{$"{Discount:P2}",16}" +
                   $"\n\tValue.......:{$"{GetValeuToPay():C2}",14}";
        }

    }
}
