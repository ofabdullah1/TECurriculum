-- 5. The titles and release dates of all the movies that are in the Comedy genre. 
-- Order the results by release date, earliest to latest. 
-- (220 rows)

SELECT title, release_date FROM genre
INNER JOIN movie_genre
ON movie_genre.genre_id = genre.genre_id
INNER JOIN movie
ON movie_genre.movie_id = movie.movie_id
WHERE genre_name = 'Comedy'
ORDER BY release_date;
