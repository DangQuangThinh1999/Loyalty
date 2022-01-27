using Loyalty.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loyalty.Data.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string name { get; set; }

        public string unit { get; set; }

        public string trongluong { get; set; }
        public string size { get; set; }
        public string descripition { get; set; }
        public string market { get; set; }

        public string sku { get; set; }
        public decimal price { get; set; }
        public int stock { get; set; }

        public string image { get; set; }

        public int total { get; set; }

        public DateTime date { get; set; }
        public List<CollectionProduct> CollectionProducts { get; set; }
        public List<CollectionPromotion> CollectionPromotions { get; set; }

        public List<Inventory> Inventories { get; set; }

        public List<PromotionProduct> PromotionProducts { get; set; }
    }
}