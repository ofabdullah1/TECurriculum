-- 17. The titles and taglines of movies that are in the "Family" genre that Samuel L. Jackson has acted in.
-- Order the results alphabetically by movie title.
-- (4 rows)

SELECT title, tagline FROM genre
INNER JOIN movie_genre
ON movie_genre.genre_id = genre.genre_id
INNER JOIN movie
ON movie.movie_id = movie_genre.movie_id
INNER JOIN movie_actor
on movie_actor.movie_id = movie.movie_id
WHERE movie_genre.genre_id = 10751 and movie_actor.actor_id = 2231
ORDER BY title;






