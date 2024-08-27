using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APPDATA.Models
{
    public class Color
    {
        public Guid Id { get; set; }
        public string codeColor { get; set; }
        public string colorName { get; set; } 
        public string colorValue { get; set; }
        public List<ProductVariant>? productVariants { get; set; }
    }
}
