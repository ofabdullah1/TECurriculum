-- 6. The genres of "The Wizard of Oz" sorted in alphabetical order (A-Z).
-- (3 rows)

SELECT genre_name FROM genre
INNER JOIN movie_genre
ON movie_genre.genre_id = genre.genre_id
INNER JOIN movie
ON movie_genre.movie_id = movie.movie_id
WHERE title = 'The Wizard of OZ'
ORDER BY genre_name;
