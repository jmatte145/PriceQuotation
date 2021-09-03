using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PriceQuotation.Models
{
    using System.ComponentModel.DataAnnotations;
        public class SubtotalModel
        {
            [Required(ErrorMessage = "Please enter a valid subtotal.")]
            public decimal? Subtotal { get; set; }
            
            [Range (0,100, ErrorMessage = "Discount must be between 0 and 100%.")]
            [Required(ErrorMessage = "Please enter a valid discount percentage.")]
            public decimal? DiscountPercent { get; set; }

            public decimal? DiscountAmount { get; set; }

            public decimal? Total { get; set; }

            // Methods to calculate the Discount Amount and Final Item Price // 
            
            public decimal? CalculateDiscount()
            {
                decimal? discTotal = 0;
                discTotal = (Subtotal * (DiscountPercent/100));
                return discTotal;
            }
            public decimal? CalculatePrice()
            {
                decimal? total = 0;
                total = Subtotal - (Subtotal * (DiscountPercent/100));
                return total;
            }
        }
}
