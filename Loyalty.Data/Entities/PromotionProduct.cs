using Loyalty.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loyalty.Data.Entities
{
    public class PromotionProduct
    {
        public int ProductId { get; set; }
        public int PromotionId { get; set; }
        public int total { get; set; }
        public Product Product { get; set; }

        public Promotion Promotion { get; set; }
    }
}