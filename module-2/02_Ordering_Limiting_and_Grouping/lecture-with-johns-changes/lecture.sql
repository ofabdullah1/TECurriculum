-- ORDERING RESULTS

-- Populations of all states from largest to smallest.
SELECT * FROM state;

SELECT * FROM state ORDER BY state_name

SELECT * FROM city ORDER BY state_abbreviation, population DESC


-- States sorted alphabetically (A-Z) within their census region. The census regions are sorted in reverse alphabetical (Z-A) order.

SELECT * FROM state;

SELECT * FROM state ORDER BY census_region DESC, state_name

-- The biggest park by area

SELECT * FROM park;

SELECT * FROM park ORDER BY area DESC

SELECT TOP 10 percent * FROM park ORDER BY area ASC



-- LIMITING RESULTS

-- The 10 largest cities by populations

SELECT * FROM city;

SELECT TOP 20 * FROM city ORDER BY population DESC


-- The 20 oldest parks from oldest to youngest in years, sorted alphabetically by name.

SELECT  TOP 20 * FROM park ORDER BY date_established

SELECT TOP 20 park_id FROM park ORDER BY date_established


SELECT   * FROM park WHERE park_id IN (61,53,62,44,14) ORDER BY park_name 

SELECT * FROM park WHERE park_id 
IN (SELECT TOP 20 park_id FROM park ORDER BY date_established) 
ORDER BY park_name 



-- CONCATENATING OUTPUTS

-- All city names and their state abbreviation.

SELECT  city_name + ', ' + state_abbreviation 'City and State',* FROM city;


-- All park names and area


-- The census region and state name of all states in the West & Midwest sorted in ascending order.

SELECT census_region + ' - ' + state_name CensusAndState,* FROM state
WHERE census_region IN ('West', 'Midwest') AND 
CensusAndState LIKE 'M%'
ORDER BY CensusAndState

SELECT census_region + ' - ' + state_name CensusAndState,* FROM state
WHERE census_region IN ('West', 'Midwest') AND 
census_region + ' - ' + state_name LIKE 'M%'
ORDER BY CensusAndState




-- AGGREGATE FUNCTIONS

-- Average population across all the states. Note the use of alias, common with aggregated values.

SELECT *  FROM state;

SELECT AVG(population) average_polulation, Count(*) number_of_rows FROM state;




-- Total population in the West and South census regions

SELECT sum(population) FROM state
WHERE census_region IN ('West', 'South')




-- The number of cities with populations greater than 1 million

SELECT COUNT(*) FROM city
WHERE population > 1000000





-- The number of state nicknames.


-- The area of the smallest and largest parks.

SELECT * FROM park


SELECT MIN(area)  FROM park

SELECT MAX(area)  FROM park


SELECT MIN(area),  MAX(area), AVG(area), SUM(area)  FROM park



-- GROUP BY

-- Count the number of cities in each state, ordered from most cities to least.

SELECT  * FROM city

SELECT  * FROM city
GROUP BY state_abbreviation;

SELECT  state_abbreviation, COUNT(*)  number_of_cities FROM city
GROUP BY state_abbreviation

SELECT  state_abbreviation, COUNT(*)  number_of_cities FROM city
GROUP BY state_abbreviation
ORDER BY number_of_cities DESC




-- Determine the average park area depending upon whether parks allow camping or not.

SELECT * FROM park

SELECT * FROM park
GROUP BY has_camping


SELECT has_camping FROM park
GROUP BY has_camping

SELECT has_camping, AVG(area) average_area FROM park
GROUP BY has_camping




-- Sum of the population of cities in each state ordered by state abbreviation.

SELECT  state_abbreviation, COUNT(*)  number_of_cities, SUM(population) sum_of_populations FROM city
GROUP BY state_abbreviation
ORDER BY state_abbreviation


-- The smallest city population in each state ordered by city population.



SELECT state_abbreviation, MIN(population) min_population  FROM city
GROUP BY state_abbreviation
ORDER BY min_population

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

