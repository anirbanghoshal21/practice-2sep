using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace HRLibrary
{
    public class Category
    {
        static int cnt;
        int i = 0;
        public static int productno = 1;
        public void AddProduct()
        {
            cnt = cnt + 1;
            Console.WriteLine("You added product no= " + cnt);
            i = i + 1;
            Console.WriteLine("Value of I= " + i);
        }

        private int _catid;

        public int Catid
        {
            get { return _catid; }
            set { _catid = value; }
        }

        private string _catname;

        public string Catname
        {
            get { return _catname; }
            set { _catname = value; }
        }

        private string _desc;

        public string Desc
        {
            get { return _desc; }
            set { _desc = value; }
        }
        

    }
}
