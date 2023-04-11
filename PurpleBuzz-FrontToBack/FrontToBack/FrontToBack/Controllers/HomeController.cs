using FrontToBack.Data;
using FrontToBack.Models;
using FrontToBack.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;

namespace FrontToBack.Controllers
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
            SliderBackground sliderBackground = await _context.sliderBackgrounds.Where(m => !m.SoftDelete).FirstOrDefaultAsync();

            IEnumerable<Slider> sliders = await _context.Sliders.Where(m => !m.SoftDelete).ToListAsync();

            IEnumerable<InfoService> infoServices = await _context.InfoServices.Where(m => !m.SoftDelete).ToListAsync();

            IEnumerable<Category> categories = await _context.Categories.Where(m => m.SoftDelete == false).ToListAsync();

            IEnumerable<Work> works = await _context.Works.Where(m => m.SoftDelete == false).Include(m => m.WorkImages).Include(m => m.Category).ToListAsync();

            IEnumerable<RecentWork> recentWorks = await _context.RecentWorks.Where(m => m.SoftDelete == false).ToListAsync();


            HomeVM model = new()
            {
                Sliders = sliders,
                InfoServices = infoServices,
                Categories = categories,
                Works = works,
                RecentWorks = recentWorks,
                sliderBackground = sliderBackground

            };

            return View(model);
        }

       

     
    }
}