﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCReviewSite.Models
{
    public class Category
    {
        [Key] //Primary Key
        public int CategoryID { get; set; }
        [Display(Name="Category Name")]
        public string Name { get; set; }

        public virtual ICollection<Review> Reviews { get; set; }
    }
}