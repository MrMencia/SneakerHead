using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class SneakerSeller
    {

        [Key]
        public int Id { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }



        [Display(Name = "Last Name")]
        public string LastName { get; set; }


        [Display(Name = "Business Street Address")]
        public string StreetAddress { get; set; }


        [Display(Name = "City")]
        public string City { get; set; }


        [Display(Name = "State")]
        public string State { get; set; }


        [Display(Name = "Zip Code")]
        public int ZipCode { get; set; }



        [ForeignKey("ApplicationUser")]
        public string ApplicationId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }

      




    }
}