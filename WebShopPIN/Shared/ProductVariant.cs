using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WebShopPIN.Shared
{
    public class ProductVariant
    {
        [JsonIgnore]
        public Product? Product { get; set; }
        public int ProductId { get; set; }

        public ProductType? ProductType { get; set; }
        public int ProductTypeId { get; set; }

        [Column(TypeName ="decimal(18,2)")]
        [DisplayFormat(DataFormatString = "{0:N2}")]
        public decimal Price { get; set; }
        public string PriceFormatted => Price.ToString("N2");

        [Column(TypeName = "decimal(18,2)")]
        [DisplayFormat(DataFormatString = "{0:N2}")]
        public decimal OriginalPrice { get; set; }
        public string OriginalPriceFormatted => Price.ToString("N2");
    }

}