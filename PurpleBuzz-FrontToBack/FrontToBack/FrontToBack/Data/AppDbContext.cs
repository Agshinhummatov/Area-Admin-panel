using FrontToBack.Models;
using FrontToBack.Models.About;
using FrontToBack.Models.Contact;
using FrontToBack.Models.Pricing;
using Microsoft.EntityFrameworkCore;

namespace FrontToBack.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Slider> Sliders { get; set; }

        public DbSet<InfoService> InfoServices { get; set; }

        public DbSet<Category> Categories{ get; set; }

        public DbSet<Work> Works { get; set; }

        public DbSet<WorkImage> WorkImages { get; set; }


        public DbSet<RecentWork> RecentWorks { get; set;}


        public DbSet<AboutUs> AboutUs { get; set; }

        public DbSet<Team> Teams { get; set; }

        public DbSet<TeamMember> TeamMembers { get; set; }

        public DbSet<Banner> Banners { get; set; }


     

        public DbSet<Package> Packages { get; set; }

        public DbSet<OfferStandart> OfferStandarts { get; set; }

        public DbSet<OfferPlatinum> OfferPlatinums { get; set; }

        public DbSet<OfferPremium> OfferPremiums { get; set; }

        public DbSet<SliderBackground> sliderBackgrounds { get; set; }



    }
}
