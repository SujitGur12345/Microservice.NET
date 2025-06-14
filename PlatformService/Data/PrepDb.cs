using System.Xml.Serialization;
using PlatformService.Models;

namespace PlatformService.Data
{
    public static class PrepDb
    {
        public static void PrepPopulation(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                SeedData(serviceScope.ServiceProvider.GetService<AppDbContext>());
            }
        }

        private static void SeedData(AppDbContext context)
        {
            if (!context.Platforms.Any())
            {
                Console.WriteLine("---> Seeded Data");

                context.Platforms.AddRange(
                    new Platform()
                    {
                        Name = "Dotnet",
                        Publisher = "Microsoft",
                        Cost = "Free Open Source",

                    },

                    new Platform()
                    {
                        Name = "SQL Server Express",
                        Publisher = "Microsoft",
                        Cost = "Free Open Source",

                    },

                    new Platform()
                    {
                        Name = "Kubernetes",
                        Publisher = "Cloud Native Computing Foundation",
                        Cost = "Free Open Source",

                    }
                );

                context.SaveChanges();
            }
            else
            {
                Console.WriteLine("---> We already Have Data");
            }
        }
    }
}