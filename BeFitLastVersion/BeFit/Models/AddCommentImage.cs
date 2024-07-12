namespace BeFit.Models
{
    public class AddCommentImage
    {
        public int CommentID { get; set; }
        public string? CommentUserName { get; set; }
        public string? CommentTitle { get; set; }
        public string? CommentContent { get; set; }
        public IFormFile CommentImage { get; set; } 
        public int PlaceScore { get; set; }
        public DateTime CommentDate { get; set; }
    }
}
