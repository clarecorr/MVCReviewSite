using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCReviewSite.Models
{
    public class Review
    {
        [Key] //Primary Key
        public int ReviewID { get; set; }
        public string Title { get; set; }
        public string ReviewerName { get; set; }
        public string Content { get; set; }
        [DataType(DataType.Date)] 
        public DateTime Date { get; set; }
        public bool WouldRecommend { get; set; }

        [ForeignKey("Category")]
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }
    }
}