namespace EntityFramework_Slider.Models
{
    public class About:BaseEntity
    {
        public string? ImageName { get; set; }
       

        public string? Title { get; set; }

        public string? Description { get; set; }

        public ICollection<Advance> Advances { get; set; }

    }
}
