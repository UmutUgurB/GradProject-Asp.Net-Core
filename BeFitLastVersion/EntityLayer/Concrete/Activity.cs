namespace EntityLayer.Concrete
{
    public class Activity
    {
        public int ActivityID { get; set; }
        public string? ActivityName { get; set; }
        public string? ActivityDescription{ get; set; }
        public int ActivityCapacity { get; set; }
        public bool ActivityIsActive { get; set; }
        public int FounderID { get; set; }
        public User Founder { get; set; }
        public virtual ICollection<ActivityUser> ActivityUsers { get; set; }
        

    }
}
