using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Place
    {
        public int PlaceID { get; set; }
        public string? PlaceName { get; set; }
        public string? PlaceDescription { get; set; }
        public string? PlaceImage { get; set; }
        public bool TicketIsAvailable { get; set; }
        public List<Comment> Comments { get; set; }

    }
}
