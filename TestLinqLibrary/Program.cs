using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqLibrary;

namespace TestLinqLibrary {

    class Program {

        static void Main(string[] args) {

            Console.WriteLine(LinqLibrary.Linq.About);
            var msprods = from p in Linq.Products
                          join v in Linq.Vendors 
                          on p.VendorId equals v.Id
                          where v.Name.Equals("Amazon")
                          orderby p.Price descending
                          //select new { p.Name };
                          select p;
            foreach(var p in msprods) {
                p.Print();
            }
            Console.ReadKey();
        }
    }
}
