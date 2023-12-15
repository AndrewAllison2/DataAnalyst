namespace DataAnalyst.Controllers;

[ApiController]
[Route("api/[controller]")]
public class MusicController : ControllerBase
{
  private readonly MusicService _musicService;
  private readonly Auth0Provider _auth0Provider;

  public MusicController(MusisService musisService, Auth0Provider auth0Provider)
  {
    _musicService = musisService;
    _auth0Provider = auth0Provider;
  }

  [Authorize]
  [HttpPost]
  public async Task<ActionResult<Music>> CreateMusic([FromBody] Music musicData)
  {
    try 
    {
      Account userInfo = await _auth0Provider.GetUserInfoAsync<Account>(HttpContext);
      musicData.CreatorId = userInfo.Id;
      Music music = _musicService.CreateMusic(musicData);
      return OK(music);
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }
}
