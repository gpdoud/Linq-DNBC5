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

            //var ProdsGt200 = Linq.Products.Where(p => p.Price > 200)
            //                              .OrderByDescending(q => q.Price)
            //                              .ToArray();
            //foreach(var pg in ProdsGt200) {
            //    pg.Print();
            //}


            //var product = Linq.Products[0];
            //product.Print();

            //var productsWithVendors = from p in Linq.Products
            //                          join v in Linq.Vendors
            //                          on p.VendorId equals v.Id
            //                          select new {
            //                              VendorName = v.Name,
            //                              ProductName = p.Name,
            //                              Price = p.Price
            //                          };
            //foreach(var pv in productsWithVendors) {
            //    Console.WriteLine($"{pv.VendorName} {pv.ProductName} {pv.Price:C}");
            //}

            //var products = from p in Linq.Products
            //               where p.Price > 200
            //               orderby p.Name
            //               select p;
            //foreach(var p in products) {
            //    Console.WriteLine(p);
            //}

            //var vendors = from v in Linq.Vendors
            //              where v.Discount >= 0.1m
            //              orderby v.Name descending
            //              select v;
            //foreach(var vendor in vendors) {
            //    Console.WriteLine(vendor);
            //}

            var join = Linq.Products.Join(Linq.Vendors,
                                            p => p.VendorId,
                                            v => v.Id,
                                            (p, v) => new { p, v })
                                    .Select(x => new {
                                        Vendor = x.v.Name,
                                        Product = x.p.Name,
                                        Price = x.p.Price
                                    });
            foreach(var j in join) {
                Console.WriteLine($"{j.Vendor, -10} | {j.Product, -40} | {j.Price,10:C}");
            }

            Console.ReadKey();
        }
    }
}
