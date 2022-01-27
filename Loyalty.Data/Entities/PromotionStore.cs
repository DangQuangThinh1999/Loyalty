using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loyalty.Data.Entities
{
    public class PromotionStore
    {
        public int PromotionId { get; set; }
        public int StoreId { get; set; }

        public Promotion Promotion { get; set; }

        public Store Store { get; set; }
    }
}