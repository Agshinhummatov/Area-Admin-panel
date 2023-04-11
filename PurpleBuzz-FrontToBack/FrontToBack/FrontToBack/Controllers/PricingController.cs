using FrontToBack.Data;
using FrontToBack.Models;
using FrontToBack.Models.Pricing;
using FrontToBack.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FrontToBack.Controllers
{
    public class PricingController : Controller
    {

        private readonly AppDbContext _context;
        public PricingController(AppDbContext context)
        {
            _context = context;
        }


        public async Task<IActionResult> Index()
        {
            IEnumerable<Package> packages = await _context.Packages.Where(m => !m.SoftDelete).ToListAsync();

            IEnumerable<OfferStandart> offerStandarts = await _context.OfferStandarts.Where(m => !m.SoftDelete).ToListAsync();

            IEnumerable<OfferPremium> offerPremiums = await _context.OfferPremiums.Where(m => !m.SoftDelete).ToListAsync();

            IEnumerable<OfferPlatinum> offerPlatinums = await _context.OfferPlatinums.Where(m => !m.SoftDelete).ToListAsync();


            PricingVM model = new()
            {
                Packages = packages,
                OfferStandarts = offerStandarts,
                OfferPlatinums = offerPlatinums,
                OfferPremiums = offerPremiums

            };

            return View(model);
        }
    }
}
