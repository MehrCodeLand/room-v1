using LogicRoom.Services.ArtServices;
using Microsoft.AspNetCore.Mvc;
using RoomLibrary.Models;

namespace room_v1.Controllers;

[Route("art/api/[controller]")]
[ApiController]
public class ArtController : ControllerBase
{

    private readonly IArtRepo _artRepo;
    public ArtController( IArtRepo artRepo)
    {
        _artRepo = artRepo;
    }


    [HttpGet]
    public async Task<ActionResult<IEnumerable<Art>>> GetArts()
    {
        var arts = await _artRepo.GetAllArt();

        return Ok(arts);
    }



}
