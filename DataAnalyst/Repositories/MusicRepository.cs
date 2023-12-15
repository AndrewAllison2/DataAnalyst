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
    INSERT INTO music (artist, song, album, genre, energy, songKey, camelotKey, tempo, notes, vibe, worksWith, creatorId)
    VALUES (@Artist, @Song, @Album, @Genre, @Energy, @SongKey, @CamelotKey, @Tempo, @Notes, @Vibe, @Type, @WorksWith, @CreatorId);
    SELECT LAST_INSERT_ID()
    ;";

    int music = _db.ExecuteScalar<int>(sql, musicData);
    return music;
  }

  internal Music GetMusicById(int musicId)
  {
    string sql = @"
    SELECT * FROM music
    WHERE music.id = @musicId LIMIT 1
    ;";

    Music music = _db.Query<Music>(sql, musicId);
    return music;
  }
}
