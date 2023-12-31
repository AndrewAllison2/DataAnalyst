using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataAnalyst.Repositories;

public class MusicRepository
{
  private readonly IDbConnection _db;

  public MusicRepository(IDbConnection db)
  {
    _db = db;
  }

  internal int CreateMusic(Music musicData)
  {
    string sql = @"
    INSERT INTO music (artist, song, album, genre, energy, songKey, camelotKey, tempo, notes, vibe, worksWith)
    VALUES (@Artist, @Song, @Album, @Genre, @Energy, @SongKey, @CamelotKey, @Tempo, @Notes, @Vibe, @Type, @WorksWith);
    SELECT LAST_INSERT_ID()
    ;";

    int music = _db.ExecuteScalar<int>(sql, musicData);
    return music;
  }

  internal Music GetMusicById(int musicId)
  {
    string sql = @"
    SELECT * 
    FROM music
    WHERE id = @musicId LIMIT 1
    ;";

    Music music = _db.QueryFirstOrDefault<Music>(sql, new { musicId });
    return music;
  }

  internal List<Music> GetMusic()
  {
    string sql = @"
    SELECT * FROM music;";

    List<Music> music = _db.Query<Music>(sql).ToList();
    return music;
  }
}
