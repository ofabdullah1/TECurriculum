-- 3. For all actors with the last name of "Jones", display the actor's name and movie titles they appeared in. 
-- Order the results by the actor names (A-Z) and then by movie title (A-Z). 
-- (48 rows)

SELECT title, person_name FROM movie
INNER JOIN movie_actor
ON movie_actor.movie_id = movie.movie_id
INNER JOIN person
ON person.person_id = movie_actor.actor_id
WHERE person_name LIKE '% JONES'
ORDER BY person_name ASC, title ASC;



