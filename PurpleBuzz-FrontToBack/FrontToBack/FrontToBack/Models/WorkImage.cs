namespace FrontToBack.Models
{
    public class WorkImage:BaseEntity
    {

        public string? Image { get; set; }


        public bool IsMain { get; set; }
        public int WorkId { get; set; }

        public Work Work { get; set; }


    }
}
