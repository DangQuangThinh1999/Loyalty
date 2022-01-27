using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loyalty.Data.Entities
{
    public class Collection
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public List<CollectionProduct> CollectionProducts { get; set; }
        public List<CollectionPromotion> CollectionPromotions { get; set; }
    }
}