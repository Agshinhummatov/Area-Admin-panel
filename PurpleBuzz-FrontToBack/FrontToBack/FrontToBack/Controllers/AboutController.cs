using FrontToBack.Data;
using FrontToBack.Models;
using FrontToBack.Models.About;
using FrontToBack.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FrontToBack.Controllers
{
    public class AboutController : Controller
    {
        private readonly AppDbContext _context;

        public AboutController(AppDbContext context)
        {
            _context = context;
        }


        public async Task<IActionResult> Index()
        {

            IEnumerable<AboutUs> aboutUs = await _context.AboutUs.Where(m => !m.SoftDelete).ToListAsync();

            IEnumerable<Team> teams = await _context.Teams.Where(m => !m.SoftDelete).ToListAsync();

            IEnumerable<TeamMember> teamMembers = await _context.TeamMembers.Where(m => !m.SoftDelete).ToListAsync();


            AboutVM model = new()
            {
                
                AboutUs = aboutUs,
                Teams = teams,
                TeamMembers = teamMembers,

            };


            return View(model);
        }
    }
}
