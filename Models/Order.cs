﻿using System;
using System.Collections.Generic;

namespace MobileStoreWebsiteV1._3.Models
{
    public partial class Order
    {
        public int OrderId { get; set; }
        public string? OrderDate { get; set; }
        public string? OrderBalance { get; set; }
        public string? OrderStreet { get; set; }
        public string? OrderCity { get; set; }
        public string? OrderBuilding { get; set; }
        public string? OrderStatus { get; set; }
        public string? OrderDeliveredData { get; set; }
        public int? ProductId { get; set; }
        // public string? UserId { get; set; }
        public string? IdentityUserId { get; set; }
        public virtual Product? Product { get; set; }
        public virtual Microsoft.AspNetCore.Identity.IdentityUser? IdentityUser { get; set; }
    }
}
