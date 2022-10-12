-- INNER JOIN

-- Write a query to retrieve the name and state abbreviation for the 2 cities named "Columbus" in the database

SELECT city_name, state_abbreviation FROM city WHERE city_name = 'Columbus';

-- Modify the previous query to retrieve the names of the states (rather than their abbreviations).

SELECT * FROM city 
INNER JOIN state 
ON state.state_abbreviation = city.state_abbreviation WHERE city_name = 'Columbus ';


SELECT city_name, state_name FROM city 
INNER JOIN state 
ON state.state_abbreviation = city.state_abbreviation WHERE city_name = 'Columbus ';


-- Write a query to retrieve the names of all the national parks with their state abbreviations.
-- (Some parks will appear more than once in the results, because they cross state boundaries.)

SELECT * FROM park
INNER JOIN park_state
ON  park_state.park_id = park.park_id;

--SELECT * FROM 1st table
--INNER JOIN 2nd table
--ON  2nd table.columnName = 1st table.columnName (two columns will be equivalent)

SELECT park_name, state_abbreviation FROM park
INNER JOIN park_state
ON  park_state.park_id = park.park_id;


-- The park_state table is an associative table that can be used to connect the park and state tables.
-- Modify the previous query to retrieve the names of the states rather than their abbreviations.

SELECT park_name, state.state_abbreviation, * FROM park
INNER JOIN park_state
ON  park_state.park_id = park.park_id
INNER JOIN state
ON state.state_abbreviation = park_state.state_abbreviation

-- Modify the previous query to include the name of the state's capital city.

SELECT park_name, state_name, city_name FROM park
INNER JOIN park_state
ON  park_state.park_id = park.park_id
INNER JOIN state
ON state.state_abbreviation = park_state.state_abbreviation
INNER JOIN city
ON city.city_id = state.capital


-- Modify the previous query to include the area of each park.

SELECT park_name, park.area, state_name, city_name capital FROM park
INNER JOIN park_state
ON  park_state.park_id = park.park_id
INNER JOIN state
ON state.state_abbreviation = park_state.state_abbreviation
INNER JOIN city
ON city.city_id = state.capital


SELECT park_name, park.area, state_name, city_name capital FROM park
JOIN park_state
ON  park_state.park_id = park.park_id
JOIN state
ON state.state_abbreviation = park_state.state_abbreviation
JOIN city
ON city.city_id = state.capital


SELECT park_name, p.area, state_name, city_name AS capital FROM park AS p
JOIN park_state
ON  park_state.park_id = p.park_id
JOIN state AS s
ON s.state_abbreviation = park_state.state_abbreviation
JOIN city
ON city.city_id = s.capital





-- Write a query to retrieve the names and populations of all the cities in the Midwest census region.

SELECT * FROM state As s
WHERE s.census_region = 'Midwest'

SELECT city_name, c.population, * FROM state s
JOIN city AS c ON c.state_abbreviation = s.state_abbreviation
WHERE s.census_region = 'Midwest'

-- Write a query to retrieve the number of cities in the city table for each state in the Midwest census region.


-- Modify the previous query to sort the results by the number of cities in descending order.



-- LEFT JOIN

-- Write a query to retrieve the state name and the earliest date a park was established in that state (or territory) for every record in the state table that has park records associated with it.

SELECT * FROM state as s
JOIN park_state AS ps ON ps.state_abbreviation = s.state_abbreviation
JOIN park AS p ON p.park_id = ps.park_id


SELECT state_name, min(p.date_established) FROM state as s
JOIN park_state AS ps ON ps.state_abbreviation = s.state_abbreviation
JOIN park AS p ON p.park_id = ps.park_id
GROUP BY state_name



-- Modify the previous query so the results include entries for all the records in the state table, even if they have no park records associated with them.

SELECT state_name, min(p.date_established) FROM state as s
LEFT JOIN park_state AS ps ON ps.state_abbreviation = s.state_abbreviation
LEFT JOIN park AS p ON p.park_id = ps.park_id
GROUP BY state_name





-- UNION

-- Write a query to retrieve all the place names in the city and state tables that begin with "W" sorted alphabetically. (Washington is the name of a city and a state--how many times does it appear in the results?)


-- Modify the previous query to include a column that indicates whether the place is a city or state.



-- MovieDB
-- After running the script to set up the MovieDB database, make sure it is selected in SSMS and confirm it is working correctly by writing queries to retrieve...

-- The names of all the movie genres


-- The titles of all the Comedy movies

