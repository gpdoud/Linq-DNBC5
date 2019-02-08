using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLibrary {

    public class Product {

        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int VendorId { get; set; }
        public decimal Price { get; set; }

        public override string ToString() {
            return $"Id={Id}, Code={Code}, Name={Name}, VendorId={VendorId}, Price={Price}";
        }
        public Product() { }
    }
}
