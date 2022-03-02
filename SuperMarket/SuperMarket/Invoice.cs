using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarket
{
    public class Invoice : IPay
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public float Quantity { get; set; }
        public decimal Price { get; set; }

        public decimal GetValeuToPay()
        {
            return Price * (decimal)Quantity;
            
        }

        public override string ToString()
        {
            return $"  {Id}  {$"{Description}",9}" +
                    $"\n\tQuantity....: {$"{Quantity:N2}",9}" +
                    $"\n\tPrice....:{$"{Price:C2}",16}" +
                    $"\n\tValue.......:{$"{GetValeuToPay():C2}",14}";
        }

        
    }
}
