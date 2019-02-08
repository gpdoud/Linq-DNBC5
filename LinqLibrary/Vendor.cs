using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLibrary {

    public class Vendor {

        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Discount { get; set; }

        public override string ToString() {
            return $"Vendor: Id={Id}, Name={Name}, Discount={Discount}";
        }

        public Vendor() { }
    }
}
