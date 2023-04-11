using FrontToBack.Data;
using FrontToBack.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FrontToBack.Areas.Admin.Controllers
{
    [Area("Admin")]

    public class SliderController : Controller
    {


        private readonly AppDbContext _context;

        public SliderController(AppDbContext context)
        {
            _context = context;
        }


        public async Task<IActionResult> Index()
        {

            SliderBackground sliderBackground = await _context.sliderBackgrounds.Where(m => !m.SoftDelete).FirstOrDefaultAsync();


            return View(sliderBackground);
        }


        [HttpGet]
        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null) return BadRequest();

            SliderBackground? sliderBackground = await _context.sliderBackgrounds.FirstOrDefaultAsync(m => m.Id == id);

            if (sliderBackground is null) return NotFound();

            return View(sliderBackground);
        }


        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }


        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return BadRequest();

            SliderBackground? sliderBackground = await _context.sliderBackgrounds.FirstOrDefaultAsync(m => m.Id == id);

            if (sliderBackground is null) return NotFound();

            return View(sliderBackground);
        }





    }
}
