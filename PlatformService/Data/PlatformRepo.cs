using PlatformService.Models;

namespace PlatformService.Data{

    public class PlatformRepo : IPlatformRepo
    {
        private readonly AppDbContext _context;

        public PlatformRepo(AppDbContext context)
        {
            _context = context;
        }
        public void CreatePlatfrom(Platform form)
        {
            if (form == null)
            {
                throw new ArgumentNullException(nameof(form));
            }

            _context.Platforms.Add(form);
        }

        public IEnumerable<Platform> GetAllPlatforms()
        {
            return _context.Platforms.ToList();
        }

        public Platform GetPlatformByID(int id)
        {
            return _context.Platforms.FirstOrDefault(t => t.ID == id);
        }

        public bool SaveChnages()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}