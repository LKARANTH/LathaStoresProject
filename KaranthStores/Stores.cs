using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaranthStores
{
    static class Stores
    {
        private static List<Product> products = new List<Product>();
        public static Product PlaceOrder(string productName, ProductType typeOfProduct, int quantity)
        {
            var product = new Product
            {
                ProductName = productName,
                TypeOfProduct = typeOfProduct
            };
            products.Add(product);
            product.Receive(quantity);
            return product;
        }
        public static List<Product> GetAllProducts()
        {
            return products;

        }
    }
    }

