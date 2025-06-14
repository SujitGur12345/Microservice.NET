
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using PlatformService.Models;

namespace PlatformService.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> opt) : base(opt)
        {

        }

        //Defining The DBset 

        public DbSet<Platform> Platforms { get ; set ;}

        // internal int SaveChanges()
        // {
        //     throw new NotImplementedException();
        // }
    }
}