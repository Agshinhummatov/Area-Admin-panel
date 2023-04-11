using EntityFramework_Slider.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityFramework_Slider.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<SliderInfo> SliderInfos { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<Category> Categories { get; set; }



        public DbSet<About> Aboutes { get; set; }
        public DbSet<Advance> Advances { get; set; }



        public DbSet<TeamExpert> TeamExperts { get; set; }
        public DbSet<Title> Titles { get; set; }


        public DbSet<Subscribe> Subscribes { get; set; }

        public DbSet<Say> Says { get; set; }


        public DbSet<SosialMedia> SosialMedias { get; set; }









    }
}
