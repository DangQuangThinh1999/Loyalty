using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loyalty.Data.Entities
{
    public class Store
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Email { get; set; }
        public int Phone { get; set; }
        public string Country { get; set; }

        public string City { get; set; }
        public string District { get; set; }

        public string Ward { get; set; }
        public string Address { get; set; }
        public List<CustomerStore> CustomerStores { get; set; }

        public List<PromotionStore> PromotionStores { get; set; }
    }
}