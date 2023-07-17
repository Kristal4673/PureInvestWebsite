using System.Collections.Generic;

namespace PureInvestWebsite.Models
{
    public class CartModel
    {
        public List<Product> Products { get; set; }
        public decimal TotalPrice { get; set; }

        public CartModel()
        {
            Products = new List<Product>();
            TotalPrice = 0;
        }
    }
}
