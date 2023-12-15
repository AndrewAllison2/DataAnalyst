namespace DataAnalyst.Services;

public class MusicService
{
  private readonly MusicRepository _musicRepository;

  public MusicService(MusicRepository musicRepository)
  {
    _musicRepository = musicRepository;
  }

  internal Music CreateMusic(Music musicData)
  {
    int musicId = _musicRepository.CreateMusic(musicData);

    Music music = GetMusicById(musicId);
    return music;
  }

  internal Music GetMusicById(int musicId)
  {
    Music music = _musicRepository.GetMusicById(musicId);
    if (music === null)
    {
      throw new Exception('Cannot find this song!')
    }
    return music;
  }
}
