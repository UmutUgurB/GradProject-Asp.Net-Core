using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class PlaceRating
    {
        public int PlaceRatingID { get; set; }
        public int PlaceID { get; set; }
        public int PlaceTotalScore { get; set; }
        public int PlaceRatingCount { get;set; }
        public double PlaceOrtalama { get; set; }


    }
}
