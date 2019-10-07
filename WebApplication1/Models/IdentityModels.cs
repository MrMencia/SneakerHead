using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace WebApplication1.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {

        public DbSet<SneakerBuyer> SneakerBuyers { get; set; }

        public DbSet<SneakerSeller> SneakerSellers { get; set; }

        public DbSet<Top9MostProfitable> Top9MostProfitables { get; set; }
        public object Top9MostProfitable { get; internal set; }

        public DbSet<ShoesForSale> ZapatosParaVenda  { get; set; }
        public object ShoesForSale { get; internal set; }

        public DbSet<ProjectedResaleValueChart> ProjectedResaleValueChart { get; set; }

        public DbSet<LeaveReviews> leaveReviews { get; set; }
        public object SellerReviews { get; internal set; }


        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}