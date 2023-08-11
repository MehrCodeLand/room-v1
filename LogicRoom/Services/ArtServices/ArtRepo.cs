

using Microsoft.EntityFrameworkCore;
using RoomLibrary.Models;
using RoomLibrary.MyDb_Room;

namespace LogicRoom.Services.ArtServices;

public class ArtRepo : IArtRepo
{
    private readonly MyDb _db;
    public ArtRepo(MyDb db)
    {
        _db = db ?? throw new ArgumentNullException(nameof(db));
    }

    #region Async Method
    public async Task<IEnumerable<Art>> GetAllArt()
    {
        return await _db.Arts.OrderBy(x => x.Create).ToListAsync();
    }

    #endregion
}
