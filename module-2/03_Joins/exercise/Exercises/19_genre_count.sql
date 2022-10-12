-- 19. The genre name and the number of movies in each genre. Name the count column 'num_of_movies'.
-- Order the results from the highest movie count to the lowest.
-- (19 rows, the highest expected count is around 400).

SELECT DISTINCT movie.title, genre.genre_name, COUNT(movie.title) as num_of_movies FROM genre
INNER JOIN movie_genre
ON movie_genre.genre_id = genre.genre_id
INNER JOIN movie
ON movie.movie_id = movie_genre.movie_id;




COUNT(movie.title) as num_of_movies
