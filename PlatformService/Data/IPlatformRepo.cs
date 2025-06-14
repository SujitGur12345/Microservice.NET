using PlatformService.Models;

namespace PlatformService.Data
{
    public interface IPlatformRepo{

        bool SaveChnages();

        IEnumerable<Platform> GetAllPlatforms();

        Platform GetPlatformByID(int id);

        void CreatePlatfrom (Platform form);
    }


}