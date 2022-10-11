-- SELECT
-- Use a SELECT statement to return a literal string
SELECT 'Hello There!';

-- Use a SELECT statement to add two numbers together (and label the result "sum")
SELECT 6 + 5;


-- SELECT ... FROM
-- Write queries to retrieve...

-- The names from all the records in the state table

SELECT * FROM state;

SELECT state_name FROM state;

-- The names and populations of all cities

SELECT * FROM city;

SELECT city_name, population FROM city;

-- All columns from the park table

SELECT * FROM park;

-- SELECT __ FROM __ WHERE
-- Write queries to retrieve...

-- The names of cities in California (CA)

SELECT * FROM city WHERE state_abbreviation = 'CA'; 

-- The names and state abbreviations of cities NOT in California

SELECT * FROM city WHERE state_abbreviation != 'CA'; 

SELECT city_name AS CITY, state_abbreviation AS STATE FROM city WHERE state_abbreviation != 'CA'; 

-- The names and areas of cities smaller than 25 square kilometers 

SELECT * FROM city;

SELECT city_name, area FROM city WHERE area < 25;


-- The names from all records in the state table that have no assigned census region
SELECT * FROM state;

SELECT * FROM state WHERE census_region IS NULL;

-- The names and census regions from all records in the state table that have an assigned census region

SELECT * FROM state;

SELECT state_name, census_region FROM state WHERE census_region IS NOT NULL;


-- WHERE with AND/OR
-- Write queries to retrieve...

-- The names, areas, and populations of cities smaller than 25 sq. km. with more than 100,000 people

SELECT * FROM city;

SELECT city_name, area, population FROM city WHERE area < 25 AND population > 100000;

-- The names and census regions of all states (and territories and districts) not in the Midwest region (including those that don't have any census region)
SELECT * FROM state;

SELECT state_name, census_region FROM state WHERE census_region IS NOT NULL AND census_region != 'Midwest';


-- The names, areas, and populations of cities in California (CA) or Florida (FL)
SELECT * FROM city WHERE state_abbreviation IN ('CA', 'FL')

-- The names, areas, and populations of cities in New England -- Connecticut (CT), Maine (ME), Massachusetts (MA), New Hampshire (NH), Rhode Island (RI) and Vermont (VT)
SELECT city_name, area, population FROM city WHERE state_abbreviation IN ('CT', 'ME', 'MA', 'NH', 'RI', 'VT')


-- SELECT statements involving math
-- Write a query to retrieve the names and areas of all parks in square METERS
-- (the values in the database are stored in square kilometers)
-- Label the second column "area_in_square_meters"

SELECT * FROM park
SELECT area *1000000 AS area_in_square_meters ,* FROM park;

-- All values vs. distinct values

SELECT * FROM city;

SELECT state_abbreviation FROM city;

SELECT DISTINCT state_abbreviation FROM city;

-- Write a query to retrieve the names of all cities and notice repeats (like Springfield and Columbus)


-- Do it again, but without the repeats (note the difference in row count)



-- LIKE
-- Write queries to retrieve...

-- The names of all cities that begin with the letter "A"

SELECT * FROM city;

SELECT * FROM city WHERE city_name Like 'A%';

SELECT * FROM city WHERE city_name Like '%y';

SELECT * FROM city WHERE city_name Like '%town%';


-- The names of all cities that end with "Falls"


-- The names of all cities that contain a space



-- BETWEEN
-- Write a query to retrieve the names and areas of parks of at least 100 sq. kilometers but no more than 200 sq. kilometers

SELECT * FROM park WHERE area BETWEEN 100 AND 200;

-- DATES
-- Write a query to retrieve the names and dates established of parks established before 1900

SELECT * FROM park WHERE date_established < '1900-01-01'

SELECT * FROM city WHERE population < 100000;
