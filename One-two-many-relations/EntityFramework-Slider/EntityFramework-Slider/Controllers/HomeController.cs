using EntityFramework_Slider.Data;
using EntityFramework_Slider.Models;
using EntityFramework_Slider.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace EntityFramework_Slider.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            List<Slider> sliders = await _context.Sliders.ToListAsync();

            SliderInfo sliderInfo = await _context.SliderInfos.FirstOrDefaultAsync();

            IEnumerable<Blog> blogs = await _context.Blogs.Where(m=>!m.SoftDelete).ToListAsync();

            IEnumerable<Category> categories = await _context.Categories.Where(m => !m.SoftDelete).ToListAsync();

            IEnumerable<Product> products = await _context.Products.Include(m=>m.Images).Where(m => !m.SoftDelete).ToListAsync();

            IEnumerable<About> abouts = await _context.Aboutes.Where(m =>!m.SoftDelete).ToListAsync();

            IEnumerable<Advance> advances = await _context.Advances.Where(m =>!m.SoftDelete).ToListAsync();

            IEnumerable<Title> titles = await _context.Titles.Where(m =>!m.SoftDelete).ToListAsync();

            IEnumerable<TeamExpert> teamExperts = await _context.TeamExperts.Where(m => !m.SoftDelete).ToListAsync();

            Subscribe subscribes = await _context.Subscribes.FirstOrDefaultAsync();


            IEnumerable<Say> says = await _context.Says.Where(m => !m.SoftDelete).ToListAsync();

            IEnumerable<SosialMedia> sosialMedias = await _context.SosialMedias.Where(m => !m.SoftDelete).ToListAsync();


            HomeVM model = new()
            {
                Sliders = sliders,
                SliderInfo = sliderInfo,
                Blogs = blogs,
                Categories = categories,
                Products = products,
                Abouts= abouts,
                Advances = advances,
                TeamExperts = teamExperts,
                Titles = titles,
                Subscribes = subscribes,
                Says = says,
                SosialMedias = sosialMedias
                
            };

            return View(model);
        }
    }
}