using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;



namespace DataAccessLayer.Concrete
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=MSI\\SQLEXPRESS;Database=Be_Fit24DB;Trusted_Connection=True;Encrypt=False;");
        }
        public DbSet<Manager> Managers { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Meal> Meals { get; set; }
        public DbSet<UserExerciseProgram> UserExercisePrograms { get; set; }
        public DbSet<ExerciseProgram> ExercisePrograms { get; set; }
        public DbSet<MealPlan> MealPlans { get; set; }
        public DbSet<Exercise> Exercises { get; set; }
        
        public DbSet<User> Users { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Food> Foods { get; set; }
        
        public DbSet<ExerciseExerciseProgram> ExerciseExercisePrograms { get; set; }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Day> Days { get; set; }
        public DbSet<Week> Weeks { get; set; }
        public DbSet<Activity> Activities{ get; set; }
        public DbSet<ActivityUser> ActivityUsers { get; set; }

        public DbSet<Department> Departments { get; set; }
        public DbSet<Place> Places { get; set; }
        public DbSet<PlaceRating> PlaceRatings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<ActivityUser>()
           .HasKey(au => new { au.ActivityID, au.UserID });

            modelBuilder.Entity<ActivityUser>()
                .HasOne(au => au.Activity)
                .WithMany(a => a.ActivityUsers)
                .HasForeignKey(au => au.ActivityID);

            modelBuilder.Entity<ActivityUser>()
                .HasOne(au => au.User)
                .WithMany(u => u.ActivityUsers)
                .HasForeignKey(au => au.UserID);

            // Define one-to-many relationship for Activity and its Founder
            modelBuilder.Entity<Activity>()
                .HasOne(a => a.Founder)
                .WithMany()
                .HasForeignKey(a => a.FounderID)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<UserExerciseProgram>()
           .HasKey(uep => new { uep.UserID, uep.ExerciseProgramId });

            modelBuilder.Entity<UserExerciseProgram>()
                .HasOne(uep => uep.User)
                .WithMany(u => u.UserExercisePrograms)
                .HasForeignKey(uep => uep.UserID);

            modelBuilder.Entity<UserExerciseProgram>()
                .HasOne(uep => uep.ExerciseProgram)
                .WithMany(ep => ep.UserExercisePrograms)
                .HasForeignKey(uep => uep.ExerciseProgramId);
            modelBuilder.Entity<Place>().ToTable(tb => tb.HasTrigger("AddPlaceInRatingTable"));

            modelBuilder.Entity<Comment>().ToTable(tb => tb.HasTrigger("UpdatePlaceOrtalama"));

        }
    }
}
