using FrontToBack.Models;

namespace FrontToBack.ViewModels
{
    public class HomeVM
    {

        public IEnumerable<Slider> Sliders { get; set; }

        public IEnumerable<InfoService> InfoServices { get; set; }

        public IEnumerable<Category> Categories { get; set; }



        public IEnumerable<Work> Works { get; set; }


        public IEnumerable<RecentWork> RecentWorks { get; set; }

        public SliderBackground sliderBackground { get; set; }
    }
}
