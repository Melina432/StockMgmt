using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StockMgmt.Models
{
    public class PurchaseDetails
    {
        [ForeignKey("PurchaseId")]
        public int PurchaseId { get; set; }
        [Required(ErrorMessage = "Product code is required.")]
        public string ProductCode { get; set; }
        public int ProductQuantity { get; set; }
        public decimal ProductPrice { get; set; }
        public decimal PurchaseAmount { get; set; }
        public virtual ProductPurchase Pur {get; set;}
    } 
    public class ProductPurchase
    {
        [Key]
        public string PurchaseId { get; set; }
        public DateTime PurchaseDate { get; set; }
        public string PurchaseTo { get; set; }
        public string Vendorname { get; set; }
        public string VendorAddress { get; set; }
        public string VendorContact { get; set; }
     //   public virtual List<ProductPurchaseDetails> ProductPurchaseDetails { get; set; }


    }
}
