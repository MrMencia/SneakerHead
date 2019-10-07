using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class ShoesForSale
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Brand of Shoe For Sale")]
        public BrandOfShoe BrandofShoeForSale { get; set; }


        [Display(Name = "Name of Shoe For Sale")]
        public string NameOfShoe { get; set; }


        [Display(Name = "Shoe Price")]
        public int ShoePrice { get; set; }


        [Display(Name = "Shoe Condition")]
        public ShoeCondition CondiciondeZapatos { get; set; }


        [Display(Name = "Selec Size of Shoe For Sale")]
        public ShoeSizeForSale GetShoeSizeForSale { get; set; }


        [ForeignKey("ApplicationUser")]
        public string ApplicationId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }

    }
    public enum ShoeCondition
    {
        New, PreOwned
    }
    public enum ShoeSizeForSale
    {
        One, OneHalf, Two, TwoHalf, Three, ThreeHalf, Four, FourHalf, Five, FiveHalf, Six, SixHalf, Seven, SevenHalf, Eight, EightHalf, Nine, NineHalf, Ten, TenHalf, Eleven, ElevenHalf, Twelve, TwelveHalf, Thirteen, ThirteenHalf, Fourteen, FourteenHalf, Fifteen, FifteenHalf, Sixteen, SixteenHalf, Seventeen, SeventeenHalf, Eightteen, EighteenHalf, Nineteen, NineteenHalf, Twenty
    }
    public enum BrandOfShoe
    {
        Nike, Jordan, Yeezy, Adidas, Lining
    }
}