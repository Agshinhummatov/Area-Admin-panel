using FrontToBack.Models;
using FrontToBack.Models.About;

namespace FrontToBack.ViewModels
{
    public class AboutVM
    {
        public IEnumerable<AboutUs> AboutUs { get; set; }

        public IEnumerable<Team> Teams { get; set; }

        public IEnumerable<TeamMember> TeamMembers { get; set; }

    }
}
