using Loyalty.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loyalty.Data.Entities
{
    public class CustomerStore
    {
        public int CustomerId { get; set; }
        public int StoreId { get; set; }
        public Status_Customer status { get; set; }
        public string gift { get; set; }
        public DateTime redemption { get; set; }
        public string address { get; set; }
        public Store Store { get; set; }
        public Customer Customer { get; set; }
    }
}