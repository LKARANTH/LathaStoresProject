using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaranthStores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**********Welcome to Karanth Stores!********");
            Console.WriteLine("Please select from the following option");
            Console.WriteLine("0: Exit");
            Console.WriteLine("1: Please place an order");
            Console.WriteLine("2: sold");
            Console.WriteLine("3: received");
            var option = Console.ReadLine();
            var product1 = new Product();
            switch (option)
            {
                case "0":
                    Console.WriteLine("Thank you for visiting! Good bye!");
                    break;
                case "1":
                    Console.WriteLine(" Enter Manufacturer Name");
                    var Manufacturer = Console.ReadLine();
                    product1.Manufacturer = Manufacturer;
                    Console.WriteLine(" Enter Product Name");
                    var ProductName = Console.ReadLine();
                    product1.ProductName = ProductName;
                    Console.WriteLine(" Enter Type Of Product");
                    var TypeOfProduct = Console.ReadLine();
                    product1.TypeOfProduct = TypeOfProduct;
                    Console.WriteLine(" Enter the Quantity");
                    int Quantity = Convert.ToInt32 (Console.ReadLine());
                    product1.Quantity = Quantity;
                    Console.WriteLine($"Manufacturer: {product1.Manufacturer}, ProductName: {product1.ProductName}, TypeOfProduct: {product1.TypeOfProduct}, Quantity: {product1.Quantity}");

                    break;
                case "2":
                    product1.Sales(10);
                    break;
                case "3":
                    product1.Receive(10);
                    break;
                default:
                    break;
            }
       }
    }
}
