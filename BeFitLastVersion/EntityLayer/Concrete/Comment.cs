using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Comment
    {
        public int CommentID { get; set; }
        public string? CommentUserName { get; set; }
        public string? CommentTitle { get; set; }
        public string? CommentContent { get; set; }
        public string? CommentImage { get; set; }   
        public int PlaceScore { get; set; }
        public DateTime CommentDate{ get; set; }
        public int PlaceID { get; set; }
        public Place Place { get; set; }
    }
}
