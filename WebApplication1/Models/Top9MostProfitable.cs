using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Top9MostProfitable
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Name of Sneaker")]
        public string SneakerName { get; set; }


        [Display(Name = "Estimated Retail Price")]
        public string RetailValue { get; set; }


        [Display(Name = "Estimated Retail Value")]
        public string ResaleValue { get; set; }


        [Display(Name = "Value Increase ")]
        public string ValueIncrease { get; set; }


    }
}