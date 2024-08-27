using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APPDATA.Models
{
    public class OrderDetail
    {
        public Guid Id { get; set; }
        public Guid? orderId { get; set; }
        public Guid? productId { get; set; }
        public int Quantity { get; set; }
        public decimal AmountPrice { get; set; }
        public ProductVariant? productVariant { get; set; }
        public Order? order { get; set; }
    }
}
