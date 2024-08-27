using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APPDATA.Models
{
    public class ProductVariant
    {
        public Guid Id { get; set; }
        public Guid? productId { get; set; }
        public Guid? colorId { get; set; }
        public Guid? sizeId { get; set; }
        public int Quantity { get; set; }
        public DateTime UpdateDate { get; set; }
        public int UpdateUser { get; set; }
        public Color? color { get; set; }
        public Size? size { get; set; }
        public List<OrderDetail>? orderDetails { get; set; }
        public Product? product { get; set; }
    }
}
