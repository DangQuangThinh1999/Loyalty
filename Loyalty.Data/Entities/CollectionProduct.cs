using Loyalty.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loyalty.Data.Entities
{
    public class CollectionProduct
    {
        public int ProductId { get; set; }
        public int CollectionId { get; set; }
        public Collection Collection { get; set; }
        public Product Product { get; set; }
    }
}