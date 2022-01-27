using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loyalty.Data.Entities
{
    public class CollectionPromotion
    {
        public int PromotionId { get; set; }
        public int CollectionId { get; set; }
        public Collection Collection { get; set; }
        public Promotion Promotion { get; set; }
    }
}