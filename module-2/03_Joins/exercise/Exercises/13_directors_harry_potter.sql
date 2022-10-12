-- 13. The directors of the movies in the "Harry Potter Collection", sorted alphabetically.
-- (4 rows)

SELECT DISTINCT person_name FROM movie
INNER JOIN person
ON person.person_id = movie.director_id
WHERE title LIKE '%Harry Potter%'
ORDER BY person_name;
