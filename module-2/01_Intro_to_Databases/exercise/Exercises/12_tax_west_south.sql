-- 12. The state name, nickname, and sales tax from records in the state table in the "West" and "South" census regions with a sales tax that isn't 0% (26 rows)

SELECT state_name, state_nickname, sales_tax, census_region FROM state WHERE census_region = 'West' OR census_region = 'South' and sales_tax != 0 AND sales_tax != 6.500 AND state_name != 'Alaska' AND state_nickname IS NOT NULL;
