using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loyalty.Data.Entities
{
    public class Promotion
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string type { get; set; }
        public DateTime Start { get; set; }

        public DateTime End { get; set; }
        public string Country { get; set; }
        public List<CollectionPromotion> CollectionPromotions { get; set; }
        public List<PromotionProduct> PromotionProducts { get; set; }

        public List<PromotionStore> PromotionStores { get; set; }
    }
}