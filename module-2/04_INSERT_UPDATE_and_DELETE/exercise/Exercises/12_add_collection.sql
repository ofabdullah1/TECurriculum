-- 12. Create a "Bill Murray Collection" in the collection table. For the movies that have Bill Murray in them, set their collection ID to the "Bill Murray Collection". (1 row, 6 rows)



INSERT INTO collection(collection_name)
VALUES('Bill Murray Collection')


SELECT * FROM person
WHERE person_name = 'Bill Murray'

SELECT * FROM movie_actor
WHERE actor_id = 1532;


UPDATE movie
SET collection_id = 895483
WHERE movie_id IN (137, 10315, 10433, 83666, 120467, 399174)












