using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class ProjectedResaleValueChart
    {
        [Key]

        public int Id { get; set; }


        [Display(Name = "Pleae enter Retail Value of Shoe")]
        public int RetailValueOfShoe { get; set; }



        [Display(Name = "This is your Projected Resale Value of your shoe")]
        public int ProjectedResaleValue { get; set; }



        [Display(Name = "Limited Sneaker? If so, CLICK HERE, otherwise, leave box Unchecked! ")]
        public bool LimitedShoe { get; set; }



        [Display(Name = "Never Worn and Fresh out the Box? Click Here! If Shoe is Pre-owned, leave box UNCHECKED:")]
        public bool ShoeConditionNew { get; set; }


        


        [Display(Name = "Has shoe been released mutiple times, Click Here!")]
        public bool RetroedOften { get; set; }



        [Display(Name = "Was Shoe released or going to be released on Black Friday or Christmas? If so, Click Box!")]
        public bool HolidayShoe { get; set; }

    }
}