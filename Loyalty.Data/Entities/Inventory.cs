using Loyalty.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loyalty.Data.Entities
{
    public class Inventory
    {
        public int Id { get; set; }

        public int ProductId { get; set; }
        public string sku { get; set; }
        public int TotalTon { get; set; }

        public DateTime date { get; set; }

        public string Diachi { get; set; }

        public Product Product { get; set; }
    }
}