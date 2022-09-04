using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    public class Product
    {
        private int _productid;

        public int Productid
        {
            get { return _productid; }
            set { _productid = value; }
        }
        private string _productname;

        public string Productname
        {
            get { return _productname; }
            set { _productname = value; }
        }
        private int _qtysold;

        public int Qtysold
        {
            get { return _qtysold; }
            set { _qtysold = value; }
        }
        private decimal _unitprice;

        public decimal Unitprice
        {
            get { return _unitprice; }
            set { _unitprice = value; }
        }
        private int _unitofmeasurement;

        public int Unitofmeasurement
        {
            get { return _unitofmeasurement; }
            set { _unitofmeasurement = value; }
        }
        private int _qtyinhand;

        public int Qtyinhand
        {
            get { return _qtyinhand; }
            set { _qtyinhand = value; }
        }
        private List<Product> _prodlist;

        public List<Product> Categoryproducts
        {
            get { return _prodlist; }
            set { _prodlist = value; }
        }

        public static void Add(Product)
        {
            Product.Add(product);
            
        }

        public static int ProductId()
        {
            int id;
            if (Product.Count == 0)
                id = 1;
            else
            {
                id = Product.Last().Id + 1;
            }

            return id;
        }
    }
}
