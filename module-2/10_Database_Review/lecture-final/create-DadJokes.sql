USE master;
GO

DROP DATABASE IF EXISTS DadJokes;
GO

CREATE DATABASE DadJokes;
GO

USE DadJokes;
GO

-- Create a Humor Table
CREATE TABLE [HumorLevel] (
	-- PK
	level_id int identity(1,1) PRIMARY KEY,
	name nvarchar(30) NOT NULL UNIQUE
)

-- Insert some Humor Levels
INSERT INTO [HumorLevel] (name) VALUES
('Crime Against Humanity'),
('Charity Laugh'),
('Snort Inducer'),
('Giggler'),
('Tummy-Rumbler'),
('Knee Slapper')
GO

SELECT * FROM HumorLevel

-- Create a Joke Table. Relate the joke table to the humor table.
CREATE TABLE [Joke] (
	-- PK
	joke_id int identity (1000,1) PRIMARY KEY,
	-- Foreign Key to Humor Level
	humor_level_id int NOT NULL, -- FOREIGN KEY REFERENCES HumorLevel (level_id)
	-- Joke Text: Setup, Punchline
	setup nvarchar(MAX) NOT NULL,
	punchline nvarchar(250) NOT NULL,
	-- Nice to have: When to use, Context, Category

	CONSTRAINT FK_Joke_HumorLevel FOREIGN KEY (humor_level_id) REFERENCES HumorLevel (level_id)
)

-- Insert some dad jokes
INSERT INTO Joke (setup, punchline, humor_level_id) VALUES
('As a programmer, sometimes I feel a void', 'That is when I know I have hit the point of no return', 2),
('Why does Yoda always write crashing code?', 'There is no try', 4),
('What do you call this: ["hip", "hip"]', 'A hip, hip array', 6),
('Why do Communists hate OOP?', 'All of the classes...', 1),
('I was having a hard time checking in code', 'But now I git it.', 3),
('What do you call a skinny ghost?', 'A BOO-lean', 1)
GO

--SELECT * FROM Joke

-- Write SQL to select jokes from the dad-a-base

SELECT j.joke_id AS id, j.setup, j.punchline, h.name AS humor_level FROM Joke j INNER JOIN HumorLevel h ON h.level_id = j.humor_level_id ORDER BY h.level_id DESC, j.setup ASC, j.punchline ASC
