﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace WebsiteGiay.Models
{
    public class Brand
    {

        [Key]
        public int BrandID { get; set; }
        public string BrandName { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}