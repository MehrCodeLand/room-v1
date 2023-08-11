using RoomLibrary.Models;

namespace LogicRoom.Services.ArtServices
{
    public interface IArtRepo
    {
        Task<IEnumerable<Art>> GetAllArt();
    }
}