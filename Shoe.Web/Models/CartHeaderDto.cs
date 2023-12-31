﻿using System.ComponentModel.DataAnnotations;

namespace Shoe.Web.Models
{
    public class CartHeaderDto
    {
        [Key]
        public int CartHeaderId { get; set; }
        public string UserId { get; set; }
        public string CouponCode { get; set; }
        public double OrderTotal {  get; set; }
    }
}
