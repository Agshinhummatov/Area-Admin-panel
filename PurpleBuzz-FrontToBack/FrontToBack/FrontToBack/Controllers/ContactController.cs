using FrontToBack.Data;
using FrontToBack.Models.About;
using FrontToBack.Models.Contact;
using FrontToBack.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Runtime.InteropServices;

namespace FrontToBack.Controllers
{
    public class ContactController : Controller
    {

        private readonly AppDbContext _context;
        public ContactController(AppDbContext context)
        {
            _context = context;
        }


        public async Task<IActionResult> Index()
        {
            IEnumerable<Banner> banners = await _context.Banners.Where(m => !m.SoftDelete).ToListAsync();

            ContactVM model = new()
            {
                Banners= banners
            };

            return View(model);
        }
    }
}
