using Microsoft.EntityFrameworkCore;
namespace csharpExam.Models 
{
    //  the MyContext class respresenting a session with our MySQL
    // database allowing us to query for or save data
    public class MyContext : DbContext {
        public MyContext(DbContextOptions options) : base(options) { }

        //MAKE SURE TO ADD YOUR MODELS HERE


        // public DbSet<ModelInstance> ModelInstances { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Activity> Activities { get; set; }
        public DbSet<Participant> Participants { get; set; }
    }
}