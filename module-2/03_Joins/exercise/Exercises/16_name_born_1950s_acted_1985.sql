-- 16. The names and birthdays of actors born in the 1950s who acted in movies that were released in 1985.
-- Order the results by actor from oldest to youngest.
-- (20 rows)

SELECT DISTINCT person_name, birthday FROM movie
INNER JOIN movie_actor
ON movie_actor.movie_id = movie.movie_id
INNER JOIN person
ON person.person_id = movie_actor.actor_id
WHERE birthday > '1949/12/31' AND birthday < '1960/12/31' AND release_date > '1984/12/31' AND release_date < '1986/01/01'
ORDER BY birthday;
