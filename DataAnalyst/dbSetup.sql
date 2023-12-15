USE DataAnalyst

CREATE TABLE IF NOT EXISTS accounts(
  id VARCHAR(255) NOT NULL primary key COMMENT 'primary key',
  createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created',
  updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update',
  name varchar(255) COMMENT 'User Name',
  email varchar(255) COMMENT 'User Email',
  picture varchar(255) COMMENT 'User Picture'
) default charset utf8 COMMENT '';

CREATE TABLE music(
  id INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
  performer VARCHAR(255) NOT NULL,
  song VARCHAR(255) NOT NULL,
  album VARCHAR(255),
  spotify_genre ENUM('Rock', 'Country', 'Pop', 'Electronic', 'Alternative'),
  spotify_track_preview_url VARCHAR(500),
  spotify_track_duration INT NOT NULL,
  spotify_track_popularity INT NOT NULL,
  spotify_track_explicit BOOLEAN DEFAULT false
  ) default charset utf8 COMMENT '';
