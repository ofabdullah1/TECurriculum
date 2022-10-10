-- 19. The name, population, area, and population density (name the column 'population_density') of all states, territories, and districts (56 rows)
-- Population density is expressed as people per square kilometer. In other words, population divided by area.
SELECT state_name, population, area, (population/area) AS population_density FROM state;
--SELECT area *1000000 AS area_in_square_meters ,* FROM park;
