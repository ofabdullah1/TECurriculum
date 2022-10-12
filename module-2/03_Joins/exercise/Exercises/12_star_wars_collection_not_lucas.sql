-- 12. The titles of the movies in the "Star Wars Collection" that weren't directed by George Lucas, sorted alphabetically.
-- (5 rows)





SELECT title FROM collection
INNER JOIN movie
ON movie.collection_id = collection.collection_id
WHERE collection_name LIKE '%Star Wars%' AND director_id !=1
ORDER BY title;
