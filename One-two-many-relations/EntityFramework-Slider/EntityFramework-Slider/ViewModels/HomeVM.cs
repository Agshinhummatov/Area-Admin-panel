using EntityFramework_Slider.Models;

namespace EntityFramework_Slider.ViewModels
{
    public class HomeVM
    {
        public List<Slider> Sliders { get; set; }

        public SliderInfo SliderInfo { get; set; }
        public IEnumerable<Blog> Blogs { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<Product> Products { get; set; }

        public IEnumerable<About> Abouts { get; set; }

        public IEnumerable<Advance> Advances { get; set; }

        public IEnumerable<TeamExpert> TeamExperts { get; set; }

        public IEnumerable<Title> Titles { get; set; }

        public IEnumerable<Say> Says{ get; set; }

        public IEnumerable<SosialMedia> SosialMedias { get; set; }

        public Subscribe Subscribes { get; set; }




    }
}
