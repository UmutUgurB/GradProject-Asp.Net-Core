namespace BeFit.Models
{
    public class AddPlaceImage
    {
        public int PlaceID { get; set; }
        public string? PlaceName { get; set; }
        public string? PlaceDescription { get; set; }
        public int PlaceScore { get; set; }
        public IFormFile? PlaceImage { get; set; }
        public bool TicketIsAvailable { get; set; }
    }
}
