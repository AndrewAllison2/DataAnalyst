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
  artist VARCHAR(255) NOT NULL,
  song VARCHAR(255) NOT NULL,
  album VARCHAR(255),
  genre ENUM('DDD', 'Charles', 'Dubstep', 'HalfTime', 'Chill'),
  energy INT,
  songKey VARCHAR(100) NOT NULL,
  camelotKey VARCHAR(100),
  tempo INT NOT NULL,
  notes VARCHAR(2000),
  vibe ENUM('chill', 'heavy'),
  type ENUM('1st Drop', 'Second Drop', 'Breakdown', 'Transition', 'Double'),
  worksWith VARCHAR(1500)
  -- creatorId VARCHAR(255) NOT NULL,
  -- FOREIGN KEY(creatorId) REFERENCES accounts(id) ON DELETE CASCADE
  ) default charset utf8 COMMENT '';


DROP TABLE music;

INSERT INTO music (artist, song, album, genre, energy, songKey, tempo)
VALUES ('CloZee', 'Visions', 'Microworlds', 'Charles', '3', 'F#', '130');

