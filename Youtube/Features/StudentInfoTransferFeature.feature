Feature: StudentInfoTransferFeature
	

@mytag
Scenario: Pass data through Specflow tables for Student object
	Given I have entered following info for Student
	| firstName | lastName | age | nationality |
	| zhiao     | li       | 28  | Chinese     |
	| luyang    | yu       | 29  | Canadian    |
	| test      | nobody   | 50  | Japanese    |
	Then Student info should be displayed
