-- 4. The titles and taglines of all the movies that are in the Fantasy genre. 
-- Order the results by title (A-Z).
-- (81 rows)

SELECT title, tagline FROM genre
INNER JOIN movie_genre
ON movie_genre.genre_id = genre.genre_id
INNER JOIN movie
ON movie_genre.movie_id = movie.movie_id
WHERE genre_name = 'Fantasy'
ORDER BY title;



