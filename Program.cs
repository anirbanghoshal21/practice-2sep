using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRLibrary;

namespace Assignment_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Product prod = new Product();
            prod.Productid = 121;
            prod.Productname = "Milk";
            prod.Qtysold = 5;
            prod.Unitprice = 50;
            prod.Unitofmeasurement = 12;
            prod.Qtyinhand = 2;
            Console.WriteLine(prod.Productid);
            Console.WriteLine(prod.Productname);
            Console.WriteLine(prod.Qtysold);
            Console.WriteLine(prod.Unitprice);
            Console.WriteLine(prod.Unitofmeasurement);
            Console.WriteLine(prod.Qtyinhand);
            Console.WriteLine("-----------------");

            Product prod1 = new Product();
            prod1.Productid = 122;
            prod1.Productname = "Lassi";
            prod1.Qtysold = 510;
            prod1.Unitprice = 40;
            prod1.Unitofmeasurement = 11;
            prod1.Qtyinhand = 5;
            Console.WriteLine(prod1.Productid);
            Console.WriteLine(prod1.Productname);
            Console.WriteLine(prod1.Qtysold);
            Console.WriteLine(prod1.Unitprice);
            Console.WriteLine(prod1.Unitofmeasurement);
            Console.WriteLine(prod1.Qtyinhand);

            List<Product> prodlist = new List<Product>();
            prodlist.Add(prod);
            prodlist.Add(prod1);

            Console.WriteLine("----------------One Category Many Product------------");
            Category cat = new Category();
            cat.Catid = 100;
            cat.Catname = "Dairy Product";
            cat.Desc = "Daily Uses";
            cat.Categoryproducts = prodlist;

            Console.WriteLine("Cat details");
            Console.WriteLine("Catid= " + cat.Catid);
            Console.WriteLine("Catname" + cat.Catname);
            Console.WriteLine("Desc" + cat.Desc);

            foreach (var item in cat.CategoryProducts)
            {
                Console.WriteLine(item.Productid);
                Console.WriteLine(item.Productname);
                Console.WriteLine(item.Qtysold);
                Console.WriteLine(item.Unitprice);
                Console.WriteLine(item.Unitofmeasurement);
                Console.WriteLine(item.Qtyinhand);
            }











            Console.ReadLine();
        }
    }
}
