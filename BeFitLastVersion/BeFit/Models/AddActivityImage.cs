namespace BeFit.Models
{
    public class AddActivityImage
    {
        public int ActivityID { get; set; }
        public string? ActivityName { get; set; }
        public string? ActivityDescription { get; set; }
        public int ActivityCapacity { get; set; }
        public IFormFile? ActivityImage { get; set; }
        public bool ActivityIsActive { get; set; }
    }
}
