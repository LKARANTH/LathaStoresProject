using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaranthStores
{
    enum ProductType
    { 
    Clothing,
    Jewelry,
    HomeDecor
   }

class Product
    {
        #region Static Variable
        private static int lastProductID = 0;
        #endregion

        #region Properties
        ///Type of the Product
        public ProductType TypeOfProduct { get; set; }
        ///ID for the Product
        public int ProductID { get; }
        ///Name of the Product
        public string ProductName { get; set; }
        ///Quantity on Hand
        public int Quantity { get; set; }
        ///Name of the Manufacturer
        public string Manufacturer { get; set; }
        #endregion

        #region Constructor
        public Product()
        {
            //lastProductID ++1
            ProductID = lastProductID++;
        }

        //public Catalog(string TypeOfProduct) : this()
        //{
        //    TypeOfProduct = typeOfProduct;
        //}
        //public Catalog (string productName, string typeOFProduct) = this (typeOfProduct)
        //{
        //    ProductName = productName;
        //}
      
 #endregion

        #region Methods
        public void Sales(int sold)
        {
            //Quanity = Quantity - Sales
            Quantity -= sold;
        }
        public void Receive (int received)
        {
            //Quantity = Quantity + Receive
            Quantity += received;
        }
        #endregion
    }
}
