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
    if (music == null)
    {
      throw new Exception("Nope");
    } 
    return music; 
  }

  internal List<Music> GetMusic()
  {
    List<Music> music = _musicRepository.GetMusic();
    return music;
  }
}
