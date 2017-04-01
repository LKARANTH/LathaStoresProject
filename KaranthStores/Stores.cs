using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaranthStores
{
    static class Stores
    {
        public static Product PlaceOrder(string productName, ProductType typeOfProduct, int quantity)
        {
            var product = new Product
            {
                ProductName = productName,
                TypeOfProduct = typeOfProduct,
            };
            product.Receive(quantity);
            return product;
        }
    }
}
