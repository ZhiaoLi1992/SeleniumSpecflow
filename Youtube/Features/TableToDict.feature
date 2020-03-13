Feature: TableToDict
	Transfer table to dictionary
@TTD
Scenario: Table to dictionary
	Given I have a table
	| id  | firstName |
	| 201 | Amaya     |
	| 202 | Kaden     |
	| 203 | Jubei     |
	| 204 | Bridget   |
	| 205 | Kiren     |
	| 206 | Joy       |
	| 207 | Owen      |
	| 208 | Dylan     |
	| 209 | Marcos    |
	| 210 | Hunter    |
	| 211 | Jacob     |
	Then transfer table to dictionary
