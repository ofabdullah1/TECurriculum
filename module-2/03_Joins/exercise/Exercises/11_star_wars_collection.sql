-- 11. The titles of the movies in the "Star Wars Collection" ordered by release date, most recent first. 
-- (9 rows)

SELECT title FROM collection
INNER JOIN movie
ON movie.collection_id = collection.collection_id
WHERE collection_name LIKE '%Star Wars%'
ORDER BY release_date DESC;
