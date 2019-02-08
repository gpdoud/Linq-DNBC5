using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLibrary {



    public static class Linq {

        public static string About = "About Language Integrated Query Library";

        public static IList<Vendor> Vendors = new List<Vendor>() {
            new Vendor { Id = 1000, Name = "Amazon", Discount = 0.10M },
            new Vendor { Id = 2000, Name = "Microsoft", Discount = 0.05M },
            new Vendor { Id = 3000, Name = "Target", Discount = 0.20M }
        };

        public static IList<Product> Products = new List<Product>() {
            new Product { Id = 110, Code = "Echo", Name = "Amazon Echo", VendorId = 1000, Price = 99.99M },
            new Product { Id = 120, Code = "Dot", Name = "Amazon Echo Dot", VendorId = 1000, Price = 39.99M },
            new Product { Id = 130, Code = "FireTV", Name = "Amazon Fire TV", VendorId = 1000, Price = 129.99M },
            new Product { Id = 140, Code = "FireTab", Name = "Amazon Fire Tablet", VendorId = 1000, Price = 99.99M },
            new Product { Id = 150, Code = "FireStk", Name = "Amazon Fire Stick", VendorId = 1000, Price = 29.99M },
            new Product { Id = 210, Code = "Off365", Name = "Microsoft Office 365", VendorId = 2000, Price = 99.99M },
            new Product { Id = 220, Code = "Word", Name = "Microsoft Word", VendorId = 2000, Price = 119.99M },
            new Product { Id = 230, Code = "Excel", Name = "Microsoft Excel", VendorId = 2000, Price = 119.99M },
            new Product { Id = 240, Code = "PowerPt", Name = "Microsoft PowerPoint", VendorId = 2000, Price = 119.99M },
            new Product { Id = 250, Code = "Access", Name = "Microsoft Access", VendorId = 2000, Price = 119.99M },
            new Product { Id = 260, Code = "Project", Name = "Microsoft Project", VendorId = 2000, Price = 119.99M },
            new Product { Id = 270, Code = "Outlook", Name = "Microsoft Outlook", VendorId = 2000, Price = 119.99M },
            new Product { Id = 280, Code = "VSPro", Name = "Microsoft Visual Studio Professional", VendorId = 2000, Price = 1199.99M },
            new Product { Id = 290, Code = "VSArch", Name = "Microsoft Visual Studio Architect", VendorId = 2000, Price = 3119.99M },
            new Product { Id = 300, Code = "Access", Name = "Microsoft Access", VendorId = 2000, Price = 119.99M},
            new Product { Id = 410, Code = "iPad", Name = "Apple iPad", VendorId = 3000, Price = 499.99M},
            new Product { Id = 420, Code = "iPad Pro", Name = "Apple iPad Pro", VendorId = 3000, Price = 899.99M},
            new Product { Id = 430, Code = "iPhoneX", Name = "Apple iPhone X", VendorId = 3000, Price = 1499.99M},
        };

        public static void Print(this Product p) {
            Console.WriteLine(p);
        }

    }
}
