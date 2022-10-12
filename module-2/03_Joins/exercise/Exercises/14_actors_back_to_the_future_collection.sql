-- 14. The names of actors who've appeared in the movies in the "Back to the Future Collection", sorted alphabetically.
-- (28 rows)

SELECT DISTINCT person_name from collection
INNER JOIN movie
ON movie.collection_id = collection.collection_id
INNER JOIN movie_actor
ON movie_actor.movie_id = movie.movie_id
INNER JOIN person
ON person.person_id = movie_actor.actor_id
WHERE collection_name LIKE '%Future%'
ORDER BY person_name;

