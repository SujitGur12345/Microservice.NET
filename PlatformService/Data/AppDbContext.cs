namespace PlatformService.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> opt) : base(opt)
        {

        }

        //Defining The DBset 

        public DBset<Platform> Platforms { get ; set ;}
    }
}