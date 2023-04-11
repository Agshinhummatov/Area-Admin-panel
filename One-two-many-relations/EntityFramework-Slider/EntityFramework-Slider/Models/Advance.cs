namespace EntityFramework_Slider.Models
{
    public class Advance:BaseEntity
    {
        public string? Name { get; set; }

        public int AboutId { get; set; }

        public About About { get; set; }

    }
}
