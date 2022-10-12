-- ORDERING RESULTS

-- Populations of all states from largest to smallest.

SELECT * FROM state;

SELECT * FROM state ORDER BY population;

SELECT * FROM state ORDER BY area ASC;

SELECT * FROM city ORDER BY area DESC;

SELECT * FROM city ORDER BY state_abbreviation ASC;

SELECT * FROM city ORDER BY state_abbreviation, population DESC;

-- States sorted alphabetically (A-Z) within their census region. The census regions are sorted in reverse alphabetical (Z-A) order.
SELECT * FROM state ORDER BY census_region ASC;

SELECT * FROM state ORDER BY census_region DESC;

-- The biggest park by area

SELECT TOP 1 * FROM park ORDER BY area DESC ;



-- LIMITING RESULTS

-- The 10 largest cities by populations

SELECT * FROM city;

SELECT TOP 10 * FROM city ORDER BY population DESC;


-- The 20 oldest parks from oldest to youngest in years, sorted alphabetically by name.

SELECT TOP 20 * FROM park ORDER BY date_established;

SELECT * FROM park WHERE park_id IN (61,53,3,44,13) ORDER BY park_name;

SELECT * FROM park WHERE park_id IN (SELECT TOP 20 park_id FROM park ORDER BY date_established) ORDER BY park_name;


-- CONCATENATING OUTPUTS

-- All city names and their state abbreviation.

SELECT city_name + ', ' + state_abbreviation AS city_and_state ,* FROM city;


-- All park names and area


-- The census region and state name of all states in the West & Midwest sorted in ascending order.

SELECT census_region + ' - ' + state_name CensusANDState, * FROM state 
WHERE census_region IN ('West', 'Midwest')
ORDER By CensusAndState

-- AGGREGATE FUNCTIONS

-- Average population across all the states. Note the use of alias, common with aggregated values.

SELECT * FROM state;

SELECT AVG(population) AS average_population FROM state;

SELECT AVG(population) AS average_population, Count(*) AS number_of_rows FROM state;

-- Total population in the West and South census regions

SELECT sum(population) FROM state WHERE census_region IN ('West', 'South') AND state_nickname IS NOT NULL;


-- The number of cities with populations greater than 1 million

SELECT Count(*) FROM city WHERE population > 1000000;

-- The number of state nicknames.

SELECT Count(state_nickname) FROM state;

-- The area of the smallest and largest parks.

SELECT * FROM park;

SELECT MIN(area) FROM park;

SELECT Max(area) FROM park;

SELECT MIN(area), MAX(area), AVG(area), SUM(area) FROM park


-- GROUP BY

-- Count the number of cities in each state, ordered from most cities to least.

SELECT * FROM city;

SELECT state_abbreviation FROM city GROUP BY state_abbreviation;

SELECT DISTINCT state_abbreviation FROM city;

SELECT state_abbreviation, COUNT(*) AS number_of_cities FROM city GROUP BY state_abbreviation;

SELECT state_abbreviation, COUNT(*) AS number_of_cities FROM city GROUP BY state_abbreviation;

SELECT state_abbreviation, COUNT(*) AS number_of_cities FROM city GROUP BY state_abbreviation ORDER BY number_of_cities DESC;

SELECT state_abbreviation, COUNT(*) AS number_of_cities FROM city GROUP BY state_abbreviation;

-- Determine the average park area depending upon whether parks allow camping or not.

SELECT has_camping, AVG(area) FROM park GROUP BY has_camping;


-- Sum of the population of cities in each state ordered by state abbreviation.

SELECT * FROM city;

SELECT state_abbreviation, COUNT(*) AS number_of_cities, SUM(population) AS sum_of_populations FROM city GROUP BY state_abbreviation ORDER BY state_abbreviation;


-- The smallest city population in each state ordered by city population.


SELECT state_abbreviation, MIN(population) AS min_population FROM city
GROUP BY state_abbreviation
ORDER BY min_population;

-- Miscelleneous

-- While you can use TOP to limit the number of results returned by a query,
-- it's recommended to use OFFSET and FETCH if you want to get
-- "pages" of results.
-- For instance, to get the first 10 rows in the city table
-- ordered by the name, you could use the following query.
-- (Skip 0 rows, and return only the first 10 rows from the sorted result set.)



-- SUBQUERIES (optional)

-- Include state name rather than the state abbreviation while counting the number of cities in each state,


-- Include the names of the smallest and largest parks


-- List the capital cities for the states in the Northeast census region.

