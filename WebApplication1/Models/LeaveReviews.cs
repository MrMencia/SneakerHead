using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class LeaveReviews
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Leave Review For a Seller Based on your Experience")]
        public string LeaveReviewsForSeller { get; set; }

        [Display(Name = "Experience Rate")]
        public RateSeller RateSellerBasedOnExperience { get; set; }

    }

    public enum RateSeller
    {
        One, Two, Three, Four, Five
    }
}