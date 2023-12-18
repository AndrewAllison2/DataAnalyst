namespace DataAnalyst.Controllers;

[ApiController]
[Route("api/[controller]")]
public class MusicController : ControllerBase
{
  private readonly MusicService _musicService;
  private readonly Auth0Provider _auth0Provider;

  public MusicController(MusicService musicService, Auth0Provider auth0Provider)
  {
    _musicService = musicService;
    _auth0Provider = auth0Provider;
  }

  // [Authorize]
  [HttpPost]
  public ActionResult<Music> CreateMusic([FromBody] Music musicData)
  {
    try 
    {
      // Account userInfo = await _auth0Provider.GetUserInfoAsync<Account>(HttpContext);
      // musicData.CreatorId = userInfo?.Id;
      Music music = _musicService.CreateMusic(musicData);
      return (music);
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }

  [HttpGet]
  public ActionResult<List<Music>> GetMusic()
  {
    try 
    {
      List<Music> music = _musicService.GetMusic();
      return Ok(music);
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }
}
