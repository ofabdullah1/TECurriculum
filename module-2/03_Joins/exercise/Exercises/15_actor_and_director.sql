-- 15. The title of the movie and the name of director for movies where the director was also an actor in the same movie.
-- Order the results by movie title (A-Z)
-- (73 rows)

SELECT DISTINCT person_name, title FROM movie
INNER JOIN movie_actor
ON movie_actor.movie_id = movie.movie_id
INNER JOIN person
ON person.person_id = movie_actor.actor_id
WHERE person.person_id = movie.director_id
ORDER BY title;
