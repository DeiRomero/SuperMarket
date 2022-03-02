using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarket
{
    public class Invoice : IPay
    {
        private List<Product> _products = new List<Product>();

        public void AddProduct(Product product)
        {
            _products.Add(product);
        }
        public decimal GetValeuToPay()
        {
            decimal Sum = 0;

            foreach (Product product in _products) {
            
                Sum += product.GetValeuToPay();
            
            };
           return Sum;
            
        }

        public override string ToString()

        {
            
            foreach (Product product in _products)
            {

                Console.WriteLine(product.ToString());

            };
            return $"                     ==============" +
            $"\n TOTAL:    {$"{GetValeuToPay():C2}",23}";
        }

        
    }
}
