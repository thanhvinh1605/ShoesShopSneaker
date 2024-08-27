using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APPDATA.Models
{
    public class Size
    {
        public Guid Id { get; set; }
        public string codeSize { get; set; }

        public string size { get; set; }
        public List<ProductVariant>? productVariants { get; set; }
    }
}
