using Loyalty.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loyalty.Data.Entities
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public DateTime Created { get; set; }
        public string address { get; set; }
        public int Phone { get; set; }

        public List<CustomerStore> CustomerStores { get; set; }
    }
}